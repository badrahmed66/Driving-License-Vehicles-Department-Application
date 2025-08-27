using MyDVLD_DAL.Behaviours;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.Utility;
using MyDVLD_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MyDVLD_DAL
{
	/// <summary>
	/// Data access layer for handling TestType records.
	/// Provides methods to retrieve, insert, update, delete, and find test types in the database.
	/// </summary>
	static public class TestTypeDAL
	{
		/// <summary>
		/// Retrieves all test types from the database.
		/// </summary>
		/// <returns>A list of <see cref="TestTypeDTO"/> objects. Returns an empty list if none found or an error occurs.</returns>
		static public List<TestTypeDTO> Retrieve()
		{
			List<TestTypeDTO> lists = new List<TestTypeDTO>();
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.Retrieve, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								lists.Add(TestTypeMapper.GetDTO(reader));
							}
							return lists;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestTypeDAL), nameof(Retrieve), e.Message));

				LogFile.AddLogToFile(nameof(TestTypeDAL), nameof(Retrieve), e.Message, LogFile.ErrorsFile);
				return new List<TestTypeDTO>();
			}
		}

		/// <summary>
		/// Inserts a new test type record into the database.
		/// </summary>
		/// <param name="dto">The <see cref="TestTypeDTO"/> object containing the test type data.</param>
		/// <returns>The ID of the newly inserted test type if successful; otherwise, -1.</returns>
		static public int Insert(TestTypeDTO dto)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.Add, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestTypeParameterBinder.AddInsertParameters(cmd, dto);
						object result = cmd.ExecuteScalar();
						return (result != null && int.TryParse(result.ToString(), out int newID)) ? newID : -1;
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestTypeDAL), nameof(Insert), e.Message));

				LogFile.AddLogToFile(nameof(TestTypeDAL), nameof(Insert), e.Message, LogFile.ErrorsFile);
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing test type record in the database.
		/// </summary>
		/// <param name="dto">The <see cref="TestTypeDTO"/> object containing updated test type data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		static public bool Update(TestTypeDTO dto)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.Update, con))
					{
						TestTypeParameterBinder.AddUpdateParameters(cmd, dto);
						return cmd.ExecuteNonQuery() > 0;
					}
				}
			}
			catch (Exception e)
			{

				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestTypeDAL), nameof(Update), e.Message));

				LogFile.AddLogToFile(nameof(TestTypeDAL), nameof(Update), e.Message, LogFile.ErrorsFile);
				return false;
			}
		}

		/// <summary>
		/// Finds a test type record by its ID.
		/// </summary>
		/// <param name="id">The test type ID.</param>
		/// <returns>A <see cref="TestTypeDTO"/> object if found; otherwise, null.</returns>
		static public TestTypeDTO FindByID(int id)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.FindByID, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestTypeParameterBinder.AddTestTypeIDParameters(cmd, id);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							return reader.Read() ? TestTypeMapper.GetDTO(reader) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestTypeDAL), nameof(FindByID), e.Message));

				LogFile.AddLogToFile(nameof(TestTypeDAL), nameof(FindByID), e.Message, LogFile.ErrorsFile);
				return null;
			}
		}

		/// <summary>
		/// Deletes a test type record by its ID.
		/// </summary>
		/// <param name="id">The test type ID.</param>
		/// <returns>True if the deletion was successful; otherwise, false.</returns>
		public static bool Delete(int id)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.Delete, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestTypeParameterBinder.AddTestTypeIDParameters(cmd, id);
						return cmd.ExecuteNonQuery() > 0;
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestTypeDAL), nameof(Delete), e.Message));

				LogFile.AddLogToFile(nameof(TestTypeDAL), nameof(Delete), e.Message, LogFile.ErrorsFile);
				return false;
			}
		}
	}
}
