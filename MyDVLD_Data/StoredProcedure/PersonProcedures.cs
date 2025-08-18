using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
  public static class PersonProcedures
  {

		/// <summary>
		/// Retrieves people data for viewing with optional filters.
		/// </summary>
		/// <param name="personID">Person ID (optional)</param>
		/// <param name="nationalNo">National number (optional)</param>
		/// <param name="firstName">First name (optional)</param>
		/// <param name="lastName">Last name (optional)</param>
		/// <param name="country">Country name (optional)</param>
		/// <param name="phone">Phone number (optional)</param>
		/// <param name="gender">Gender (optional)</param>
		/// <returns>DataTable of people matching the filters</returns>
		public const string RetrieveWithFiltering = "People_RetrieveDataForViewing";


		/// <summary>
		/// Retrieves person details, optionally by PersonID or NationalNo.
		/// </summary>
		/// <param name="personID">Person ID (optional)</param>
		/// <param name="nationalNo">National number (optional)</param>
		/// <returns>Person details record</returns>
		public const string FindByIDOrNationalNo = "People_FindPersonDetails";

		/// <summary>
		/// Adds a new person record to the People table.
		/// </summary>
		/// <param name="nationalNo">National number of the person</param>
		/// <param name="firstName">First name</param>
		/// <param name="secondName">Second name</param>
		/// <param name="thirdName">Third name (optional)</param>
		///
		public const string Add = "People_AddNewPerson";

		/// <summary>
		/// Updates an existing person's details.
		/// </summary>
		/// <param name="personID">Person ID</param>
		/// <param name="nationalNo">National number</param>
		/// <param name="firstName">First name</param>
		/// <param name="secondName">Second name</param>
		/// <param name="thirdName">Third name (optional)</param>
		/// <param name="lastName">Last name</param>
		/// <param name="gender">Gender</param>
		/// <param name="phone">Phone number</param>
		/// <param name="dateOfBirth">Date of birth</param>
		/// <param name="email">Email (optional)</param>
		/// <param name="image">Image (optional)</param>
		/// <param name="address">Address</param>
		/// <param name="countryID">Country ID</param>
		/// <returns>None</returns>
		public const string Update = "People_UpdatePerson";

		/// <summary>
		/// Deletes a person record from the People table.
		/// </summary>
		/// <param name="personID">ID of the person to delete</param>
		/// <returns>None</returns>
		public const string Delete = "People_DeletePerson";


		/// <summary>
		/// Checks if a person already exists by PersonID or NationalNo.
		/// </summary>
		/// <param name="personID">Person ID (optional)</param>
		/// <param name="nationalNo">National number (optional)</param>
		/// <returns>Boolean indicating existence</returns>
		public const string IsExistsByIDOrNationalNo = "People_IsPersonAlreadyExists";
  }
}
