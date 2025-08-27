using MyDVLD_BLL;
using MyDVLD_BLL.Validations;
using MyDVLD_DAL;
using MyDVLD_DAL.Utility;
using MyDVLD_DTO;
using MyDVLD_DTO.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Service class for managing applications in the system.
	/// Provides methods to add, update, cancel, complete, and query applications.
	/// </summary>
	public class ApplicationService
	{
		private readonly ApplicationDTO ApplicationInfo;

		/// <summary>
		/// Initializes a new instance of <see cref="ApplicationService"/> with a specific <see cref="ApplicationDTO"/>.
		/// Automatically loads related Person, User, and ApplicationType details.
		/// </summary>
		/// <param name="app">The application DTO object.</param>
		/// <exception cref="ArgumentNullException">Thrown if the app or related objects are null.</exception>
		public ApplicationService(ApplicationDTO app)
		{
			ApplicationInfo = app ?? throw new ArgumentNullException(nameof(app));

			// Load related DTOs
			ApplicationInfo.PersonInfoDTO = PersonService.FindPersonByIDOrNationalNo(out string m, ApplicationInfo.PersonID, null) ?? throw new ArgumentNullException(nameof(app));
			ApplicationInfo.UserInfoDTO = UserService.FindUserDetails(ApplicationInfo.CreatedByUserID) ?? throw new ArgumentNullException(nameof(app));
			ApplicationInfo.ApplicationTypeInfoDTO = ApplicationTypeService.FindApplicationTypeByID(ApplicationInfo.ApplicationTypeID) ?? throw new ArgumentNullException(nameof(app));
		}

		/// <summary>
		/// Initializes a new instance of <see cref="ApplicationService"/> with empty DTOs.
		/// </summary>
		public ApplicationService()
		{
			ApplicationInfo = new ApplicationDTO
			{
				PersonInfoDTO = new PersonDTO(),
				UserInfoDTO = new UserDTO(),
				ApplicationTypeInfoDTO = new ApplicationTypeDTO()
			};
		}

		/// <summary>
		/// Adds a new application to the system.
		/// </summary>
		/// <param name="message">Output message describing success or failure.</param>
		/// <returns>True if insertion was successful; otherwise false.</returns>
		public bool AddApplication(out string message)
		{
			int appID = ApplicationDAL.InsertApplication(ApplicationInfo);

			if (appID > 0)
			{
				message = "Application Inserted Successfully";
				ApplicationInfo.ApplicationID = appID;

				LogFile.AddLogToFile(nameof(ApplicationService), nameof(AddApplication), $"New Application Has Added with ID ({appID} - Type : {ApplicationInfo.ApplicationTypeInfoDTO.Title})", LogFile.ApplicationsInfo);
				return true;
			}
			else
			{
				message = "An error occurred while inserting the application";
				return false;
			}
		}

		/// <summary>
		/// Updates the current application if its status is New.
		/// </summary>
		/// <param name="message">Output message describing success or failure.</param>
		/// <returns>True if update was successful; otherwise false.</returns>
		public bool UpdateApplication(out string message)
		{
			if (ApplicationInfo.ApplicationStatus != ApplicationDTO.Status.New)
			{
				message = "You can update only New Applications";
				return false;
			}

			if (ApplicationDAL.UpdateApplication(ApplicationInfo))
			{
				message = "Application Updated Successfully";
				LogFile.AddLogToFile(nameof(ApplicationService), nameof(UpdateApplication), $"Application with ID ({ApplicationInfo.ApplicationID} - Type : {ApplicationInfo.ApplicationTypeInfoDTO.Title} Has Updated)", LogFile.ApplicationsInfo);
				return true;
			}
			else
			{
				message = "An error occurred while updating the application";
				return false;
			}
		}

		/// <summary>
		/// Deletes an application by its ID.
		/// </summary>
		/// <param name="appID">The application ID to delete.</param>
		/// <param name="errorMessage">Output message describing success or failure.</param>
		/// <returns>True if deletion was successful; otherwise false.</returns>
		public static bool DeleteApplication(int appID, out string errorMessage)
		{
			if (appID <= 0)
			{
				errorMessage = "Invalid Application";
				return false;
			}

			if (ApplicationDAL.DeleteApplication(appID))
			{
				errorMessage = "Application Deleted Successfully";
				LogFile.AddLogToFile(nameof(ApplicationService), nameof(DeleteApplication), $"Application with ID ({appID}) Has Deleted", LogFile.ApplicationsInfo);
				return true;
			}
			else
			{
				errorMessage = "An error occurred while deleting the application";
				return false;
			}
		}

		/// <summary>
		/// Finds an application by its ID and loads related DTOs.
		/// </summary>
		/// <param name="appID">The application ID to find.</param>
		/// <returns>The <see cref="ApplicationDTO"/> if found; otherwise null.</returns>
		public static ApplicationDTO FindApplicationByID(int appID)
		{
			if (appID <= 0) return null;

			ApplicationDTO appInfo = ApplicationDAL.FindApplicatioinByID(appID);
			if (appInfo == null) return null;

			appInfo.PersonInfoDTO = PersonService.FindPersonByIDOrNationalNo(out string message, appInfo.PersonID, null);
			appInfo.UserInfoDTO = UserService.FindUserDetails(appInfo.CreatedByUserID);
			appInfo.ApplicationTypeInfoDTO = ApplicationTypeService.FindApplicationTypeByID(appInfo.ApplicationTypeID);

			return appInfo;
		}

		/// <summary>
		/// Cancels the current application.
		/// </summary>
		/// <returns>True if operation was successful; otherwise false.</returns>
		public bool Cancel()
		{
			LogFile.AddLogToFile(nameof(ApplicationService), nameof(Cancel), $"Application with ID ({ApplicationInfo.ApplicationID}) - Type : {ApplicationInfo.ApplicationTypeInfoDTO.Title} Has Canceled", LogFile.ApplicationsInfo);
			return ApplicationDAL.UpdateStatus(ApplicationInfo.ApplicationID, 2);
		}

		/// <summary>
		/// Marks the current application as complete.
		/// </summary>
		/// <returns>True if operation was successful; otherwise false.</returns>
		public bool SetComplete()
		{
			LogFile.AddLogToFile(nameof(ApplicationService), nameof(SetComplete), $"Application with ID ({ApplicationInfo.ApplicationID})- Type : {ApplicationInfo.ApplicationTypeInfoDTO.Title} Has Completed", LogFile.ApplicationsInfo);
			return ApplicationDAL.UpdateStatus(ApplicationInfo.ApplicationID, 3);
		}

		/// <summary>
		/// Marks a specific application as complete.
		/// </summary>
		/// <param name="applicationID">The application ID.</param>
		/// <returns>True if operation was successful; otherwise false.</returns>
		public static bool SetComplete(int applicationID)
		{
			LogFile.AddLogToFile(nameof(ApplicationService), nameof(SetComplete), $"Application with ID ({applicationID}) Has Completed", LogFile.ApplicationsInfo);
			return ApplicationDAL.UpdateStatus(applicationID, 3);
		}

		/// <summary>
		/// Gets the active application ID for the current instance and specified type.
		/// </summary>
		/// <param name="appTypeID">The application type ID.</param>
		/// <returns>The active application ID if exists; otherwise 0.</returns>
		public int GetActiveAppID(int appTypeID)
		{
			return ApplicationDAL.GetActiveAppID(ApplicationInfo.PersonID, appTypeID);
		}

		/// <summary>
		/// Gets the active application ID for a person and application type.
		/// </summary>
		/// <param name="personID">The person ID.</param>
		/// <param name="appTypeID">The application type ID.</param>
		/// <returns>The active application ID if exists; otherwise 0.</returns>
		public static int GetActiveAppID(int personID, int appTypeID)
		{
			return ApplicationDAL.GetActiveAppID(personID, appTypeID);
		}

		/// <summary>
		/// Gets the active application ID for a person, application type, and specific license.
		/// </summary>
		/// <param name="personID">The person ID.</param>
		/// <param name="appTypeID">The application type ID.</param>
		/// <param name="licenseID">The specific license ID.</param>
		/// <returns>The active application ID if exists; otherwise 0.</returns>
		public static int GetActiveAppIDForSpecificLicense(int personID, int appTypeID, int licenseID)
		{
			return ApplicationDAL.GetActiveAppIDForSpecificLicense(personID, appTypeID, licenseID);
		}

		/// <summary>
		/// Checks if a specific application exists.
		/// </summary>
		/// <param name="appID">The application ID to check.</param>
		/// <returns>True if exists; otherwise false.</returns>
		public static bool IsExist(int appID)
		{
			return ApplicationDAL.IsExist(appID);
		}

		/// <summary>
		/// Checks if the current instance has an active application for a type.
		/// </summary>
		/// <param name="appTypeID">The application type ID.</param>
		/// <returns>True if active application exists; otherwise false.</returns>
		public bool HadActiveApplication(int appTypeID)
		{
			return ApplicationDAL.HasActiveApplication(ApplicationInfo.PersonID, appTypeID);
		}

		/// <summary>
		/// Checks if a person has an active application for a type.
		/// </summary>
		/// <param name="personID">The person ID.</param>
		/// <param name="appTypeID">The application type ID.</param>
		/// <returns>True if active application exists; otherwise false.</returns>
		public static bool HadActiveApplication(int personID, int appTypeID)
		{
			return ApplicationDAL.HasActiveApplication(personID, appTypeID);
		}
	}
}
