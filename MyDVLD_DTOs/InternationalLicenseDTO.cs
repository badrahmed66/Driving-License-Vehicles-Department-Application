using MyDVLD_DTO;
using MyDVLD_DTO.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs
{
	/// <summary>
	/// Data Transfer Object (DTO) representing an International Driving License record.
	///
	/// Includes:
	/// - Core info:
	///     • InternationalLicenseID: unique identifier of the international license.
	///     • IssueDate: the date the license was issued.
	///     • ExpirationDate: the date the license expires.
	///     • IsActive: whether the license is still valid/active.
	///
	/// - Foreign keys (links to related entities):
	///     • DriverID: the driver who owns this license.
	///     • ApplicationID: the application that created this license.
	///     • RelatedToLocalLicenseID: the local driving license this international one is linked to.
	///     • CreatedByUserID: the user who created/issued the record.
	///
	/// - Composed DTOs for richer context:
	///     • DriverInfo: details about the driver (DriverDTO).
	///     • ApplicationInfo: details about the linked application (ApplicationDTO).
	///     • RelatedLocalLicenseInfo: details about the linked local driving license (LocalDrivingLicenseApplicationDTO).
	///     • CreatedByUserInfo: details about the user who created the license record (UserDTO).
	///
	/// Purpose: This DTO centralizes all information needed to represent 
	/// an international license, while still keeping links to other entities 
	/// for full contextual data transfer between layers.
	/// </summary>
	public class InternationalLicenseDTO
	{
		public int InternationalLicenseID {  get; set; }
		public DateTime IssueDate {  get; set; }
		public bool IsActive {  get; set; }
		public DateTime ExpirationDate {  get; set; }

		// foreign keys
		public int DriverID {  get; set; }
		public int ApplicationID {  get; set; }
		public int RelatedToLocalLicenseID {  get; set; }
		public int CreatedByUserID {  get; set; }

		// compositions DTOs
		public DriverDTO DriverInfo {  get; set; }
		public ApplicationDTO ApplicationInfo {  get; set; }
		public LocalDrivingLicenseApplicationDTO RelatedLocalLicenseInfo {  get; set; }
		public UserDTO CreatedByUserInfo {  get; set; }
	}
}
