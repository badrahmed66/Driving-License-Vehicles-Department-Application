using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using MyDVLD_DAL;
using MyDVLD_BLL.Validation;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Service class to manage Application Types in the system.
	/// Provides methods to insert, update, retrieve, and find application types.
	/// </summary>
	public class ApplicationTypeService
	{
		/// <summary>
		/// Holds the current ApplicationType information.
		/// </summary>
		private ApplicationTypeDTO ApplicationTypeInfo { get; set; }

		/// <summary>
		/// Initializes a new instance of <see cref="ApplicationTypeService"/> with an empty DTO.
		/// </summary>
		public ApplicationTypeService()
		{
			ApplicationTypeInfo = new ApplicationTypeDTO();
		}

		/// <summary>
		/// Initializes a new instance of <see cref="ApplicationTypeService"/> with a specific DTO.
		/// </summary>
		/// <param name="appDTO">The application type DTO.</param>
		public ApplicationTypeService(ApplicationTypeDTO appDTO)
		{
			ApplicationTypeInfo = appDTO;
		}

		/// <summary>
		/// Sets the current ApplicationType data.
		/// </summary>
		/// <param name="id">Application Type ID.</param>
		/// <param name="title">Title of the application type.</param>
		/// <param name="fees">Associated fees.</param>
		public void SetApplicationTypeData(int id, string title, decimal fees)
		{
			ApplicationTypeInfo.ID = id;
			ApplicationTypeInfo.Title = title;
			ApplicationTypeInfo.Fees = fees;
		}

		/// <summary>
		/// Retrieves all application types in the system.
		/// </summary>
		/// <returns>A list of <see cref="ApplicationTypeDTO"/> objects.</returns>
		static public List<ApplicationTypeDTO> RetrieveApplicationAllApplicationType()
		{
			return ApplicationTypeDAL.Retrieve();
		}

		/// <summary>
		/// Finds a specific application type by its ID.
		/// </summary>
		/// <param name="id">The application type ID.</param>
		/// <returns>The corresponding <see cref="ApplicationTypeDTO"/> if found; otherwise null.</returns>
		static public ApplicationTypeDTO FindApplicationTypeByID(int id)
		{
			if (id <= 0) return null;
			return ApplicationTypeDAL.FindByID(id);
		}

		/// <summary>
		/// Inserts the current application type into the system.
		/// </summary>
		/// <param name="message">Output message describing success or failure.</param>
		/// <returns>True if insertion was successful; otherwise false.</returns>
		public bool InsertApplicationType(out string message)
		{
			message = "";

			if (ApplicationTypeInfo == null)
			{
				message = "Invalid Application Type";
				return false;
			}

			if (ApplicationTypeValidator.IsExists(ApplicationTypeInfo.Title))
			{
				message = "This Title Already Exists in the system";
				return false;
			}

			int id = ApplicationTypeDAL.Insert(ApplicationTypeInfo);

			if (id > 0)
			{
				message = "Application Type Added Successfully";
				ApplicationTypeInfo.ID = id;
				return true;
			}
			else
			{
				message = "Could not add";
				return false;
			}
		}

		/// <summary>
		/// Updates the current application type in the system.
		/// </summary>
		/// <param name="message">Output message describing success or failure.</param>
		/// <returns>True if update was successful; otherwise false.</returns>
		public bool UpdateApplicationType(out string message)
		{
			message = "";

			if (ApplicationTypeInfo == null)
			{
				message = "Invalid Application Type";
				return false;
			}

			if (ApplicationTypeValidator.IsExistsExcludingItself(ApplicationTypeInfo.Title, ApplicationTypeInfo.ID))
			{
				message = "This Title is already taken by another Application Type";
				return false;
			}

			if (ApplicationTypeDAL.Update(ApplicationTypeInfo))
			{
				message = "Application Type Updated Successfully";
				return true;
			}
			else
			{
				message = "Application Type could not update";
				return false;
			}
		}
	}
}
