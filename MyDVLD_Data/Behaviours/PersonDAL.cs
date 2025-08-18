using System;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DTO;
using MyDVLD_DTO.Person;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using MyDVLD_DTOs;

namespace MyDVLD_DAL
{

	/// <summary>
	/// Data Access Layer (DAL) class for handling all database operations 
	/// related to the "Person" entity.
	///
	/// This class is responsible for executing stored procedures, 
	/// binding parameters, and mapping database records into Person DTOs.
	/// 
	/// Supported operations:
	/// - Retrieve: fetch people data with optional filtering
	/// - Find: retrieve a single person by ID or NationalNo
	/// - Insert: add a new person record
	/// - Update: modify an existing person record
	/// - Delete: remove a person record
	/// 
	/// Note: All methods handle database exceptions internally and log them
	/// to the debug output.
	/// </summary>
	public class PersonDAL
    {

		/// <summary>
		/// Retrieves a filtered list of people for display in the "People" view form.
		/// 
		/// Parameters:
		/// - <paramref name="filterColumn"/>: the column name to filter by (e.g., "National No").
		/// - <paramref name="filterValue"/>: the value to match against.
		/// 
		/// Returns:
		/// A list of <see cref="PersonViewDTO"/> objects that satisfy the filter.
		/// Returns an empty list if no matches or if the filter is invalid.
		/// </summary>
		public static List<PersonViewDTO> RetrieveForView(string filterColumn = "", string filterValue = "")
        {
            List<PersonViewDTO> peopleView = new List<PersonViewDTO>();

            PersonFilterDTO filterDTO = new PersonFilterDTO();

            if (!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
            {
                switch (filterColumn)
                {
                    case "Person ID":
                        {
                            if (int.TryParse(filterValue, out int id))
                                filterDTO.PersonID = id;
                            else
                                return peopleView;
                            break;
                        }

                    case "National No":
                        {
                            filterDTO.NationalNo = filterValue;
                            break;
                        }
                    case "First Name":
                        {
                            filterDTO.FirstName = filterValue;
                            break;
                        }
                    case "Last Name":
                        {
                            filterDTO.LastName = filterValue;
                            break;
                        }
                    case "Country":
                        {
                            filterDTO.Country = filterValue;
                            break;
                        }
                    case "Phone":
                        {
                            filterDTO.Phone = filterValue;
                            break;
                        }
                    case "Gender":
                        {
                            if (filterValue.ToLower() == "m")
                                filterDTO.Gender = 'M';
                            else if (filterValue.ToLower() == "f")
                                filterDTO.Gender = 'F';
                            else
                                return peopleView;
                            break;
                        }
                    default:
                    return peopleView;
                }
            }
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(PersonProcedures.RetrieveWithFiltering, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        PersonParameterBinder.AddRetrieveParameters(cmd, filterDTO);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                             {
                                peopleView.Add(PersonMapper.GetViewDTO(reader));
                             }
                        }
                    }
                }
            }
            catch(Exception e) 
            {
                Debug.WriteLine($"Error in [{nameof(PersonDAL)}].[{nameof(RetrieveForView)}] : {e.Message}");
                return new List<PersonViewDTO>();
            }
            return peopleView;
        }

		/// <summary>
		/// Finds a single person record by either PersonID or NationalNo.
		/// 
		/// Parameters:
		/// - <paramref name="personID"/>: optional person ID to search for.
		/// - <paramref name="nationalNo"/>: optional national number to search for.
		/// - <paramref name="errorMessage"/>: output parameter containing an error message if input is invalid.
		/// 
		/// Rules:
		/// - Only one of PersonID or NationalNo should be provided.
		/// - If both are provided, or both are null, an error message is returned and the method exits.
		/// 
		/// Returns:
		/// A <see cref="PersonDTO"/> if found, otherwise null.
		/// </summary>
		static public PersonDTO Find( int? personID  , string nationalNo, out string errorMessage  )
        {
            errorMessage = "";

            if((personID.HasValue && nationalNo != null)||(personID is null && nationalNo == null))
            {
                errorMessage = "You Must pass only one of (persond ID ) or (natoinal no)";
                return null;
            }

            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(PersonProcedures.FindByIDOrNationalNo, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        PersonParameterBinder.AddFindParameters(cmd, personID,nationalNo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read() ? PersonMapper.GetDTO(reader) : null;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(PersonDAL)}].[{nameof(Find)}] : {e.Message}");
                return null; 
            }
        }



		/// <summary>
		/// Inserts a new person record into the database.
		/// 
		/// Parameters:
		/// - <paramref name="person"/>: the DTO containing the person details.
		/// 
		/// Returns:
		/// The newly generated PersonID if successful, otherwise -1.
		/// Also updates the <see cref="PersonDTO.PersonID"/> property of the input object.
		/// </summary>
		static public int Insert(PersonDTO person)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(PersonProcedures.Add, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        PersonParameterBinder.AddInsertParameters(cmd, person);

                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        person.PersonID = id;
                        return id;
                    }
                }
            }
            catch (Exception  e)
            {
                Debug.WriteLine($"Error in [{nameof(PersonDAL)}].[{nameof(Insert)}] : {e.Message}");
                return -1;
            }
        }



		/// <summary>
		/// Updates an existing person record in the database.
		/// 
		/// Parameters:
		/// - <paramref name="person"/>: the DTO containing the updated person details.
		/// 
		/// Returns:
		/// True if the record was updated successfully, otherwise false.
		/// </summary>
		static public bool Update(PersonDTO person)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(PersonProcedures.Update, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        PersonParameterBinder.AddUpdateParameters(cmd, person);
                     
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(PersonDAL)}].[{nameof(Update)}] : {e.Message}");
                return false;
            }
        }


		/// <summary>
		/// Deletes a person record from the database by ID.
		/// 
		/// Parameters:
		/// - <paramref name="ID"/>: the PersonID of the record to delete.
		/// 
		/// Returns:
		/// True if the record was deleted successfully, otherwise false.
		/// </summary>
		static public bool Delete(int ID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(PersonProcedures.Delete, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        PersonParameterBinder.AddDeleteParameters(cmd, ID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(PersonDAL)}].[{nameof(Delete)}] : {e.Message}");
                return false;
            }
        }

  }
}
