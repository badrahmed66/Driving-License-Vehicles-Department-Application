using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Data Transfer Object (DTO) representing a License Class definition.
	///
	/// Includes:
	/// - Core identifiers and info:
	///     • LicenseID: unique identifier of the license class.
	///     • LicenseTitle: human-readable title of the license class (e.g., "Private", "Motorcycle").
	///     • LicenseDescription: textual description of what this license class allows.
	///
	/// - Financial and age constraints:
	///     • LicenseFees: the cost/fees required to apply for this license class.
	///     • LicenseAllowMinAge: the minimum age required to apply for this class.
	///     • LicenseDefaultValidateLength: default validity period (in years) for the license.
	///
	/// Purpose: This DTO centralizes information about available driving license classes,
	/// including requirements, fees, and descriptions, to be used across layers
	/// (DAL, BLL, UI) when displaying or processing license class data.
	/// </summary>
	public class LicenseClassesDTO
    {
        public int LicenseID { get; set; }
        public string LicenseTitle { get; set; }
        public decimal LicenseFees { get; set; }
        public string LicenseDescription { get; set; }
        public byte LicenseAllowMinAge { get; set; }
        public byte LicenseDefaultValidateLength { get; set; }
    }
}
