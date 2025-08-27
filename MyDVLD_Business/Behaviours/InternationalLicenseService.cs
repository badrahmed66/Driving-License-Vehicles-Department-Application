using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DAL.Interfaces;
using MyDVLD_DAL.Utility;
using MyDVLD_DTO;
using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_Business.Behaviours
{
	/// <summary>
	/// Service class for managing International License operations.
	/// Provides methods to find, retrieve, insert, update, and get active international licenses.
	/// </summary>
	public class InternationalLicenseService : IInternationalLicenseService
	{
		private readonly IInternationalLicenseDAL _internationalDAL;
		private readonly IDriverService _driverService;

		/// <summary>
		/// Initializes a new instance of <see cref="InternationalLicenseService"/>.
		/// </summary>
		/// <param name="dal">The DAL implementation for international license.</param>
		/// <param name="driverService">The driver service for retrieving driver information.</param>
		public InternationalLicenseService(IInternationalLicenseDAL dal, IDriverService driverService)
		{
			_internationalDAL = dal;
			_driverService = driverService;
		}

		/// <summary>
		/// Finds an international license by DriverID.
		/// </summary>
		/// <param name="driverID">The unique identifier of the driver.</param>
		/// <returns>The <see cref="InternationalLicenseDTO"/> object if found; otherwise, null.</returns>
		public InternationalLicenseDTO FindByDriverID(int driverID)
		{
			var dto = _internationalDAL.FindByDriverID(driverID);

			if (dto != null)
			{
				dto.ApplicationInfo = ApplicationService.FindApplicationByID(dto.ApplicationID);

				dto.CreatedByUserInfo = UserService.FindUserDetails(dto.CreatedByUserID);

				dto.DriverInfo = _driverService.FindByDriverID(dto.DriverID);

				dto.RelatedLocalLicenseInfo = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, dto.RelatedToLocalLicenseID);
			}
			return dto;
		}

		/// <summary>
		/// Retrieves all international licenses.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all international licenses.</returns>
		public DataTable Retrieve()
		{
			return _internationalDAL.Retrieve();
		}

		/// <summary>
		/// Finds an international license by its unique InternationalLicenseID.
		/// </summary>
		/// <param name="id">The unique identifier of the international license.</param>
		/// <returns>The <see cref="InternationalLicenseDTO"/> object if found; otherwise, null.</returns>
		public InternationalLicenseDTO FindByInternationalID(int id)
		{
			var dto = _internationalDAL.FindByInternationalID(id);

			if (dto != null)
			{
				dto.ApplicationInfo = ApplicationService.FindApplicationByID(dto.ApplicationID);

				dto.CreatedByUserInfo = UserService.FindUserDetails(dto.CreatedByUserID);

				dto.DriverInfo = _driverService.FindByDriverID(dto.DriverID);

				dto.RelatedLocalLicenseInfo = LocalDrivingLicenseApplicationManager.FindLDLApplicationByLDLAppIDorApplicationID(out string message, dto.RelatedToLocalLicenseID);
			}
			return dto;
		}

		/// <summary>
		/// Gets the active international license ID for a specific driver.
		/// </summary>
		/// <param name="driverID">The unique identifier of the driver.</param>
		/// <returns>The active international license ID if found; otherwise, 0.</returns>
		public int GetActiveInternationalLicenseID(int driverID)
		{
			return _internationalDAL.GetActiveInternationalLicenseID(driverID);
		}

		/// <summary>
		/// Inserts a new international license record.
		/// </summary>
		/// <param name="internationalLicenseDTO">The international license DTO to insert.</param>
		/// <returns>True if the insert was successful; otherwise, false.</returns>
		public bool Insert(InternationalLicenseDTO internationalLicenseDTO)
		{
			int newID = _internationalDAL.Insert(internationalLicenseDTO);

			if (newID > 0)
			{
				internationalLicenseDTO.InternationalLicenseID = newID;
				LogFile.AddLogToFile(nameof(InternationalLicenseService), nameof(Insert), $"New International License with ID {newID} has Added", LogFile.ApplicationsInfo);
				return true;
			}
			return false;
		}

		/// <summary>
		/// Retrieves all international licenses for a specific driver.
		/// </summary>
		/// <param name="driverID">The unique identifier of the driver.</param>
		/// <returns>A <see cref="DataTable"/> containing all international licenses for the driver.</returns>
		public DataTable RetrieveAll(int driverID)
		{
			return _internationalDAL.RetrieveAll(driverID);
		}

		/// <summary>
		/// Updates an existing international license record.
		/// </summary>
		/// <param name="internationalLicenseDTO">The international license DTO to update.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		public bool Update(InternationalLicenseDTO internationalLicenseDTO)
		{
			LogFile.AddLogToFile(nameof(InternationalLicenseService), nameof(Insert), $"International License with ID {internationalLicenseDTO.InternationalLicenseID} has Updated", LogFile.ApplicationsInfo);
			return _internationalDAL.Update(internationalLicenseDTO);
		}
	}
}
