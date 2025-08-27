using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DAL.Interfaces;
using MyDVLD_DAL.Utility;
using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace MyDVLD_Business.Behaviours
{
	/// <summary>
	/// Service class to manage Detained Licenses.
	/// Handles retrieval, release, and saving logic.
	/// </summary>
	public class DetainedLicenseService : IDetainedLicenseService
	{
		private readonly IDetainedLicenseDAL _detainedLicenseDAL;

		public DetainedLicenseService(IDetainedLicenseDAL detainedLicenseDAL)
		{
			_detainedLicenseDAL = detainedLicenseDAL ?? throw new ArgumentNullException(nameof(detainedLicenseDAL));
		}

		/// <summary>
		/// Get a detained license by its DetainID.
		/// </summary>
		public DetainedLicenseDTO FindByDetainID(int detainID)
		{
			if (detainID <= 0) return null;

			var dto = _detainedLicenseDAL.GetDetainedLicenseByID(detainID);
			if (dto == null) return null;

			// Load compositions
			dto.DetainedByUserInfo = UserService.FindUserDetails(dto.DetainedByUserID);
			dto.ReleasedByUserInfo = UserService.FindUserDetails(dto.ReleasedByUserID);
			dto.ReleaseApplicationInfo = ApplicationService.FindApplicationByID(dto.ReleaseApplicationID);

			return dto;
		}

		/// <summary>
		/// Get a detained license by LicenseID.
		/// </summary>
		public DetainedLicenseDTO FindByLicenseID(int licenseID)
		{
			if (licenseID <= 0) return null;

			var dto = _detainedLicenseDAL.GetDetainedLicenseByLicenseID(licenseID);
			if (dto == null) return null;

			// Load compositions
			dto.DetainedByUserInfo = UserService.FindUserDetails(dto.DetainedByUserID);
			dto.ReleasedByUserInfo = UserService.FindUserDetails(dto.ReleasedByUserID);
			dto.ReleaseApplicationInfo = ApplicationService.FindApplicationByID(dto.ReleaseApplicationID);

			return dto;
		}

		/// <summary>
		/// Checks whether a license is currently detained.
		/// </summary>
		public bool IsLicenseDetained(int licenseID)
		{
			if (licenseID <= 0) return false;
			return _detainedLicenseDAL.IsLicenseDetained(licenseID);
		}

		/// <summary>
		/// Release a detained license.
		/// </summary>
		public bool ReleaseDetainedLicense(int detainID, int releaseByUserID, int releaseAppID)
		{
			
			return _detainedLicenseDAL.ReleaseDetainedLicense(detainID, releaseByUserID, releaseAppID);
		}

		/// <summary>
		/// Retrieve all detained licenses.
		/// </summary>
		public DataTable RetrieveAll()
		{
			return _detainedLicenseDAL.RetrieveAll();
		}

		/// <summary>
		/// Insert a new detained license (internal use only).
		/// </summary>
		private int Insert(DetainedLicenseDTO dto)
		{
			return _detainedLicenseDAL.Insert(dto);
		}

		/// <summary>
		/// Update a detained license (internal use only).
		/// </summary>
		private bool Update(DetainedLicenseDTO dto)
		{
			return _detainedLicenseDAL.Update(dto);
		}

		/// <summary>
		/// Save a detained license (insert or update depending on DetainID).
		/// </summary>
		public bool Save(DetainedLicenseDTO dto)
		{
			if (dto == null) throw new ArgumentNullException(nameof(dto));

			if (dto.DetainID <= 0) // Insert
			{
				int newID = Insert(dto);
				if (newID > 0)
				{
					dto.DetainID = newID;
					return true;
				}
				return false;
			}
			else // Update
			{
				return Update(dto);
			}
		}
	}
}
