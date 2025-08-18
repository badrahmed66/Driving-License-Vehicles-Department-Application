using System;
using MyDVLD_DAL;
using MyDVLD_DTO;
using System.Collections.Generic;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Service class for managing License Classes operations.
	/// Provides methods to retrieve all license classes or find a specific license class by ID or title.
	/// </summary>
	public class LicenseClassService
	{
		/// <summary>
		/// Retrieves all license classes in the system.
		/// </summary>
		/// <returns>A list of <see cref="LicenseClassesDTO"/> representing all license classes.</returns>
		public static List<LicenseClassesDTO> RetrieveAllLicenseClasses()
		{
			return LicenseClassesDAL.Retrieve();
		}

		/// <summary>
		/// Finds a license class by either its ID or title.
		/// </summary>
		/// <param name="licenseID">The unique identifier of the license class. Optional if licenseTitle is provided.</param>
		/// <param name="licenseTitle">The title of the license class. Optional if licenseID is provided.</param>
		/// <returns>The <see cref="LicenseClassesDTO"/> if found; otherwise, null.</returns>
		public static LicenseClassesDTO FindByLicenseIDOrTitle(int? licenseID = null, string licenseTitle = null)
		{
			if ((licenseID == null && licenseTitle == null) || (licenseID != null && licenseTitle != null)) return null;

			return LicenseClassesDAL.Find(licenseID, licenseTitle);
		}
	}
}
