using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Data Transfer Object (DTO) representing an Application Type.
	/// Used to define and transfer information about different types of services
	/// (e.g., issuing, renewing, replacing, or retaking tests).
	/// </summary>
	public class ApplicationTypeDTO
    {
		/// <summary>
		/// Enumeration of predefined application types.
		/// Each value represents a specific type of driving license service.
		/// </summary>
		public enum EnType
        {
            newLocalDrivingLicenseService =1,
            renewDrivingLicenseService = 2,
            replacementForLostDrivingLicense = 3,
            replacementForDamagedDrivingLicense = 4,
            releaseDetainedDrivingLicsense = 5,
            newInternationalLicense = 6,
            retakeTest = 7
        }
        public int ID {  get; set; }
        public string Title {  get; set; }
        public decimal Fees {  get; set; }
    }
}
