using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO.Person
{
	/// <summary>
	/// Data Transfer Object (DTO) used for displaying person details 
	/// in the "People" DataGridView form.
	/// 
	/// This class is optimized for read-only presentation purposes 
	/// and does not represent the full schema of the "People" table.
	/// </summary>
	public class PersonViewDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FullName {  get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryName {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
