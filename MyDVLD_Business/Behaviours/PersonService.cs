using System;
using MyDVLD_DAL;
using MyDVLD_DTO;
using System.Collections.Generic;
using MyDVLD_DTO.Person;
using MyDVLD_BLL.Validation;


namespace MyDVLD_BLL
{
	/// <summary>
	/// Provides business logic operations for managing Person entities.
	/// 
	/// This service class acts as a bridge between the Presentation layer 
	/// and the Data Access Layer (DAL), ensuring that business validation 
	/// rules are applied before interacting with the database.
	/// 
	/// Responsibilities:
	/// - Validate person details before insert/update/delete
	/// - Prevent duplicate National Numbers
	/// - Prevent deleting persons who are already users
	/// - Provide feedback messages for UI layer
	/// </summary>
	public class PersonService
  {
    private PersonDTO PersonInfo { get; set; }

    public PersonService(PersonDTO person)
        {
            PersonInfo = person ?? throw new ArgumentNullException(nameof(person));
        }

		/// <summary>
		/// Retrieves a filtered list of people for presentation purposes.
		/// 
		/// Parameters:
		/// - <paramref name="filterColumn"/>: the column to filter by (optional).
		/// - <paramref name="filterValue"/>: the value to match against (optional).
		/// 
		/// Returns:
		/// A list of <see cref="PersonViewDTO"/> objects matching the filter criteria.
		/// </summary>
		static public List <PersonViewDTO> RetrieveAllPeople(string filterColumn = "" , string filterValue = "")
        {
            return PersonDAL.RetrieveForView(filterColumn, filterValue);
        }


		/// <summary>
		/// Finds a person by either PersonID or NationalNo.
		/// 
		/// Parameters:
		/// - <paramref name="personID"/>: optional ID to search by.
		/// - <paramref name="nationalNo"/>: optional National Number to search by.
		/// - <paramref name="errorMessage"/>: output error message if invalid input.
		/// 
		/// Returns:
		/// A <see cref="PersonDTO"/> object if found, otherwise null.
		/// </summary>
		public static PersonDTO FindPersonByIDOrNationalNo(out string errorMessage ,int ? personID  , string nationalNo )
        {
            errorMessage = "";
           return PersonDAL.Find(personID,nationalNo, out errorMessage);
        }


		/// <summary>
		/// Inserts a new person into the system after validation.
		/// 
		/// Rules:
		/// - The National Number must be unique (checked via <see cref="PersonValidator"/>).
		/// 
		/// Parameters:
		/// - <paramref name="errorMessage"/>: output message describing success or failure.
		/// 
		/// Returns:
		/// True if the person was inserted successfully, otherwise false.
		/// </summary>
		public bool InsertPerson( out string errorMessage)
        {
            errorMessage = "";

            if(PersonValidator.IsPersonAlreadyExists(out errorMessage,null , nationalNo: PersonInfo.NationalNo))
            {
                errorMessage = "this National No already Exists in the system ";
                return false;
            }

            int personID = PersonDAL.Insert(PersonInfo);

            if (personID > 0)
            {
                errorMessage = "Person Saved Successfuly";
                PersonInfo.PersonID = personID;
                return true;
            }
            else
            {
                errorMessage = "Person didn't Save";
                return false;
            }
        }

		/// <summary>
		/// Updates an existing person's details.
		/// 
		/// Rules:
		/// - The Person must have a valid ID (> 0).
		/// 
		/// Parameters:
		/// - <paramref name="errorMessage"/>: output message describing success or failure.
		/// 
		/// Returns:
		/// True if the person was updated successfully, otherwise false.
		/// </summary>
		public bool UpdatePerson(out string errorMessage)
        {
            errorMessage = "";

            if(PersonInfo == null || PersonInfo.PersonID <= 0)
            {
                errorMessage = "invalid person ";
                return false;
            }

            if (PersonDAL.Update(PersonInfo))
            {
                errorMessage = "Person Updated Successfuly";
                return true;
            }
            else
            {
                errorMessage = "Person could not be Update";
                return false;
            }
        }

		/// <summary>
		/// Deletes a person from the system.
		/// 
		/// Rules:
		/// - A person cannot be deleted if they are already a registered user (checked via <see cref="UserValidator"/>).
		/// 
		/// Parameters:
		/// - <paramref name="personID"/>: the ID of the person to delete.
		/// - <paramref name="errorMessage"/>: output message describing success or failure.
		/// 
		/// Returns:
		/// True if the person was deleted successfully, otherwise false.
		/// </summary>
		public static bool DeletePerson(int personID,out string errorMessage)
        {
            errorMessage = "";

            if (UserValidator.IsPersonAlreadyUser(personID, null))
            {
                errorMessage = "Could not Delete , this person Already a user ";
                return false ;
            }

            if (PersonDAL.Delete(personID))
            {
                errorMessage = "Person has been Deleted Successfuly";
                return true;
            }
            else
            {
                errorMessage = "person has not found or Already Deleted";
                return false;
            }
        }

  }
}
