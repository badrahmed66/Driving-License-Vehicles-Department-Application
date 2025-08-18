using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
    public static class LicenseClassesProcedures
    {
		/// <summary>
		/// Retrieves license class records optionally filtered by ID or title.
		/// </summary>
		/// <param name="licenseID">Optional: LicenseID to filter</param>
		/// <param name="licenseTitle">Optional: LicenseTitle to filter (partial match)</param>
		/// <returns>License class records matching the filter</returns>
    public const string Find = "LicenseClasses_Find";

		/// <summary>
		/// Retrieves all license classes.
		/// </summary>
		/// <returns>All records from the LicenseClasses table</returns>
		public const string Retrieve = "LicenseClasses_Retrieve";

    }
}
