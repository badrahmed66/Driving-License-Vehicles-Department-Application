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
	/// Defines the contract for managing international driving licenses.
	/// Provides methods to retrieve, find, insert, and update international license information.
	/// </summary>
	public interface IInternationalLicenseService
	{
		/// <summary>
		/// Retrieves all international licenses in the system.
		/// </summary>
		/// <returns>A DataTable containing all international licenses.</returns>
		DataTable Retrieve();

		/// <summary>
		/// Retrieves all international licenses associated with a specific driver.
		/// </summary>
		/// <param name="driverID">The ID of the driver.</param>
		/// <returns>A DataTable containing the driver's international licenses.</returns>
		DataTable RetrieveAll(int driverID);

		/// <summary>
		/// Finds the international license for a specific driver.
		/// </summary>
		/// <param name="driverID">The ID of the driver.</param>
		/// <returns>An <see cref="InternationalLicenseDTO"/> if found; otherwise, null.</returns>
		InternationalLicenseDTO FindByDriverID(int driverID);

		/// <summary>
		/// Finds an international license by its unique ID.
		/// </summary>
		/// <param name="id">The ID of the international license.</param>
		/// <returns>An <see cref="InternationalLicenseDTO"/> if found; otherwise, null.</returns>
		InternationalLicenseDTO FindByInternationalID(int id);

		/// <summary>
		/// Gets the active international license ID for a specific driver.
		/// </summary>
		/// <param name="driverID">The ID of the driver.</param>
		/// <returns>The ID of the active international license if exists; otherwise, 0.</returns>
		int GetActiveInternationalLicenseID(int driverID);

		/// <summary>
		/// Inserts a new international license record.
		/// </summary>
		/// <param name="internationalLicenseDTO">The <see cref="InternationalLicenseDTO"/> to insert.</param>
		/// <returns>True if the insertion succeeds; otherwise, false.</returns>
		bool Insert(InternationalLicenseDTO internationalLicenseDTO);

		/// <summary>
		/// Updates an existing international license record.
		/// </summary>
		/// <param name="internationalLicenseDTO">The <see cref="InternationalLicenseDTO"/> to update.</param>
		/// <returns>True if the update succeeds; otherwise, false.</returns>
		bool Update(InternationalLicenseDTO internationalLicenseDTO);
	}
}
