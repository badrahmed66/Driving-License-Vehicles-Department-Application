using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
  public static class CountryProcedures
  {
		/// <summary>
		/// Retrieves countries filtered by ID or Name.
		/// </summary>
		/// <param name="countryID">Optional ID of the country</param>
		/// <param name="countryName">Optional name of the country</param>
    public const string FindByIDOrName = "Countries_Find";
		/// <summary>
		/// Retrieves all countries from the database.
		/// </summary>
		public const string Retrieve = "Countries_RetrieveCountries";
  }
}
