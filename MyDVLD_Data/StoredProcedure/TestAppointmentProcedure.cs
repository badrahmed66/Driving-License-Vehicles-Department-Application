using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
	public static class TestAppointmentProcedure
	{
		/// <summary>
		/// Retrieves a TestAppointment by its ID.
		/// </summary>
		/// <param name="testAppointmentID">Test Appointment ID</param>
		/// <returns>TestAppointment record</returns>

		public const string FindByID = "TestAppointment_FindByID";

		/// <summary>
		/// Retrieves the most recent TestAppointment for a specific test type and Local Driving License application.
		/// </summary>
		/// <param name="testTypeID">Test Type ID</param>
		/// <param name="LDLApplicationID">Local Driving License Application ID</param>
		/// <returns>The latest TestAppointment record</returns>
		public const string GetLastOne = "TestAppointment_GetLastOne";

		/// <summary>
		/// Retrieves all TestAppointments for a given Local Driving License application.
		/// </summary>
		/// <param name="localDrivingLicenseID">Local Driving License Application ID</param>
		/// <returns>All TestAppointments as a table</returns>
		public const string GetAll = "TestAppointment_GetAll";

		/// <summary>
		/// Inserts a new TestAppointment record.
		/// </summary>
		/// <param name="testTypeID">Test type ID</param>
		/// <param name="testAppointmentDate">Appointment date</param>
		/// <param name="createdByUserID">User ID who created the appointment</param>
		/// <param name="isLocked">Indicates if the appointment is locked</param>
		/// <param name="ldlApplicationID">Local Driving License Application ID</param>
		/// <param name="paidFees">Paid fees amount</param>
		/// <param name="retakeTestApplicationID">Optional Retake Test Application ID</param>
		/// <returns>Newly created TestAppointment ID</returns>
		public const string Insert = "TestAppointment_Insert";

		/// <summary>
		/// Updates a test appointment record.
		/// </summary>
		/// <param name="TestTypeAppointmentID">ID of the test appointment to update</param>
		/// <param name="TestTypeID">ID of the test type</param>
		/// <param name="TestAppointmentDate">Date and time of the appointment</param>
		/// <param name="CreatedByUserID">User ID who created or updated the appointment</param>
		/// <param name="IsLocked">Indicates if the appointment is locked</param>
		/// <param name="LDLApplicationID">ID of the local driving license application</param>
		/// <param name="PaidFees">Paid fees for the appointment</param>
		/// <param name="RetakeTestApplicationID">Optional ID of a retake test application</param>
		/// <returns>Nothing</returns>
		public const string Update = "TestAppointment_Update";

		/// <summary>
		/// Retrieves all test appointments with detailed information including person, test type, and license.
		/// </summary>
		/// <returns>DataTable with TestAppointmentID, LDLApplicationID, FullName, TestAppointmentDate, PaidFees, IsLocked, TestTypeTitle, LicenseTitle</returns>
		public const string GetAllForView = "TestAppointment_Retrieve";

		/// <summary>
		/// Retrieves all TestAppointments for a specific TestType and Local Driving License application.
		/// </summary>
		/// <param name="testTypeID">Test Type ID</param>
		/// <param name="localDrivingID">Local Driving License Application ID</param>
		/// <returns>List of TestAppointments</returns>
		public const string FindPerTestType = "TestAppointment_FindPerTestTyp";

		/// <summary>
		/// Gets the Test ID associated with a specific TestAppointment.
		/// </summary>
		/// <param name="testAppointmentID">TestAppointment ID</param>
		/// <returns>Test ID</returns>
		public const string GetTestID = "TestAppointment_GetTestID";
	}
}
