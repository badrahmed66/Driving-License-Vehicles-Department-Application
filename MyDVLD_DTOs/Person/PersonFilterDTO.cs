using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs
{
	/// <summary>
	/// Represents the available filtering options for querying person records.
	/// 
	/// This DTO is used in the "People" form to provide a flexible way 
	/// of filtering the data instead of passing individual parameters.
	/// 
	/// Each property is optional; null or empty values are ignored 
	/// during the filtering process.
	/// </summary>
	public class PersonFilterDTO
    {
        public int? PersonID {  get; set; }
        public string NationalNo { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public char? Gender { get; set; }
        public string Country { get; set; }
    }
}
