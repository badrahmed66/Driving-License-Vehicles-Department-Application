using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
  public static class ApplicationTypeProcedures
  {

		/// <summary>
		/// Retrieves all application types.
		/// </summary>
		/// <returns>All records from ApplicationTypes table</returns>
		public const string Retrieve = "ApplicationTypes_RetrieveApplicationTypes";

		/// <summary>
		/// Finds an application type by its ID.
		/// </summary>
		/// <param name="applicationTypeID">int</param>
		/// <returns>ApplicationType record</returns>
		public const string FindByID = "ApplicationTypes_FindApplicationTypeByID";

    /// <summary>
		/// Inserts a new application type and returns its ID.
		/// </summary>
		/// <param name="applicationTypeID">int</param>
		/// <param name="applicationTypeTitle">nvarchar(250)</param>
		/// <param name="applicationTypeFees">decimal(18,2)</param>
		/// <returns>int (newly created ApplicationTypeID)</returns>
    public const string Add = "ApplicationTypes_AddNewApplicationType";

		/// <summary>
		/// Updates an existing application type.
		/// </summary>
		/// <param name="applicationTypeID">ID of the application type to update</param>
		/// <param name="applicationTypeTitle">New title for the application type</param>
		/// <param name="applicationTypeFees">New fees for the application type</param>
		public const string Update = "ApplicationTypes_UpdateApplicationType";

		/// <summary>
		/// Checks if an application type title already exists.
		/// </summary>
		/// <param name="applicationTypeTitle">nvarchar(250)</param>
		/// <returns>bit (1 if exists, 0 if not)</returns>
		public const string IsExistsByTitle = "ApplicationTypes_IsApplicationTypeTitleExists";

	/// <summary>
		/// Checks if an application type title exists excluding a specific type ID.
		/// </summary>
		/// <param name="applicationTypeID">INT</param>
		/// <param name="applicationTypeTitle">nvarchar(250)</param>
		/// <returns>bit (1 if exists, 0 if not)</returns>
		public const string ISExistsExcludingItself = "ApplicationTypes_IsApplicationTypeTitleExistsExcludingItself";

		/// <summary>
		/// Deletes an application type by its ID.
		/// </summary>
		/// <param name="applicationTypeID">int</param>
		public const string Delete = "ApplicationTypes_DeleteApplicatonType";
  }
}
