using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Represents a Local Driving License Application (LDLA) data transfer object.
	/// This DTO links the base application record with the specific license class
	/// requested by the applicant.
	/// </summary>
	public class LocalDrivingLicenseApplicationDTO
    {
        public int LocalDrivingLicenseAppID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        // compositions
        public ApplicationDTO ApplicationInfo { get; set; }
        public LicenseClassesDTO LicenseClassesInfo { get; set; }

	}
}
