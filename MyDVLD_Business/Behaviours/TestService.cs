using System;
using MyDVLD_DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDVLD_DTO;
using MyDVLD_DAL.Behaviours;
using MyDVLD_DAL.Interfaces;
using System.Data;
using MyDVLD_Business.Interfaces;

namespace MyDVLD_Business.Behaviours
{
	/// <summary>
	/// Service class for managing Tests.
	/// Handles retrieval, insertion, updating, and validation of Test records.
	/// </summary>
	public class TestService : ITestService
	{
		private readonly ITestDAL _testDAL;

		/// <summary>
		/// Initializes a new instance of <see cref="TestService"/> with the specified DAL interface.
		/// </summary>
		/// <param name="testDal">The test data access layer interface.</param>
		public TestService(ITestDAL testDal)
		{
			_testDAL = testDal;
		}

		/// <summary>
		/// Gets the last test information for a given person, license, and test type.
		/// </summary>
		/// <param name="personID">The person ID.</param>
		/// <param name="licenseID">The license ID.</param>
		/// <param name="testType">The type of test.</param>
		/// <returns>The last test DTO if found; otherwise, null.</returns>
		public TestDTO GetLastTestInfo(int personID, int licenseID, TestTypeDTO.EnTestType testType)
		{
			if (personID <= 0 || licenseID <= 0 || (int)testType <= 0) return null;

			TestDTO testDto = _testDAL.GetLastTestInfo(personID, licenseID, (int)testType);

			if (testDto != null)
				testDto.TestAppointmentInfo = TestAppointmentService.Find(testDto.TestAppointmentID);

			return testDto;
		}

		/// <summary>
		/// Retrieves all tests as a DataTable.
		/// </summary>
		/// <returns>DataTable containing all tests.</returns>
		public DataTable RetrieveAll()
		{
			return _testDAL.RetrieveTests();
		}

		/// <summary>
		/// Counts the number of passed tests for a given local driving license.
		/// </summary>
		/// <param name="localDrivingLicenseID">The local driving license ID.</param>
		/// <returns>Number of passed tests.</returns>
		public byte CountPassedTests(int localDrivingLicenseID)
		{
			if (localDrivingLicenseID <= 0) return 0;

			return _testDAL.CountPassedTests(localDrivingLicenseID);
		}

		/// <summary>
		/// Finds a test by its ID.
		/// </summary>
		/// <param name="testID">The test ID.</param>
		/// <returns>The test DTO if found; otherwise, null.</returns>
		public TestDTO FindByID(int testID)
		{
			if (testID <= 0) return null;

			TestDTO testDTO = _testDAL.FindByID(testID);

			if (testDTO != null)
			{
				testDTO.TestAppointmentInfo = TestAppointmentService.Find(testDTO.TestAppointmentID);
			}
			return testDTO;
		}

		/// <summary>
		/// Inserts a new test into the database.
		/// </summary>
		/// <param name="testDTO">The test DTO.</param>
		/// <returns>The new test ID.</returns>
		private int Insert(TestDTO testDTO)
		{
			return _testDAL.Insert(testDTO);
		}

		/// <summary>
		/// Updates an existing test in the database.
		/// </summary>
		/// <param name="testDTO">The test DTO.</param>
		/// <returns>True if update is successful; otherwise, false.</returns>
		private bool Update(TestDTO testDTO)
		{
			return _testDAL.Update(testDTO);
		}

		/// <summary>
		/// Saves the test. Decides between inserting or updating based on TestID.
		/// </summary>
		/// <param name="testDTO">The test DTO.</param>
		/// <returns>True if save is successful; otherwise, false.</returns>
		public bool Save(TestDTO testDTO)
		{
			bool isNewDTO = testDTO.TestID <= 0;

			switch (isNewDTO)
			{
				case true:
					{
						int newID = Insert(testDTO);
						if (newID > 0)
						{
							testDTO.TestID = newID;
							return true;
						}
						return false;
					}

				case false:
					return Update(testDTO);
			}

			return false;
		}

		/// <summary>
		/// Checks if all tests are passed for a given local driving license.
		/// </summary>
		/// <param name="localDrivingLicenseID">The local driving license ID.</param>
		/// <returns>True if all tests passed; otherwise, false.</returns>
		public bool PassedAllTests(int localDrivingLicenseID)
		{
			return (CountPassedTests(localDrivingLicenseID) == 3);
		}
	}
}
