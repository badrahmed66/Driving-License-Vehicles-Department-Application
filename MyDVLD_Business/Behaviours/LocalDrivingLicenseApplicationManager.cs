using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using MyDVLD_DAL;
using MyDVLD_BLL.Validations;
using System.Runtime.InteropServices;
using MyDVLD_DTOs;
using MyDVLD_Business.Interfaces;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Represents a manager for handling Local Driving License Applications.
	/// Provides methods for inserting, updating, retrieving, deleting applications and handling related license operations.
	/// </summary>
	public class LocalDrivingLicenseApplicationManager
	{
		private readonly LocalDrivingLicenseApplicationDTO _localApplication;
		private readonly IDriverService _driverService;
		private readonly ILicenseService _licenseService;

		/// <summary>
		/// Initializes a new instance of <see cref="LocalDrivingLicenseApplicationManager"/> with the specified DTO, driver service, and license service.
		/// </summary>
		/// <param name="dto">The local driving license application DTO.</param>
		/// <param name="driver">The driver service.</param>
		/// <param name="licenseService">The license service.</param>
		public LocalDrivingLicenseApplicationManager(LocalDrivingLicenseApplicationDTO dto, IDriverService driver, ILicenseService licenseService)
		{
			_localApplication = dto ?? throw new ArgumentNullException(nameof(dto));
			_driverService = driver;
			_licenseService = licenseService;
		}

		/// <summary>
		/// Initializes a new instance of <see cref="LocalDrivingLicenseApplicationManager"/> with default empty DTO.
		/// </summary>
		public LocalDrivingLicenseApplicationManager()
		{
			_localApplication = new LocalDrivingLicenseApplicationDTO
			{
				ApplicationInfo = new ApplicationDTO(),
				LicenseClassesInfo = new LicenseClassesDTO()
			};
		}

		/// <summary>
		/// Retrieves a list of Local Driving License applications with optional filtering.
		/// </summary>
		/// <param name="filterColumn">Column name to filter.</param>
		/// <param name="filterValue">Value to filter by.</param>
		/// <returns>List of filtered applications.</returns>
		public static List<LocalDrivingLicenseApplicationViewDTO> RetrieveLDLApplicatoinsWithFiltering(string filterColumn = "", string filterValue = "")
		{
			return LocalDrivingLicenseApplicationDAL.RetrieveLDLApplicationsWithFilter(filterColumn, filterValue);
		}

		/// <summary>
		/// Inserts the current Local Driving License application into the system.
		/// </summary>
		/// <param name="message">Output message describing the result.</param>
		/// <returns>True if insertion is successful; otherwise, false.</returns>
		public bool InsertLDLApplication(out string message)
		{
			if (LDLApplicationValidator.VerifyDidPersonHaveLDLApplicationForThisLicenseClass(_localApplication.ApplicationInfo.PersonID, _localApplication.LicenseClassID))
			{
				message = "Local Driving License Application Already Found in the system";
				return false;
			}
			int localID = LocalDrivingLicenseApplicationDAL.InsertLDLApplication(_localApplication);
			if (localID > 0)
			{
				message = "Local Driving License Application Inserted Successfuly";
				_localApplication.LocalDrivingLicenseAppID = localID;
				return true;
			}
			else
			{
				message = "An error Occure while Inserting the Local Driving License Application";
				return false;
			}
		}

		/// <summary>
		/// Updates the current Local Driving License application.
		/// </summary>
		/// <param name="message">Output message describing the result.</param>
		/// <returns>True if update is successful; otherwise, false.</returns>
		public bool UpdateLDLApplication(out string message)
		{
			if (LDLApplicationValidator.VerifyLDLApplicationForLicenseClassIDExists(_localApplication.LocalDrivingLicenseAppID, _localApplication.LicenseClassID))
			{
				message = "There's Already An Application For This ID";
				return false;
			}
			bool isUpdated = LocalDrivingLicenseApplicationDAL.UpdateLDLApplication(_localApplication);
			if (isUpdated)
			{
				message = "Local Driving License Application Updated Successfuly";
				return true;
			}
			else
			{
				message = "An error occure while updating The Application";
				return false;
			}
		}

		/// <summary>
		/// Finds a Local Driving License application by its LDL ID or Application ID.
		/// </summary>
		/// <param name="message">Output message describing the result.</param>
		/// <param name="localDrivingID">Optional LDL Application ID.</param>
		/// <param name="applicationID">Optional base Application ID.</param>
		/// <returns>The found Local Driving License DTO or null.</returns>
		public static LocalDrivingLicenseApplicationDTO FindLDLApplicationByLDLAppIDorApplicationID(out string message, int? localDrivingID = null, int? applicationID = null)
		{
			message = "";
			if ((localDrivingID == null && applicationID == null) || (localDrivingID != null && applicationID != null))
			{
				message = "you must Insert only LDLApplicationID or ApplicationID";
				return null;
			}
			else if (localDrivingID <= 0 || applicationID <= 0)
			{
				message = "The Value must be over than Zero";
				return null;
			}

			var localDTO = LocalDrivingLicenseApplicationDAL.FindLDLApplicationByLDLApplicationIDorApplicationID(localDrivingID, applicationID);

			if (localDTO != null)
			{
				localDTO.ApplicationInfo = ApplicationService.FindApplicationByID(localDTO.ApplicationID);
				localDTO.LicenseClassesInfo = LicenseClassService.FindByLicenseIDOrTitle(localDTO.LicenseClassID);
			}

			return localDTO;
		}

		/// <summary>
		/// Deletes the current Local Driving License application.
		/// </summary>
		/// <returns>True if deletion is successful; otherwise, false.</returns>
		public bool Delete()
		{
			return Delete(_localApplication.LocalDrivingLicenseAppID, _localApplication.ApplicationID);
		}

		/// <summary>
		/// Deletes a Local Driving License application by IDs.
		/// </summary>
		/// <param name="localDrivingID">LDL Application ID.</param>
		/// <param name="applicationID">Base Application ID.</param>
		/// <returns>True if deletion is successful; otherwise, false.</returns>
		public static bool Delete(int localDrivingID, int applicationID)
		{
			bool isLocalDrivingAppDeleted = LocalDrivingLicenseApplicationDAL.DeleteLDLApplication(localDrivingID);

			bool isBaseAppDeleted = false;

			if (!isLocalDrivingAppDeleted)
				return false;

			isBaseAppDeleted = ApplicationService.DeleteApplication(applicationID, out string message);

			return isBaseAppDeleted;
		}

		/// <summary>
		/// Checks if the current application has attended the specified test type.
		/// </summary>
		/// <param name="testTypeID">Test type ID.</param>
		/// <returns>True if attended; otherwise, false.</returns>
		public bool HasAttendedTest(TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.HasAttendedTest(_localApplication.LocalDrivingLicenseAppID, (int)testTypeID);
		}

		/// <summary>
		/// Static version: Checks if an application has attended a specific test type.
		/// </summary>
		public static bool HasAttendedTest(int localDrivingID, TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.HasAttendedTest(localDrivingID, (int)testTypeID);
		}

		/// <summary>
		/// Checks if the current application has passed the specified test type.
		/// </summary>
		public bool HasPassedTest(TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.HasPassedTest(_localApplication.LocalDrivingLicenseAppID, (int)testTypeID);
		}

		/// <summary>
		/// Static version: Checks if an application has passed a specific test type.
		/// </summary>
		public static bool HasPassedTest(int localDrivingID, TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.HasPassedTest(localDrivingID, (int)testTypeID);
		}

		/// <summary>
		/// Checks if the current application has an active scheduled appointment for the specified test type.
		/// </summary>
		public bool HasActiveScheduleAppointment(TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.HasActiveScheduleAppointment(_localApplication.LocalDrivingLicenseAppID, (int)testTypeID);
		}

		/// <summary>
		/// Static version: Checks for active scheduled appointment.
		/// </summary>
		public static bool HasActiveScheduleAppointment(int localDrivingID, TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.HasActiveScheduleAppointment(localDrivingID, (int)testTypeID);
		}

		/// <summary>
		/// Returns the total number of trials for a given test type for the current application.
		/// </summary>
		public byte TotalTrialsPerTest(TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.TotalTrailsTests(_localApplication.LocalDrivingLicenseAppID, (int)testTypeID);
		}

		/// <summary>
		/// Static version: Returns the total number of trials for a given test type for a specific application.
		/// </summary>
		public static byte TotalTrialsPerTest(int localDrivingID, TestTypeDTO.EnTestType testTypeID)
		{
			return LocalDrivingLicenseApplicationDAL.TotalTrailsTests(localDrivingID, (int)testTypeID);
		}

		/// <summary>
		/// Issues a new license for a person for the first time based on the current application.
		/// </summary>
		/// <param name="notes">Notes for the license.</param>
		/// <param name="createdByUserID">User ID who creates the license.</param>
		/// <param name="personID">Person ID to issue the license for.</param>
		/// <returns>New License ID if successful; otherwise, -1.</returns>
		public int IssueLicenseForFirstTime(string notes, int createdByUserID, int personID)
		{
			DriverDTO driverInfo = _driverService.FindByPersonID(personID);

			int driverID = -1;

			if (driverInfo == null)
			{
				// create a new driver object
				DriverDTO newDriverInfo = new DriverDTO();

				newDriverInfo.CreatedByUserID = createdByUserID;
				newDriverInfo.PersonID = personID;
				newDriverInfo.CreatedDate = DateTime.Now;

				if (_driverService.Save(newDriverInfo))
				{
					driverID = newDriverInfo.DriverID;
				}
				else
					return -1;
			}
			else
				driverID = driverInfo.DriverID;

			// create new license and add it into the system
			LicenseDTO newLicense = new LicenseDTO();
			newLicense.DriverID = driverID;
			newLicense.CreatedByUserID = createdByUserID;
			newLicense.ApplicationID = _localApplication.ApplicationID;
			newLicense.Notes = notes;
			newLicense.PaidFees = _localApplication.LicenseClassesInfo.LicenseFees;
			newLicense.IsActive = true;
			newLicense.IssueDate = DateTime.Now;
			newLicense.IssueReason = LicenseDTO.EnIssueReason.FirstTime;
			newLicense.LicenseClassID = _localApplication.LicenseClassID;
			newLicense.ExpirationDate = DateTime.Now.AddYears(_localApplication.LicenseClassesInfo.LicenseDefaultValidateLength);

			// now add the license
			if (_licenseService.Save(newLicense))
			{
				return newLicense.LicenseID;
			}
			else
				return -1;
		}
	}
}
