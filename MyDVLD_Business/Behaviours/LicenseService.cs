using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_DAL.Interfaces;
using MyDVLD_DTO;
using MyDVLD_DTO.User;
using MyDVLD_DTOs;
using System;
using System.Data;
using static MyDVLD_DTOs.LicenseDTO;

namespace MyDVLD_Business.Behaviours
{
	/// <summary>
	/// Service class to manage License operations including retrieval, addition, renewal, replacement,
	/// and deactivation of licenses. Handles composition with drivers and detained licenses.
	/// </summary>
	public class LicenseService : ILicenseService
	{
		/// <summary>
		/// Base License DAL interface
		/// </summary>
		private readonly ILicenseDAL _licenseDAL;

		/// <summary>
		/// Composition: Driver service interface
		/// </summary>
		public IDriverService DriverService { get; }

		/// <summary>
		/// Composition: Detained License service interface
		/// </summary>
		public IDetainedLicenseService DetainedLicenseService { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LicenseService"/> class with required dependencies.
		/// </summary>
		/// <param name="licenseDAL">The License data access layer interface.</param>
		/// <param name="driverService">The Driver service interface.</param>
		/// <param name="detainedLicenseService">The Detained License service interface.</param>
		public LicenseService(ILicenseDAL licenseDAL, IDriverService driverService, IDetainedLicenseService detainedLicenseService)
		{
			_licenseDAL = licenseDAL;
			DriverService = driverService;
			DetainedLicenseService = detainedLicenseService;
		}

		/// <summary>
		/// Deactivates a license by its ID.
		/// </summary>
		/// <param name="licenseID">The ID of the license to deactivate.</param>
		/// <returns>True if successful; otherwise, false.</returns>
		public bool DeActivateLicense(int licenseID)
		{
			if (licenseID <= 0) return false;
			return _licenseDAL.DeActivateLicense(licenseID);
		}

		/// <summary>
		/// Finds a license by the driver's ID and populates its related compositions.
		/// </summary>
		/// <param name="driverID">The driver's ID.</param>
		/// <returns>A <see cref="LicenseDTO"/> if found; otherwise, null.</returns>
		public LicenseDTO FindByDriverID(int driverID)
		{
			if (driverID <= 0) return null;

			// find the base dto

			LicenseDTO licenseDTO = _licenseDAL.FindByDriverID(driverID);

			licenseDTO.GetIssueReasonText = IssueReasonText(licenseDTO.IssueReason);

			if (licenseDTO != null)
			{
				licenseDTO.ApplicationInfo = ApplicationService.FindApplicationByID(licenseDTO.ApplicationID);
				licenseDTO.CreatedByUserInfo = UserService.FindUserDetails(licenseDTO.CreatedByUserID);
				licenseDTO.DriverInfo = DriverService.FindByDriverID(licenseDTO.DriverID);
				licenseDTO.LicenseClassInfo = LicenseClassService.FindByLicenseIDOrTitle(licenseDTO.LicenseClassID);
				licenseDTO.DetainedLicenseInfo = DetainedLicenseService.FindByLicenseID(licenseDTO.LicenseID) ?? null;
			}

			return (licenseDTO.ApplicationInfo != null && licenseDTO.CreatedByUserInfo != null && licenseDTO.DriverInfo != null && licenseDTO.LicenseClassInfo != null) ? licenseDTO : null;
		}

		/// <summary>
		/// Finds a license by its License ID and populates its related compositions.
		/// </summary>
		/// <param name="licenseID">The license ID.</param>
		/// <returns>A <see cref="LicenseDTO"/> if found; otherwise, null.</returns>
		public LicenseDTO FindByLicenseID(int licenseID)
		{
			if (licenseID <= 0) return null;

			LicenseDTO licenseDTO = _licenseDAL.FindByLicenseID(licenseID);
			licenseDTO.GetIssueReasonText = IssueReasonText(licenseDTO.IssueReason);

			if (licenseDTO != null)
			{
				licenseDTO.ApplicationInfo = ApplicationService.FindApplicationByID(licenseDTO.ApplicationID);
				licenseDTO.CreatedByUserInfo = UserService.FindUserDetails(licenseDTO.CreatedByUserID);
				licenseDTO.DriverInfo = DriverService.FindByDriverID(licenseDTO.DriverID);
				licenseDTO.LicenseClassInfo = LicenseClassService.FindByLicenseIDOrTitle(licenseDTO.LicenseClassID);
				licenseDTO.DetainedLicenseInfo = DetainedLicenseService.FindByLicenseID(licenseDTO.LicenseID) ?? null;
			}

			return (licenseDTO.ApplicationInfo != null && licenseDTO.CreatedByUserInfo != null && licenseDTO.DriverInfo != null && licenseDTO.LicenseClassInfo != null) ? licenseDTO : null;
		}

		/// <summary>
		/// Gets the active license ID for a specific person and license class.
		/// </summary>
		/// <param name="personID">Person ID.</param>
		/// <param name="licenseClassID">License class ID.</param>
		/// <returns>The active license ID if exists; otherwise, 0.</returns>
		public int GetActiveLicenseForPerson(int personID, int licenseClassID)
		{
			if (personID <= 0 || licenseClassID <= 0) return 0;
			return _licenseDAL.GetActiveLicenseIDToDriver(personID, licenseClassID);
		}

		/// <summary>
		/// Checks whether a license is expired.
		/// </summary>
		/// <param name="expireDate">The expiration date of the license.</param>
		/// <returns>True if expired; otherwise, false.</returns>
		public bool IsLicenseExpired(DateTime expireDate)
		{
			return (expireDate < DateTime.Now);
		}

		/// <summary>
		/// Checks if a person has an active license for a given class.
		/// </summary>
		/// <param name="personID">Person ID.</param>
		/// <param name="licenseClassID">License class ID.</param>
		/// <returns>True if person has a license; otherwise, false.</returns>
		public bool IsPersonHasLicense(int personID, int licenseClassID)
		{
			return (_licenseDAL.GetActiveLicenseIDToDriver(personID, licenseClassID) > 0);
		}

		/// <summary>
		/// Retrieves all licenses from the system.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all licenses.</returns>
		public DataTable RetrieveAll()
		{
			return _licenseDAL.RetrieveAll();
		}

		/// <summary>
		/// Retrieves licenses for a specific driver and license class.
		/// </summary>
		/// <param name="driverID">Driver ID.</param>
		/// <param name="licenseClassID">License class ID.</param>
		/// <returns>A <see cref="DataTable"/> of the driver's licenses.</returns>
		public DataTable RetrieveDriverLicenses(int driverID, int licenseClassID)
		{
			return _licenseDAL.RetrieveForDriver(driverID, licenseClassID);
		}

		/// <summary>
		/// Saves a license. Adds a new license if ID is 0; otherwise updates the existing license.
		/// </summary>
		/// <param name="license">The license DTO.</param>
		/// <returns>True if saved successfully; otherwise, false.</returns>
		public bool Save(LicenseDTO license)
		{
			if (license == null) return false;

			if (license.LicenseID == 0)
			{
				int newID = _licenseDAL.Insert(license);
				if (newID > 0)
				{
					license.LicenseID = newID;
					return true;
				}
				return false;
			}
			else
				return _licenseDAL.Update(license);
		}

		/// <summary>
		/// Returns the text description of a license issue reason.
		/// </summary>
		/// <param name="issueReason">The license issue reason.</param>
		/// <returns>Text description.</returns>
		public string GetIssueReasonText(LicenseDTO.EnIssueReason issueReason)
		{
			switch (issueReason)
			{
				case LicenseDTO.EnIssueReason.FirstTime:
					return "For First Time";

				case LicenseDTO.EnIssueReason.Renew:
					return "For Renew";

				case LicenseDTO.EnIssueReason.Damaged:
					return "Replace For Damaged";

				case LicenseDTO.EnIssueReason.Lost:
					return "Replace For Lost";
			}
			return "";
		}

		/// <summary>
		/// Renews an existing license by creating a new license with updated expiration and deactivating the current license.
		/// </summary>
		/// <param name="currentLicense">The current license DTO.</param>
		/// <param name="createdByUserID">ID of the user performing the renewal.</param>
		/// <param name="notes">Optional notes.</param>
		/// <returns>The new renewed <see cref="LicenseDTO"/> if successful; otherwise, null.</returns>
		public LicenseDTO RenewLicense(LicenseDTO currentLicense, int createdByUserID, string notes = "")
		{
			//create an application and set the type is Renew 
				ApplicationDTO application = new ApplicationDTO(); 
			application.PersonID = currentLicense.DriverInfo.PersonID; application.CreatedByUserID = createdByUserID;
			application.ApplicationTypeID = (int)ApplicationTypeDTO.EnType.renewDrivingLicenseService; application.ApplicationPaidFees = ApplicationTypeService.FindApplicationTypeByID((int)ApplicationTypeDTO.EnType.renewDrivingLicenseService).Fees; application.ApplicationStatus = ApplicationDTO.Status.Complete; application.ApplicationDate = DateTime.Now; application.ApplicationLastStatusUpdateDate = DateTime.Now; ApplicationService appService = new ApplicationService(application); 
			if(!appService.AddApplication(out string message)) return null;

				// now we insert a new application with renew type in the system
				LicenseDTO newLicense = new LicenseDTO();
			newLicense.DriverID = currentLicense.DriverID; 
			newLicense.CreatedByUserID = createdByUserID;
			newLicense.LicenseClassID = currentLicense.LicenseClassID; newLicense.ApplicationID = application.ApplicationID;
			newLicense.IssueDate = DateTime.Now; newLicense.IssueReason = LicenseDTO.EnIssueReason.Renew;
			newLicense.IsActive = true; int validtyLength = currentLicense.LicenseClassInfo.LicenseDefaultValidateLength; newLicense.ExpirationDate = DateTime.Now.AddYears(validtyLength); newLicense.Notes = notes;
			if (!Save(newLicense)) return null; 

				// now you should DeActivate the current license
				if (!DeActivateLicense(currentLicense.LicenseID)) return null;
			return newLicense;
		
			}

		/// <summary>
		/// Replaces an existing license due to loss or damage by creating a new license and deactivating the old one.
		/// </summary>
		/// <param name="currentLicense">The current license DTO.</param>
		/// <param name="reason">The reason for replacement.</param>
		/// <param name="createdByUserID">ID of the user performing the replacement.</param>
		/// <returns>The new <see cref="LicenseDTO"/> if successful; otherwise, null.</returns>
		public LicenseDTO ReplaceLicense(LicenseDTO currentLicense, LicenseDTO.EnIssueReason reason, int createdByUserID)
		{

			ApplicationDTO application = new ApplicationDTO(); 
			application.PersonID = currentLicense.DriverInfo.PersonID; application.CreatedByUserID = createdByUserID;
			application.ApplicationTypeID = reason == LicenseDTO.EnIssueReason.Damaged ? (int)ApplicationTypeDTO.EnType.replacementForDamagedDrivingLicense : (int)ApplicationTypeDTO.EnType.replacementForLostDrivingLicense; 

			application.ApplicationPaidFees = ApplicationTypeService.FindApplicationTypeByID(application.ApplicationTypeID).Fees;
			application.ApplicationDate = DateTime.Now; application.ApplicationLastStatusUpdateDate = DateTime.Now; application.ApplicationStatus = ApplicationDTO.Status.Complete; 

		ApplicationService appService = new ApplicationService(application);
			if (!appService.AddApplication(out string message)) return null;

			// now we added a new application weather for lost or damaged reason
			LicenseDTO newLicense = new LicenseDTO(); newLicense.DriverID = currentLicense.DriverInfo.DriverID; newLicense.ApplicationID = application.ApplicationID; newLicense.Notes = currentLicense.Notes; newLicense.IssueDate = DateTime.Now;
			newLicense.IssueReason = reason;
			newLicense.LicenseClassID = currentLicense.LicenseClassID; newLicense.CreatedByUserID = createdByUserID;
			int defaulevalidateLength = LicenseClassService.FindByLicenseIDOrTitle(newLicense.LicenseClassID).LicenseDefaultValidateLength; 

		newLicense.ExpirationDate = DateTime.Now.AddYears(defaulevalidateLength); newLicense.IssueDate = DateTime.Now;
			newLicense.IsActive = true; newLicense.PaidFees = 0;
			// due to that's no paid fees for a replacement licnese
			if (! Save(newLicense)) return null; if(!DeActivateLicense(currentLicense.LicenseID)) return null;
			return newLicense; 
		}


		/// <summary>
		/// Retrieves all licenses associated with a specific driver.
		/// </summary>
		/// <param name="driverID">Driver ID.</param>
		/// <returns>A <see cref="DataTable"/> of licenses.</returns>
		public DataTable GetDriverLicenses(int driverID)
		{
			return _licenseDAL.GetLicensesByDriverID(driverID);
		}

		/// <summary>
		/// Checks if a license is currently detained.
		/// </summary>
		/// <param name="licenseID">License ID.</param>
		/// <returns>True if detained; otherwise, false.</returns>
		public bool IsLicenseDetained(int licenseID)
		{
			return DetainedLicenseService.IsLicenseDetained(licenseID);
		}

		private string IssueReasonText(LicenseDTO.EnIssueReason IssueReason) 
		{
			switch (IssueReason) 
			{
				case EnIssueReason.FirstTime:
					return "First Time";
				case EnIssueReason.Renew:
					return "Renew";
				case EnIssueReason.Damaged:
					return
						"Replace For Damaged"; 
				case EnIssueReason.Lost: 
					return "Replace For Lost"
						;
			}
			return "";
		}
	}
}
