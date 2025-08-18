using MyDVLD_DTO;
using MyDVLD_DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs
{
	public class LicenseDTO
	{
		/// <summary>
		/// Data Transfer Object (DTO) that represents a license record in the system.
		/// It includes basic license details such as issue/expiration dates, fees, and notes,
		/// along with related entities like driver info, application, license class, and detention details.
		/// 
		/// This DTO is mainly used for transporting license data across different layers of the application.
		/// </summary>
		public enum EnIssueReason { FirstTime = 1, Renew = 2,  Damaged =  3 ,Lost = 4}
		public int LicenseID {  get; set; }
		public int DriverID {  get; set; }
		public int CreatedByUserID {  get; set; }
		public int LicenseClassID {  get; set; }
		public int ApplicationID {  get; set; }

		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string Notes { get; set; }
		public Decimal PaidFees { get; set; }
		public bool IsActive { get; set; }
		public EnIssueReason IssueReason { get; set; }
		
		public string GetIssueReasonText { set; get; }
		// compositions
		public DriverDTO DriverInfo {  get; set; }
		public UserDTO CreatedByUserInfo {  get; set; }
		public ApplicationDTO ApplicationInfo { get; set; }
		public LicenseClassesDTO LicenseClassInfo {  get; set; }
		public DetainedLicenseDTO DetainedLicenseInfo {  get; set; }

	}
}
