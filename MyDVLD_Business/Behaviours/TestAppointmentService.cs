using MyDVLD_BLL;
using MyDVLD_DAL.Behaviours;
using MyDVLD_DTO.User;
using MyDVLD_DTO;
using MyDVLD_DTOs.TestAppointment;
using MyDVLD_DTOs.LocalDrivingLicenseApp;
using System;
using System.Collections.Generic;
using System.Data;
using static MyDVLD_DTO.TestTypeDTO;

namespace MyDVLD_Business.Behaviours
{
	/// <summary>
	/// Service class for managing Test Appointments.
	/// Provides methods to insert, update, retrieve, and query test appointments.
	/// </summary>
	public class TestAppointmentService
	{
		/// <summary>
		/// Base DTO holding the Test Appointment information.
		/// </summary>
		public readonly TestAppointmentDTO _testAppointmentInfo;

		/// <summary>
		/// Initializes a new instance of <see cref="TestAppointmentService"/> with default empty DTO.
		/// </summary>
		public TestAppointmentService()
		{
			_testAppointmentInfo = new TestAppointmentDTO
			{
				TestTypeInfo = new TestTypeDTO(),
				UserInfo = new UserDTO(),
				LocalDrivingLicenseApplicationInfo = new LocalDrivingLicenseApplicationDTO(),
				RetakeTestInfo = new ApplicationDTO()
			};
		}

		/// <summary>
		/// Initializes a new instance of <see cref="TestAppointmentService"/> with the specified DTO.
		/// </summary>
		/// <param name="dto">The test appointment DTO.</param>
		public TestAppointmentService(TestAppointmentDTO dto)
		{
			_testAppointmentInfo = dto ?? throw new ArgumentException(nameof(dto));
		}

		/// <summary>
		/// Gets the Test ID associated with the current appointment.
		/// </summary>
		/// <returns>Test ID.</returns>
		public int TestID() => TestAppointmentDAL.GetTestID(_testAppointmentInfo.TestAppointmentID);

		/// <summary>
		/// Inserts the current test appointment into the database.
		/// </summary>
		/// <returns>True if insertion is successful; otherwise, false.</returns>
		public bool Insert()
		{
			int newID = TestAppointmentDAL.Insert(_testAppointmentInfo);
			if (newID > 0)
			{
				_testAppointmentInfo.TestAppointmentID = newID;
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Updates the current test appointment in the database.
		/// </summary>
		/// <returns>True if update is successful; otherwise, false.</returns>
		public bool Update()
		{
			return TestAppointmentDAL.Update(_testAppointmentInfo);
		}

		/// <summary>
		/// Finds a test appointment by its ID.
		/// </summary>
		/// <param name="testAppointmentID">The test appointment ID.</param>
		/// <returns>The test appointment DTO if found; otherwise, null.</returns>
		public static TestAppointmentDTO Find(int testAppointmentID)
		{
			var testDTO = TestAppointmentDAL.FindByID(testAppointmentID);

			if (testDTO != null)
			{
				testDTO.LocalDrivingLicenseApplicationInfo = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string m, testDTO.LDLApplicationID);
				testDTO.UserInfo = UserService.FindUserDetails(testDTO.CreatedUserID);
				testDTO.TestTypeInfo = TestTypeService.FindTestByID((int)testDTO.TestTypeID);
				testDTO.RetakeTestInfo = testDTO.LocalDrivingLicenseApplicationInfo.ApplicationInfo;
			}

			return testDTO;
		}

		/// <summary>
		/// Retrieves the last test appointment for a given test type and local driving license application.
		/// </summary>
		/// <param name="testTypeID">The test type.</param>
		/// <param name="localDrivingID">The local driving license application ID.</param>
		/// <returns>The last test appointment DTO.</returns>
		public static TestAppointmentDTO GetLastOne(TestTypeDTO.EnTestType testTypeID, int localDrivingID)
		{
			return TestAppointmentDAL.GetLastOne((int)testTypeID, localDrivingID);
		}

		/// <summary>
		/// Retrieves all test appointments for a given local driving license application.
		/// </summary>
		/// <param name="localDrivingLicenseID">The local driving license application ID.</param>
		/// <returns>List of test appointment DTOs.</returns>
		public static List<TestAppointmentDTO> GetAll(int localDrivingLicenseID)
		{
			return TestAppointmentDAL.GetAllAppointmentsForLDLApp(localDrivingLicenseID);
		}

		/// <summary>
		/// Retrieves test appointments for a specific test type and local driving license application as a DataTable.
		/// </summary>
		/// <param name="testTypeID">The test type.</param>
		/// <param name="localDrivingID">The local driving license application ID.</param>
		/// <returns>DataTable of test appointments.</returns>
		public static DataTable GetApplicationsTestAppointmentsPerTestType(TestTypeDTO.EnTestType testTypeID, int localDrivingID)
		{
			return TestAppointmentDAL.GetTestAppointmentPerTestType((int)testTypeID, localDrivingID);
		}

		/// <summary>
		/// Retrieves test appointments for a specific test type for the current appointment as a DataTable.
		/// </summary>
		/// <param name="testTypeID">The test type.</param>
		/// <returns>DataTable of test appointments.</returns>
		public DataTable GetApplicationsTestAppointmentsPerTestType(TestTypeDTO.EnTestType testTypeID)
		{
			return TestAppointmentDAL.GetTestAppointmentPerTestType((int)testTypeID, _testAppointmentInfo.LDLApplicationID);
		}
	}
}
