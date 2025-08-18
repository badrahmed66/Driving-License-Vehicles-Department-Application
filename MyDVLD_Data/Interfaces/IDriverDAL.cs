using MyDVLD_DTOs;
using System;
using System.Data;

namespace MyDVLD_DAL.Interfaces
{
	/// <summary>
	/// Interface for data access operations related to drivers.
	/// Defines methods for retrieving, inserting, and updating driver records.
	/// </summary>
	public interface IDriverDAL
	{
		/// <summary>
		/// Finds a specific driver by their driver ID.
		/// </summary>
		/// <param name="driverID">The unique ID of the driver.</param>
		/// <returns>A <see cref="DriverDTO"/> object if found; otherwise, null.</returns>
		DriverDTO FindByDriverID(int driverID);

		/// <summary>
		/// Finds a specific driver by the associated person ID.
		/// </summary>
		/// <param name="personID">The unique ID of the person.</param>
		/// <returns>A <see cref="DriverDTO"/> object if found; otherwise, null.</returns>
		DriverDTO FindByPersonID(int personID);

		/// <summary>
		/// Retrieves all drivers from the database.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all driver records.</returns>
		DataTable RetrieveAll();

		/// <summary>
		/// Inserts a new driver record into the database.
		/// </summary>
		/// <param name="driver">The <see cref="DriverDTO"/> object containing driver data.</param>
		/// <returns>The ID of the newly inserted driver if successful; otherwise, -1.</returns>
		int Insert(DriverDTO driver);

		/// <summary>
		/// Updates an existing driver record.
		/// </summary>
		/// <param name="driver">The <see cref="DriverDTO"/> object containing updated driver data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		bool Update(DriverDTO driver);
	}
}
