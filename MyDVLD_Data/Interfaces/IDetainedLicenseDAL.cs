using MyDVLD_DTOs;
using System;
using System.Data;

namespace MyDVLD_DAL.Interfaces
{
	/// <summary>
	/// Interface for data access operations related to detained licenses.
	/// Defines the contract for retrieving, inserting, updating, checking, and releasing detained licenses.
	/// </summary>
	public interface IDetainedLicenseDAL
	{
		/// <summary>
		/// Retrieves detained license information by detained license ID.
		/// </summary>
		/// <param name="detainID">The ID of the detained license record.</param>
		/// <returns>A <see cref="DetainedLicenseDTO"/> object if found; otherwise, null.</returns>
		DetainedLicenseDTO GetDetainedLicenseByID(int detainID);

		/// <summary>
		/// Retrieves detained license information by the original license ID.
		/// </summary>
		/// <param name="licenseID">The ID of the original license.</param>
		/// <returns>A <see cref="DetainedLicenseDTO"/> object if the license is detained; otherwise, null.</returns>
		DetainedLicenseDTO GetDetainedLicenseByLicenseID(int licenseID);

		/// <summary>
		/// Retrieves all detained license records from the database.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all detained licenses.</returns>
		DataTable RetrieveAll();

		/// <summary>
		/// Inserts a new detained license record into the database.
		/// </summary>
		/// <param name="detainedLicense">The <see cref="DetainedLicenseDTO"/> object containing the detained license data.</param>
		/// <returns>The ID of the newly inserted detained license if successful; otherwise, -1.</returns>
		int Insert(DetainedLicenseDTO detainedLicense);

		/// <summary>
		/// Updates an existing detained license record.
		/// </summary>
		/// <param name="detainedLicense">The <see cref="DetainedLicenseDTO"/> object containing updated data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		bool Update(DetainedLicenseDTO detainedLicense);

		/// <summary>
		/// Checks if a license is currently detained.
		/// </summary>
		/// <param name="licenseID">The ID of the license to check.</param>
		/// <returns>True if the license is detained; otherwise, false.</returns>
		bool IsLicenseDetained(int licenseID);

		/// <summary>
		/// Releases a detained license, marking it as no longer detained.
		/// </summary>
		/// <param name="detainID">The detained license record ID.</param>
		/// <param name="releaseByUserID">The user ID who releases the license.</param>
		/// <param name="releaseApplicationID">The related application ID for the release operation.</param>
		/// <returns>True if the release was successful; otherwise, false.</returns>
		bool ReleaseDetainedLicense(int detainID, int releaseByUserID, int releaseApplicationID);
	}
}
