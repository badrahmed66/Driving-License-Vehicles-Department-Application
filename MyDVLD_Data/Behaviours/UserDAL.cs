using System;
using MyDVLD_DTO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DTOs.User;
using MyDVLD_DTO.User;

namespace MyDVLD_DAL
{
	/// <summary>
	/// Data Access Layer (DAL) for managing User data.
	/// Provides methods for retrieving, searching, inserting, updating, and deleting users
	/// by interacting with the database through stored procedures.
	/// </summary>
	public static class UserDAL
  {
		/// <summary>
		/// Retrieves a filtered list of users based on the provided column and value.
		/// </summary>
		public static List<UserViewDTO> RetrieveWithFilter(string filterColumn = "" , string filterValue = "")
        {
            var users = new List<UserViewDTO>();

            var filters = new UserFilterDTO();
            
            if(!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
            {
                switch(filterColumn)
                {
                    case "Full Name":
                        filters.FullName = filterValue;
                        break;

                    case "User ID":
                        if (int.TryParse(filterValue, out int id))
                            filters.UserID = id;
                        else
                            return users;
                            break;

                    case "Person ID":
                        if (int.TryParse(filterValue, out int personID))
                            filters.PersonID = personID;
                        else
                            return users;
                            break;

                    case "Is Active":
                        filters.IsActive = true;
                        break;

                    case "User Name":
                        filters.UserName = filterValue;
                        break;

                    default:
                        return users;
                }
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(DataPath.ConnectionPath))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(UserProcedures.RetrieveWithFilter, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                      UserParameterBinder.AddRetrieveParameters(cmd, filters);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(UserMapper.ReadDTOView(reader));
                            }
                            return users;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(UserDAL)}].[{nameof(RetrieveWithFilter)}] : {e.Message}");
                return new List<UserViewDTO>();
            }
        }

		/// <summary>
		/// Finds user login data by username or userID. 
		/// Used primarily for authentication (login).
		/// </summary>
		public static UserLoginDTO FindUserLoginByName(string userName = null , int? userID = null)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(UserProcedures.FindForLogin, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        UserParameterBinder.AddUserNameparameters(cmd, userName, userID);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read() ? UserMapper.GetLoginDTO(reader) : null;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(UserDAL)}].[{nameof(FindUserLoginByName)}] : {e.Message}");
                return null;
            }
        }

		/// <summary>
		/// Finds a user by one of the provided options: UserID, UserName, or PersonID.
		/// </summary>
		public static UserDTO FindByUserIDorNameorPersonIDorNationalNo(int? userID = null, string userName = null, int? userPersonID = null )
        {
            if ((userID == null && userName == null && userPersonID == null ) || (userID != null && userName != null && userPersonID != null )) return null;

            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(UserProcedures.FindWithOptions, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        UserParameterBinder.AddFindParameters(cmd,userID,userPersonID,userName);
                        
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read() ? UserMapper.GetDTO(reader) : null;
                        }
                    }
                }

            }
            catch(Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(UserDAL)}].[{nameof(FindByUserIDorNameorPersonIDorNationalNo)}] : {e.Message}");
                return null;
            }
        }

		/// <summary>
		/// Inserts a new user into the database and returns the newly generated UserID.
		/// </summary>
		public static int Insert(UserLoginDTO dto)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(UserProcedures.Add, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        UserParameterBinder.AddInsertParameters(cmd, dto);

                        object ob = cmd.ExecuteScalar();

                        if (ob != null && int.TryParse(ob.ToString(), out int newID))
                            return newID;
                        else
                            return -1;
                    }
                }
            }
            catch( Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(UserDAL)}].[{nameof(Insert)}] : {e.Message}");
                return -1;
            }
        }

		/// <summary>
		/// Updates an existing user's login information.
		/// </summary>
		public static bool Update(UserLoginDTO dto)
        {
            try
            {
                using( SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(UserProcedures.Update, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        UserParameterBinder.AddUpdateParameters(cmd,dto); 

                        return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch (Exception e) 
            { 
                Debug.WriteLine($"Error in [{nameof(UserDAL)}].[{nameof(Update)}] : {e.Message}");
                return false; 
            }
        }


		/// <summary>
		/// Deletes a user by their ID.
		/// </summary>
		public static bool Delete(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(UserProcedures.Delete, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        UserParameterBinder.AddUserIDParameters(cmd,id);
                        return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch (Exception e) { 
                Debug.WriteLine($"Error in [{nameof(UserDAL)}].[{nameof(Delete)}] : {e.Message}");
                return false;
            }
        }

    }
}
