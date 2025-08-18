using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_Business.Interfaces
{
	/// <summary>
	/// Defines the contract for managing detained licenses.
	/// Provides methods to retrieve, check, release, and save detained license information.
	/// </summary>
	public interface IDetainedLicenseService
	{
		/// <summary>
		/// Retrieves all detained licenses in the system.
		/// </summary>
		/// <returns>A DataTable containing all detained licenses.</returns>
		DataTable RetrieveAll();

		/// <summary>
		/// Finds a detained license by its unique detain ID.
		/// </summary>
		/// <param name="detainID">The ID of the detain record.</param>
		/// <returns>A <see cref="DetainedLicenseDTO"/> if found; otherwise, null.</returns>
		DetainedLicenseDTO FindByDetainID(int detainID);

		/// <summary>
		/// Finds a detained license by the associated license ID.
		/// </summary>
		/// <param name="licenseID">The ID of the license.</param>
		/// <returns>A <see cref="DetainedLicenseDTO"/> if found; otherwise, null.</returns>
		DetainedLicenseDTO FindByLicenseID(int licenseID);

		/// <summary>
		/// Inserts a new detained license record or updates an existing one.
		/// </summary>
		/// <param name="dto">The <see cref="DetainedLicenseDTO"/> object to save.</param>
		/// <returns>True if save operation succeeds; otherwise, false.</returns>
		bool Save(DetainedLicenseDTO dto);

		/// <summary>
		/// Checks if a specific license is currently detained.
		/// </summary>
		/// <param name="licenseID">The ID of the license to check.</param>
		/// <returns>True if the license is detained; otherwise, false.</returns>
		bool IsLicenseDetained(int licenseID);

		/// <summary>
		/// Releases a detained license, marking it as no longer detained.
		/// </summary>
		/// <param name="detainID">The ID of the detained record.</param>
		/// <param name="releaseByUserID">The ID of the user performing the release.</param>
		/// <param name="releaseAppID">The application ID associated with the release.</param>
		/// <returns>True if the release succeeds; otherwise, false.</returns>
		bool ReleaseDetainedLicense(int detainID, int releaseByUserID, int releaseAppID);
	}
}
