using System;
using MyDVLD_DTOs;
using System.Collections.Generic;
using System.Data;

namespace MyDVLD_DAL.Interfaces
{
	/// <summary>
	/// Interface for data access operations related to Tests.
	/// Provides methods to retrieve, insert, update, and query tests in the system.
	/// </summary>
	public interface ITestDAL
	{
		/// <summary>
		/// Retrieves all the tests in the system as a DataTable.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all tests.</returns>
		DataTable RetrieveTests();

		/// <summary>
		/// Gets the last test information for a specific person, license, and test type.
		/// </summary>
		/// <param name="personID">The unique identifier of the person.</param>
		/// <param name="licenseID">The unique identifier of the License Class.</param>
		/// <param name="testTypeID">The unique identifier of the Test Type.</param>
		/// <returns>A <see cref="TestDTO"/> object representing the last test if found; otherwise, null.</returns>
		TestDTO GetLastTestInfo(int personID, int licenseID, int testTypeID);

		/// <summary>
		/// Finds a specific test by its unique identifier.
		/// </summary>
		/// <param name="id">The unique identifier of the test.</param>
		/// <returns>A <see cref="TestDTO"/> object if found; otherwise, null.</returns>
		TestDTO FindByID(int id);

		/// <summary>
		/// Inserts a new test into the system.
		/// </summary>
		/// <param name="testDTO">The <see cref="TestDTO"/> object containing test data.</param>
		/// <returns>The ID of the newly inserted test if successful; otherwise, -1.</returns>
		int Insert(TestDTO testDTO);

		/// <summary>
		/// Updates an existing test in the system.
		/// </summary>
		/// <param name="testDTO">The <see cref="TestDTO"/> object containing updated test data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		bool Update(TestDTO testDTO);

		/// <summary>
		/// Counts the number of passed tests for a specific Local Driving License ID.
		/// </summary>
		/// <param name="localDrivingLicenseID">The unique identifier for the Local Driving License application.</param>
		/// <returns>The number of passed tests as a byte value.</returns>
		byte CountPassedTests(int localDrivingLicenseID);
	}
}
