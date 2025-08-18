using MyDVLD_Business.Interfaces;
using MyDVLD_DTOs;
using System;
using System.Data;
using MyDVLD_DAL.Interfaces;

namespace MyDVLD_Business.Behaviours
{
	/// <summary>
	/// Service class to manage Driver operations.
	/// Handles retrieval, saving (insert/update) logic.
	/// </summary>
	public class DriverService : IDriverService
	{
		private readonly IDriverDAL _driverDAL;

		public DriverService(IDriverDAL driverDAL)
		{
			_driverDAL = driverDAL ?? throw new ArgumentNullException(nameof(driverDAL));
		}

		/// <summary>
		/// Find a driver by DriverID
		/// </summary>
		public DriverDTO FindByDriverID(int driverID)
		{
			if (driverID <= 0) return null;
			return _driverDAL.FindByDriverID(driverID);
		}

		/// <summary>
		/// Find a driver by PersonID
		/// </summary>
		public DriverDTO FindByPersonID(int personID)
		{
			if (personID <= 0) return null;
			return _driverDAL.FindByPersonID(personID);
		}

		/// <summary>
		/// Retrieve all drivers in a DataTable
		/// </summary>
		public DataTable Retrieve()
		{
			return _driverDAL.RetrieveAll();
		}

		/// <summary>
		/// Insert a new driver (internal use only)
		/// </summary>
		private int Insert(DriverDTO driverDTO) => _driverDAL.Insert(driverDTO);

		/// <summary>
		/// Update an existing driver (internal use only)
		/// </summary>
		private bool Update(DriverDTO driverDTO) => _driverDAL.Update(driverDTO);

		/// <summary>
		/// Save a driver (insert if new, update if exists)
		/// </summary>
		public bool Save(DriverDTO driverDTO)
		{
			if (driverDTO == null) throw new ArgumentNullException(nameof(driverDTO));

			if (driverDTO.DriverID <= 0) // Insert
			{
				int newID = Insert(driverDTO);
				if (newID > 0)
				{
					driverDTO.DriverID = newID;
					return true;
				}
				return false;
			}
			else // Update
			{
				return Update(driverDTO);
			}
		}
	}
}
