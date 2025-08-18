using System;
using MyDVLD_DTOs;
using System.Data;
using MyDVLD_DTO;

namespace MyDVLD_Business.Interfaces
{
    /// <summary>
    /// Defines the contract for managing driving licenses.
    /// Provides methods to retrieve, find, save, renew, replace, and check licenses.
    /// Also exposes composition services for detained licenses and drivers.
    /// </summary>
    public interface ILicenseService
    {
        /// <summary>
        /// Provides access to detained license operations.
        /// </summary>
        IDetainedLicenseService DetainedLicenseService { get; }

        /// <summary>
        /// Provides access to driver-related operations.
        /// </summary>
        IDriverService DriverService { get; }

        /// <summary>
        /// Adds a new license or updates an existing one.
        /// </summary>
        /// <param name="license">The <see cref="LicenseDTO"/> to save.</param>
        /// <returns>True if the operation succeeds; otherwise, false.</returns>
        bool Save(LicenseDTO license);

        /// <summary>
        /// Finds a license by its unique ID.
        /// </summary>
        /// <param name="licenseID">The ID of the license.</param>
        /// <returns>The <see cref="LicenseDTO"/> if found; otherwise, null.</returns>
        LicenseDTO FindByLicenseID(int licenseID);

        /// <summary>
        /// Finds a license by the associated driver ID.
        /// </summary>
        /// <param name="driverID">The ID of the driver.</param>
        /// <returns>The <see cref="LicenseDTO"/> if found; otherwise, null.</returns>
        LicenseDTO FindByDriverID(int driverID);

        /// <summary>
        /// Retrieves all licenses for a specific driver and license class.
        /// </summary>
        /// <param name="driverID">The driver's ID.</param>
        /// <param name="licenseClassID">The license class ID.</param>
        /// <returns>A <see cref="DataTable"/> of licenses.</returns>
        DataTable RetrieveDriverLicenses(int driverID, int licenseClassID);

        /// <summary>
        /// Retrieves all licenses in the system.
        /// </summary>
        /// <returns>A <see cref="DataTable"/> containing all licenses.</returns>
        DataTable RetrieveAll();

        /// <summary>
        /// Checks if a person has a license for a specific license class.
        /// </summary>
        /// <param name="personID">The person's ID.</param>
        /// <param name="licenseClassID">The license class ID.</param>
        /// <returns>True if the person has a license; otherwise, false.</returns>
        bool IsPersonHasLicense(int personID, int licenseClassID);

        /// <summary>
        /// Gets the active license ID for a specific person and license class.
        /// </summary>
        /// <param name="personID">The person's ID.</param>
        /// <param name="licenseClassID">The license class ID.</param>
        /// <returns>The active license ID if exists; otherwise, 0.</returns>
        int GetActiveLicenseForPerson(int personID, int licenseClassID);

        /// <summary>
        /// Checks if a license has expired based on its expiration date.
        /// </summary>
        /// <param name="expireDate">The expiration date of the license.</param>
        /// <returns>True if the license is expired; otherwise, false.</returns>
        bool IsLicenseExpired(DateTime expireDate);

        /// <summary>
        /// Deactivates a license.
        /// </summary>
        /// <param name="licenseID">The ID of the license to deactivate.</param>
        /// <returns>True if the operation succeeds; otherwise, false.</returns>
        bool DeActivateLicense(int licenseID);

        /// <summary>
        /// Retrieves the text representation of the license issue reason.
        /// </summary>
        /// <param name="licenseReason">The issue reason enum.</param>
        /// <returns>A string describing the issue reason.</returns>
        string GetIssueReasonText(LicenseDTO.EnIssueReason licenseReason);

        /// <summary>
        /// Renews an existing license.
        /// </summary>
        /// <param name="currentLicense">The current license to renew.</param>
        /// <param name="createdByUserID">The ID of the user performing the renewal.</param>
        /// <param name="notes">Optional notes about the renewal.</param>
        /// <returns>The renewed <see cref="LicenseDTO"/>.</returns>
        LicenseDTO RenewLicense(LicenseDTO currentLicense, int createdByUserID, string notes = "");

        /// <summary>
        /// Replaces an existing license with a new one.
        /// </summary>
        /// <param name="currentLicense">The current license to replace.</param>
        /// <param name="reason">The reason for replacement.</param>
        /// <param name="createdByUserID">The ID of the user performing the replacement.</param>
        /// <returns>The new <see cref="LicenseDTO"/>.</returns>
        LicenseDTO ReplaceLicense(LicenseDTO currentLicense, LicenseDTO.EnIssueReason reason, int createdByUserID);

        /// <summary>
        /// Retrieves all licenses associated with a specific driver.
        /// </summary>
        /// <param name="driverID">The driver's ID.</param>
        /// <returns>A <see cref="DataTable"/> containing the driver's licenses.</returns>
        DataTable GetDriverLicenses(int driverID);

        /// <summary>
        /// Checks if a specific license is detained.
        /// </summary>
        /// <param name="licenseID">The license ID to check.</param>
        /// <returns>True if the license is detained; otherwise, false.</returns>
        bool IsLicenseDetained(int licenseID);
    }
}
