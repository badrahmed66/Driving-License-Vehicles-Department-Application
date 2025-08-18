using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO.User
{
	/// <summary>
	/// Data Transfer Object (DTO) that represents a system user.
	/// Holds user account information and its linked person record.
	/// Used to transfer user data between layers (DAL, BLL, UI).
	/// </summary>

	public class UserDTO
    {
        public int UserID {  get; set; }
        public string UserName {  get; set; }
        public int PersonID {  get; set; }
        public bool IsActive {  get; set; }
       // composition for person
       public PersonDTO PersonInfoDTO { get; set; }
		public UserDTO()
		{
			PersonInfoDTO = new PersonDTO();
		}
	}
}
