using System;

namespace MyDVLD_DAL.StoredProcedure
{
  public static class ApplicationProcedures
  {

	/// <summary>
		/// Retrieves applications with optional filtering.
		/// </summary>
		/// <param name="applicationID">int?</param>
		/// <param name="personID">int?</param>
		/// <param name="applicationTypeID">int?</param>
		/// <param name="applicationStatus">tinyint?</param>
		/// <returns>List of applications matching the filters</returns>
		public const string RetrieveWithFilter = "Applications_RetrieveApplications";

	/// <summary>
		/// Inserts a new application into the Applications table and returns its ID.
		/// </summary>
		/// <param name="personID">int</param>
		/// <param name="createdByUserID">int</param>
		/// <param name="ApplicationTypeID">int</param>
		/// <param name="ApplicationpaidFees">decimal(18,2)</param>
		/// <param name="ApplicationlastStatusDate">datetime2</param>
		/// <param name="ApplicationDate">datetime2</param>
		/// <param name="ApplicationStatus">tinyint</param>
		/// <returns>int - ID of the new application</returns>
		/// 
		public const string Add = "Applications_AddNewApplication";

	/// <summary>
		/// Updates an existing application with new values.
		/// </summary>
		/// <param name="personID">int</param>
		/// <param name="createdByUserID">int</param>
		/// <param name="ApplicationTypeID">int</param>
		/// <param name="paidFees">decimal(18,2)</param>
		/// <param name="lastStatusUpdateDate">datetime2</param>
		/// <param name="appDate">datetime2</param>
		/// <param name="status">tinyint</param>
		/// <param name="applicationID">int</param>
		public const string Update = "Applications_UpdateApplication";

	/// <summary>
		/// Deletes an application from the Applications table by its ID.
		/// </summary>
		/// <param name="applicationID">int</param>
		/// <returns>void</returns>
		public const string Delete = "Applications_DeleteApplication";

		/// <summary>
		/// Retrieves an application from the Applications table by its ID.
		/// </summary>
		/// <param name="applicationID">int</param>
		/// <returns>Application record</returns>
		public const string FindByID = "Applications_FindApplication";

	/// <summary>
		/// Checks if a person has an existing application for a specific application type.
		/// </summary>
		/// <param name="personID">int</param>
		/// <param name="applicationType">int</param>
		/// <param name="exists">BIT OUTPUT</param>
		/// <returns>Sets exists to 1 if an application exists, otherwise 0</returns>
		public const string HasExistedRequest = "Applications_HasExistingRequest";

	/// <summary>
		/// Updates the status and last status date of a specific application.
		/// </summary>
		/// <param name="applicationID">int</param>
		/// <param name="newStatus">tinyint</param>
		/// <param name="lastStatusDate">datetime</param>
		public const string UpdateStatus = "Applications_UpdateStatus";

	/// <summary>
		/// Gets the active application ID for a specific person and application type.
		/// </summary>
		/// <param name="personID">int</param>
		/// <param name="applicationTypeID">int</param>
		/// <returns>Active ApplicationID (int)</returns>
		public const string GetActiveAppID = "Applications_GetActiveAppID";

	/// <summary>
		/// Checks if an application exists by its ID.
		/// </summary>
		/// <param name="applicationID">int</param>
		/// <returns>Returns 1 if the application exists</returns>
		public const string IsExist = "Applications_IsExist";

	/// <summary>
		/// Gets the active application ID for a specific person, application type, and license class.
		/// </summary>
		/// <param name="personID">int</param>
		/// <param name="appTypeID">int</param>
		/// <param name="licenseID">int</param>
		/// <returns>Active ApplicationID (int)</returns>
		public const string GetActiveAppIDForSpecificLicense = "Applications_GetActiveAppIDForSpecificLicense";

	}
}
