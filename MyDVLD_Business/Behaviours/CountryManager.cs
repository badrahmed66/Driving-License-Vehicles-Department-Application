using System;
using MyDVLD_DTO;
using System.Data;
using MyDVLD_DAL;
using System.Collections.Generic;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Service class to manage countries in the system.
	/// Provides methods to retrieve and find country information.
	/// </summary>
	public class CountryManager
	{
		/// <summary>
		/// Finds a country by its ID or Name.
		/// </summary>
		/// <param name="countryID">The unique identifier of the country (nullable).</param>
		/// <param name="countryName">The name of the country.</param>
		/// <returns>The corresponding <see cref="CountryDTO"/> if found; otherwise null.</returns>
		static public CountryDTO FindByCountryIDOrName(int? countryID, string countryName)
		{
			if ((countryID == null && countryName == null) || (countryID.HasValue && !string.IsNullOrEmpty(countryName)))
				return null;

			return CountryDAL.FindByIDOrName(countryID, countryName);
		}

		/// <summary>
		/// Retrieves all countries from the system.
		/// </summary>
		/// <returns>A list of <see cref="CountryDTO"/> objects.</returns>
		static public List<CountryDTO> RetrieveAllCountries()
		{
			return CountryDAL.Retrieve();
		}
	}
}
