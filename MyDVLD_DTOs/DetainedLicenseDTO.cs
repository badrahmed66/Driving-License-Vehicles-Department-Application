using MyDVLD_DTO;
using MyDVLD_DTO.User;
using System;


namespace MyDVLD_DTOs
{
	/// <summary>
	/// Data Transfer Object (DTO) representing information about a detained driving license.
	/// 
	/// Includes details about:
	/// - The detain process itself (DetainID, LicenseID, DetainedDate, Fees, DetainedByUserID).
	/// - The release process if applicable (IsReleased, ReleasedDate, ReleasedByUserID, ReleaseApplicationID).
	/// - Composed objects for richer context:
	///     • DetainedByUserInfo: the user who detained the license.
	///     • ReleasedByUserInfo: the user who released the license.
	///     • ReleaseApplicationInfo: the application details used for the release.
	/// 
	/// This DTO is used to transfer detained license data between layers.
	/// </summary>
	public class DetainedLicenseDTO
	{
		public int DetainID {  get; set; }
		public int LicenseID {  get; set; }
		public DateTime DetainedDate { get; set; }
		public decimal Fees {  get; set; }
		public int DetainedByUserID {  get; set; }
		public bool IsReleased {  get; set; }
		public DateTime? ReleasedDate { get; set; }
		public int ReleasedByUserID { get; set; }
		public int ReleaseApplicationID {  get; set; }

		// composition
		public UserDTO DetainedByUserInfo {  get; set; }
		public UserDTO ReleasedByUserInfo { get; set; }
		public ApplicationDTO ReleaseApplicationInfo {  get; set; }

	}
}
