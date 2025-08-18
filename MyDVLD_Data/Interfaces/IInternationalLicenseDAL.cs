using System;
using System.Collections.Generic;
using System.Data;
using MyDVLD_DTOs;

namespace MyDVLD_DAL.Interfaces
{
	/// <summary>
	/// Interface for data access operations related to International Licenses.
	/// Provides methods to retrieve, insert, update, and check active international licenses.
	/// </summary>
	public interface IInternationalLicenseDAL
	{
		/// <summary>
		/// Retrieves all international licenses from the database.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all international licenses.</returns>
		DataTable Retrieve();

		/// <summary>
		/// Retrieves all international licenses for a specific driver.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <returns>A <see cref="DataTable"/> containing all licenses of the driver.</returns>
		DataTable RetrieveAll(int driverID);

		/// <summary>
		/// Finds the international license associated with a specific driver ID.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <returns>An <see cref="InternationalLicenseDTO"/> if found; otherwise, null.</returns>
		InternationalLicenseDTO FindByDriverID(int driverID);

		/// <summary>
		/// Finds an international license by its unique ID.
		/// </summary>
		/// <param name="id">The unique ID of the international license.</param>
		/// <returns>An <see cref="InternationalLicenseDTO"/> if found; otherwise, null.</returns>
		InternationalLicenseDTO FindByInternationalID(int id);

		/// <summary>
		/// Inserts a new international license record into the database.
		/// </summary>
		/// <param name="dto">The <see cref="InternationalLicenseDTO"/> object containing license data.</param>
		/// <returns>The ID of the newly inserted license if successful; otherwise, -1.</returns>
		int Insert(InternationalLicenseDTO dto);

		/// <summary>
		/// Updates an existing international license record.
		/// </summary>
		/// <param name="dto">The <see cref="InternationalLicenseDTO"/> object containing updated license data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		bool Update(InternationalLicenseDTO dto);

		/// <summary>
		/// Gets the active international license ID for a specific driver.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <returns>The active license ID if found; otherwise, -1.</returns>
		int GetActiveInternationalLicenseID(int driverID);
	}
}
