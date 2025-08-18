using MyDVLD_DTO;
using MyDVLD_DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs.TestAppointment
{
	/// <summary>
	/// Represents a scheduled test appointment for a Local Driving License Application (LDLA).
	/// Includes both core appointment data and related entity details.
	/// </summary>
	public class TestAppointmentDTO
	{
		public int TestAppointmentID {  get; set; }
		public TestTypeDTO.EnTestType TestTypeID { get; set; }
		public int CreatedUserID {  get; set; }
		public int LDLApplicationID { get; set; }
		public DateTime TestAppointmentDate { get; set; }
		public bool IsLocked { get; set; }
		public decimal PaidFees {  get; set; }
		public int RetakeTestApplicationID { get; set; }

		// composition
		public TestTypeDTO TestTypeInfo { get; set; }
		public UserDTO UserInfo { get; set; }
		public LocalDrivingLicenseApplicationDTO LocalDrivingLicenseApplicationInfo {  get; set; }
		public ApplicationDTO RetakeTestInfo {  get; set; }


	}
}
