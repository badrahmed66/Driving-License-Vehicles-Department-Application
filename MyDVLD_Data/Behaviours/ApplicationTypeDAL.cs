using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MyDVLD_DTO;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.ParameterBinder;

namespace MyDVLD_DAL
{
	/// <summary>
	/// Provides data access methods for managing Application Types in the database.
	/// Includes CRUD operations and search by ID.
	/// </summary>
	public class ApplicationTypeDAL
    {
		/// <summary>
		/// Retrieves all application types from the database.
		/// </summary>
		/// <returns>List of application types, or empty list if none found.</returns>
		static public List<ApplicationTypeDTO> Retrieve()
        {
            var appList = new List<ApplicationTypeDTO>();

            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.Retrieve, con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                appList.Add(ApplicationTypeMapper.GetDTO(reader));
                            }
                            return appList;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDAL)}].[{nameof(Retrieve)}] : {e.Message}");
                return new List<ApplicationTypeDTO>();
            }
        }

		/// <summary>
		/// Inserts a new application type into the database.
		/// </summary>
		/// <param name="dto">The application type data transfer object.</param>
		/// <returns>The new application type ID, or -1 if insertion failed.</returns>
		static public int Insert(ApplicationTypeDTO dto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.Add, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationTypeParameterBinder.AddInsertParameters(cmd, dto);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int appID))
                            return appID;
                        else
                            return -1;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDAL)}].[{nameof(Insert)}] : {e.Message}");
                return -1;
            }
        }

		/// <summary>
		/// Updates an existing application type.
		/// </summary>
		/// <param name="dto">The application type data transfer object containing updated values.</param>
		/// <returns>True if update succeeded, otherwise false.</returns>
		static public bool Update(ApplicationTypeDTO dto)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.Update, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationTypeParameterBinder.AddUpdateParameters(cmd , dto);
                        return Convert.ToByte(cmd.ExecuteNonQuery()) > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDAL)}].[{nameof(Update)}] : {e.Message}");
                return false;
            }
        }

		/// <summary>
		/// Deletes an application type from the database.
		/// </summary>
		/// <param name="id">The ID of the application type to delete.</param>
		/// <returns>True if delete succeeded, otherwise false.</returns>
		static public bool Delete(int id)
        {            
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.Delete, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        ApplicationTypeParameterBinder.AddApplicationTypeIDParameters(cmd, id);
                        return  Convert.ToBoolean(cmd.ExecuteNonQuery()>0);
                    }
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDAL)}].[{nameof(Delete)}] : {e.Message}");
                return false;
            }
        }

		/// <summary>
		/// Finds a specific application type by its ID.
		/// </summary>
		/// <param name="id">The application type ID.</param>
		/// <returns>The application type DTO if found, otherwise null.</returns>
		static public ApplicationTypeDTO FindByID(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.FindByID, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationTypeParameterBinder.AddApplicationTypeIDParameters(cmd, id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read() ? ApplicationTypeMapper.GetDTO(reader) : null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDAL)}].[{nameof(FindByID)}] : {e.Message}");
                return null;
            }
        }
    }
}
