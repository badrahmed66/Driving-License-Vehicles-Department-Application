using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Represents the data transfer object (DTO) for the "People" table in the database.
	/// This class is used to map the actual schema of the table and transfer data
	/// between the database layer and the business layer.
	///
	/// Note:
	/// - The <see cref="FullName"/> property is a computed property (not stored in the database),
	///   it concatenates the person's first, second, third (if any), and last names.
	/// - The <see cref="CountryInfo"/> property holds additional country details related to <see cref="CountryID"/>.
	/// </summary>
	public class PersonDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + ' ' + SecondName + ' ' + (string.IsNullOrEmpty(ThirdName) ? "" : ThirdName)+ ' ' + LastName; } }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public int CountryID { get; set; }
        public CountryDTO CountryInfo { get; set; }
        public string Address { get; set; }
    }
}

