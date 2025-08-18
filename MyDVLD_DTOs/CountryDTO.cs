using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Data Transfer Object (DTO) representing a Country.
	/// Used for transferring country data between layers (DAL, BLL, UI).
	/// </summary>
	public class CountryDTO
    {
        public int ID {  get; set; }
        public string Name { get; set; }
    }
}
