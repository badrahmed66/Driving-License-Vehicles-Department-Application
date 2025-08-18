using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
	public static  class TestProcedures
	{
		/// <summary>
		/// Retrieves the most recent test information for a specific person, license class, and test type.
		/// </summary>
		/// <param name="personID">ID of the person</param>
		/// <param name="licenseClass">ID of the license class</param>
		/// <param name="testTypeID">ID of the test type</param>
		/// <returns>The latest test record matching the criteria</returns>
		public const string GetLastTestInfo = "Tests_GetLastTestInfo";

		/// <summary>
		/// Retrieves all test records.
		/// </summary>
		/// <returns>All tests ordered by TestID</returns>
		public const string RetieveAll = "Tests_RetrieveAll";

		/// <summary>
		/// Retrieves a test record by its ID.
		/// </summary>
		/// <param name="TestID">ID of the test</param>
		/// <returns>Test record matching the specified ID</returns>
		public const string FindByID = "Tests_FindByID";

		/// <summary>
		/// Inserts a new test record and locks its associated test appointment.
		/// </summary>
		/// <param name="TestAppointmentID">ID of the test appointment</param>
		/// <param name="CreatedByUserID">ID of the user who created the test</param>
		/// <param name="TestResult">Result of the test (pass/fail)</param>
		/// <param name="Notes">Optional notes about the test</param>
		/// <returns>The ID of the newly created test record</returns>
		public const string Insert = "Tests_Insert";

		/// <summary>
		/// Updates an existing test record.
		/// </summary>
		/// <param name="TestID">Test identifier</param>
		/// <param name="TestAppointmentID">Associated test appointment ID</param>
		/// <param name="TestResult">Result of the test (pass/fail)</param>
		/// <param name="CreatedByUserID">User ID who updated the test</param>
		/// <param name="Notes">Optional notes for the test</param>
		public const string Update = "Tests_Update";

		/// <summary>
		/// Counts the number of passed tests for a given local driving license application.
		/// </summary>
		/// <param name="LocalDrivingLicenseID">ID of the local driving license application</param>
		/// <returns>Number of passed tests as an integer</returns>
		public const string CountPassedTests = "Tests_CountPassedTests";
	}
}
