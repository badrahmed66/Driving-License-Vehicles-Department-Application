using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace MyDVLD_DAL.Interfaces
{
	/// <summary>
	/// Interface for data access operations related to Licenses.
	/// Provides methods to retrieve, insert, update, deactivate, and query licenses.
	/// </summary>
	public interface ILicenseDAL
	{
		/// <summary>
		/// Finds a specific license by its unique ID.
		/// </summary>
		/// <param name="ID">The unique ID of the license.</param>
		/// <returns>A <see cref="LicenseDTO"/> object if found; otherwise, null.</returns>
		LicenseDTO FindByLicenseID(int ID);

		/// <summary>
		/// Retrieves all licenses from the database.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all licenses.</returns>
		DataTable RetrieveAll();

		/// <summary>
		/// Retrieves all licenses for a specific driver and license class.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <param name="licenseClassID">The license class ID to filter by.</param>
		/// <returns>A <see cref="DataTable"/> containing the licenses of the driver filtered by class.</returns>
		DataTable RetrieveForDriver(int driverID, int licenseClassID);

		/// <summary>
		/// Finds a license associated with a specific driver.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <returns>A <see cref="LicenseDTO"/> if found; otherwise, null.</returns>
		LicenseDTO FindByDriverID(int driverID);

		/// <summary>
		/// Inserts a new license record into the database.
		/// </summary>
		/// <param name="license">The <see cref="LicenseDTO"/> object containing license data.</param>
		/// <returns>The ID of the newly inserted license if successful; otherwise, -1.</returns>
		int Insert(LicenseDTO license);

		/// <summary>
		/// Updates an existing license record.
		/// </summary>
		/// <param name="license">The <see cref="LicenseDTO"/> object containing updated license data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		bool Update(LicenseDTO license);

		/// <summary>
		/// Gets the active license ID for a specific driver based on person ID and license class ID.
		/// </summary>
		/// <param name="personID">The person ID of the driver.</param>
		/// <param name="licenseClassID">The license class ID.</param>
		/// <returns>The active license ID if found; otherwise, -1.</returns>
		int GetActiveLicenseIDToDriver(int personID, int licenseClassID);

		/// <summary>
		/// Deactivates a license, changing its status from active to inactive.
		/// </summary>
		/// <param name="licenseID">The unique ID of the license to deactivate.</param>
		/// <returns>True if the deactivation was successful; otherwise, false.</returns>
		bool DeActivateLicense(int licenseID);

		/// <summary>
		/// Retrieves all licenses associated with a specific driver.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <returns>A <see cref="DataTable"/> containing the licenses of the driver.</returns>
		DataTable GetLicensesByDriverID(int driverID);
	}
}
