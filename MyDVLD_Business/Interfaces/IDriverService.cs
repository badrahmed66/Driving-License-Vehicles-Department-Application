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
	/// Defines the contract for driver-related operations.
	/// Handles retrieval, search, and saving of driver data.
	/// </summary>
	public interface IDriverService
	{
		/// <summary>
		/// Retrieves all drivers from the system.
		/// </summary>
		/// <returns>A DataTable containing all drivers.</returns>
		DataTable Retrieve();

		/// <summary>
		/// Finds a driver by their unique driver ID.
		/// </summary>
		/// <param name="driverID">The ID of the driver to find.</param>
		/// <returns>A <see cref="DriverDTO"/> object if found; otherwise, null.</returns>
		DriverDTO FindByDriverID(int driverID);
		/// <summary>
		/// Finds a driver associated with a specific person ID.
		/// </summary>
		/// <param name="personID">The person ID to search for.</param>
		/// <returns>A <see cref="DriverDTO"/> object if found; otherwise, null.</returns>
		DriverDTO FindByPersonID(int personID);

		/// <summary>
		/// Saves a driver to the system.
		/// If the driver does not exist, it will be inserted; otherwise, updated.
		/// </summary>
		/// <param name="driver">The <see cref="DriverDTO"/> object to save.</param>
		/// <returns>True if save operation succeeds; otherwise, false.</returns>
		bool Save(DriverDTO driver);
	}
}
