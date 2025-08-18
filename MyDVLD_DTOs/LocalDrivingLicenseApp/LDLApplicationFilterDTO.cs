using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs.LocalDrivingLicenseApp
{
	/// <summary>
	/// Represents filter criteria used to search or retrieve 
	/// Local Driving License Applications (LDLA).
	/// </summary>
	public class LDLApplicationFilterDTO
    {
        public int? LocalDrivingLicenseID {  get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public byte? Status {  get; set; }
    }
}
