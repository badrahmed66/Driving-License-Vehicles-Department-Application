using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs.User
{
	/// <summary>
	/// Data Transfer Object (DTO) used for filtering user records.
	/// Contains optional criteria (nullable fields) to apply when searching or retrieving users.
	/// </summary>
	public class UserFilterDTO
    {
        public int? PersonID {  get; set; }
        public int? UserID {  get; set; }
        public string FullName {  get; set; }
        public string UserName {  get; set; }
        public bool? IsActive {  get; set; }
    }
}
