using MyDVLD_DAL.Mapper;
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
	/// Provides data access methods for retrieving and searching countries 
	/// from the database using stored procedures.
	/// </summary>
	public class CountryDAL
	{
		/// <summary>
		/// Retrieves all countries from the database.
		/// </summary>
		/// <returns>List of CountryDTO objects. Returns empty list if an error occurs.</returns>
		static public List<CountryDTO> Retrieve()
		{
			List<CountryDTO> countrylist = new List<CountryDTO>();

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(CountryProcedures.Retrieve, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								countrylist.Add(CountryMapper.ReadDTO(reader));
							}
							return countrylist;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(ApplicationTypeDAL), nameof(Retrieve), e.Message));

				LogFile.AddLogToFile(nameof(ApplicationTypeDAL), nameof(Retrieve), e.Message, LogFile.ErrorsFile);
				return new List<CountryDTO>();
			}
		}


		/// <summary>
		/// Finds a country by ID or Name using a stored procedure.
		/// </summary>
		/// <param name="countryID">The unique country ID (nullable).</param>
		/// <param name="countryName">The country name (nullable).</param>
		/// <returns>A CountryDTO object if found, otherwise null.</returns>
		static public CountryDTO FindByIDOrName(int? countryID, string countryName)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(CountryProcedures.FindByIDOrName, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						cmd.Parameters.Add("@countryID", SqlDbType.Int).Value = (object)countryID ?? DBNull.Value;

						cmd.Parameters.Add("@countryName", SqlDbType.NVarChar, 150).Value = (object)countryName ?? DBNull.Value;

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
								return CountryMapper.ReadDTO(reader);
							else
								return null;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(ApplicationTypeDAL), nameof(FindByIDOrName), e.Message));

				LogFile.AddLogToFile(nameof(ApplicationTypeDAL), nameof(FindByIDOrName), e.Message, LogFile.ErrorsFile);
				return null;
			}
		}
	}
}
