using MyDVLD_DTOs.TestAppointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs
{
	/// <summary>
	/// Represents a Test entity in the system. 
	/// Used to store details about a single test attempt 
	/// and to link it with its appointment, applicant, and creator user.
	/// </summary>
	public class TestDTO
	{
		// basic properties for the test table
		public int TestID {  get; set; }
		public int TestAppointmentID {  get; set; }
		public int CreatedByUserID {  get; set; }
		public bool IsPassed {  get; set; }
		public string Notes {  get; set; }

		//  composition
		public TestAppointmentDTO TestAppointmentInfo { get; set; }

		// Extra properties from join tables
		public int? ApplicantPersonID {  get; set; }

	}
}
