using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
    public static class LDLApplicationProcedures
    {

		/// <summary>
		/// Retrieves Local Driving License Applications with optional filters.
		/// </summary>
		/// <param name="localAppID">ID of the Local Driving License Application (optional)</param>
		/// <param name="nationalNo">National number of the person (optional)</param>
		/// <param name="fullName">Full name of the person (optional)</param>
		/// <param name="appStatus">Application status (optional)</param>

		public const string RetrieveWithFiltering = "LDLA_GetAllApplication2";

		/// <summary>
		/// Inserts a new Local Driving License Application into the system.
		/// </summary>
		/// <param name="applicationID">ID of the related application</param>
		/// <param name="licenseClassID">ID of the license class</param>
		/// <returns>Returns the new Local Driving License Application ID</returns>
		public const string Add = "LDLA_AddNew";

		/// <summary>
		/// Updates a local driving license application with new application ID and license class ID.
		/// </summary>
		/// <param name="localApplicationID">ID of the local driving license application to update</param>
		/// <param name="applicationID">New application ID to assign</param>
		/// <param name="licenseClassID">New license class ID to assign</param>
		/// <returns>None</returns>
		public const string Update = "LDLA_Update";

		/// <summary>
		/// Deletes a Local Driving License Application by its ID.
		/// </summary>
		/// <param name="localApplicationID">ID of the Local Driving License Application to delete</param>
		public const string Delete = "LDLA_Delete";

		/// <summary>
		/// Finds a local driving license application by either LDLApplicationID or ApplicationID.
		/// </summary>
		/// <param name="localDrivingID">Optional: LDLApplicationID to search for</param>
		/// <param name="applicationID">Optional: ApplicationID to search for</param>
		/// <returns>Local driving license application record matching the criteria</returns>
		public const string FindApplicationByID = "LDLApplication_FindApplicationByLDLApplicationIDorApplicationID";

		/// <summary>
		/// Checks if a Local Driving License Application exists for a given license class.
		/// </summary>
		/// <param name="localDrivingLicenseID">ID of the Local Driving License Application</param>
		/// <param name="licenseClassID">ID of the License Class</param>
		/// <returns>1 if exists, 0 otherwise</returns>
		public const string IsExists = "LDLA_IsExists";

		/// <summary>
		/// Checks if a person has a Local Driving License Application for a specific license class.
		/// </summary>
		/// <param name="personID">ID of the person</param>
		/// <param name="licenseClassID">ID of the license class</param>
		/// <returns>1 if such application exists, 0 otherwise</returns>
		public const string IsPersonHasLocalAppForThisLicenseClassID = "LDLA_IsPersonHasLocalAppForThisLicenseClass";

		/// <summary>
		/// Counts the total number of test attempts for a specific test type within a local driving license application.
		/// </summary>
		/// <param name="lDLAppID">ID of the local driving license application</param>
		/// <param name="testTypeID">ID of the test type</param>
		/// <returns>Total number of attempts for the specified test type</returns>
		public const string TotalTrailsPerTest = "LDLA_TotalTrailsPerTest";

		/// <summary>
		/// Checks if a Local Driving License Application has passed a specific test type.
		/// </summary>
		/// <param name="lDLAppID">ID of the Local Driving License Application</param>
		/// <param name="testTypeID">ID of the test type</param>
		public const string HasPassedThisTest = "LDLA_HasPassedTestType";

		/// <summary>
		/// Checks if a specific test type has been attended for a Local Driving License Application.
		/// </summary>
		/// <param name="lDLAppID">ID of the Local Driving License Application</param>
		/// <param name="testTypeID">ID of the test type</param>
		public const string HasTheTestBeenAttended = "LDLA_HasTheTestBeenAttended";

	/// <summary>
		/// Checks if a Local Driving License Application has an active schedule appointment for a specific test type.
		/// </summary>
		/// <param name="testTypeID">ID of the test type</param>
		/// <param name="lDlAppID">ID of the Local Driving License Application</param>
		public const string HasActiveScheduleAppointmentForTestType = "LDLA_HasActiveScheduleAppointmentForTestType";
    }
}
