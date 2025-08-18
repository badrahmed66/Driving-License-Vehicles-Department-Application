using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs.TestAppointment
{
	/// <summary>
	/// Represents a view projection of a test appointment, 
	/// used mainly for displaying appointment details in the UI (e.g., grids, reports).
	/// </summary>
	public class TestAppointmentViewDTO
	{
		public int TestAppointmentID { get; set; }
		public int LDLApplicationID{ get; set; }
		public string FullName {  get; set; }
		public DateTime TestAppointmentDate {  get; set; }
		public Decimal PaidFees {  get; set; }
		public bool IsLocked {  get; set; }
		public string TestTypeTitle {  get; set; }
		public string LicenseTitle {  get; set; }

	}
}
