using MyDVLD_DTO;
using MyDVLD_DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs
{
	/// <summary>
	/// Data Transfer Object (DTO) representing a driver record in the system.
	///
	/// Includes:
	/// - Core identifiers: DriverID, PersonID (link to the person), CreatedByUserID (who created the driver record).
	/// - Metadata: CreatedDate (when the driver record was created).
	/// - Composed objects for richer context:
	///     • PersonInfo: personal details of the driver (from PersonDTO).
	///     • UserInfo: details of the user who created the driver record (from UserDTO).
	///
	/// This DTO is used to transfer driver-related data between layers.
	/// </summary>
	public class DriverDTO
	{
		public int DriverID { get; set; }
		public int PersonID {  get; set; }
		public int CreatedByUserID { get; set; }
		public DateTime CreatedDate { get; set; }

		// compositions
		public PersonDTO PersonInfo { get; set; }
		public UserDTO UserInfo { get; set; }
	}
}
