using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs.User
{
	/// <summary>
	/// Data Transfer Object (DTO) used specifically for user login operations.
	/// Holds the minimum required information to validate login credentials 
	/// and verify the account status.
	/// </summary>
	public class UserLoginDTO
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }
    }
}
