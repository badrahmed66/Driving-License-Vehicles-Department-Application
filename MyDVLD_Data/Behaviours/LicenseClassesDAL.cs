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
	/// Provides data access methods for managing license classes.
	/// Responsible for retrieving and finding license class records
	/// from the database using stored procedures.
	/// </summary>
	public class LicenseClassesDAL
	{

		/// <summary>
		/// Retrieves all license classes from the database.
		/// </summary>
		/// <returns>List of <see cref="LicenseClassesDTO"/> containing license class details.</returns>
		public static List<LicenseClassesDTO> Retrieve()
		{
			List<LicenseClassesDTO> classesList = new List<LicenseClassesDTO>();
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(LicenseClassesProcedures.Retrieve, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								classesList.Add(LicenseClassesMapper.ReadDTO(reader));
							}
							return classesList;
						}
					}
				}
			}
			catch (Exception ex)
			{
				LogFile.AddLogToFile(nameof(LicenseClassesDAL), nameof(Retrieve), ex.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LicenseClassesDAL), nameof(Retrieve), ex.Message));
				return new List<LicenseClassesDTO>();
			}
		}

		/// <summary>
		/// Finds a license class by either its ID or its title.
		/// Exactly one parameter must be provided (ID or Title).
		/// </summary>
		/// <param name="licenseID">Optional license class ID.</param>
		/// <param name="licenseTitle">Optional license class title.</param>
		/// <returns>
		/// A <see cref="LicenseClassesDTO"/> matching the search criteria,
		/// or null if not found or invalid parameters were provided.
		/// </returns>
		public static LicenseClassesDTO Find(int? licenseID = null, string licenseTitle = null)
		{

			if ((licenseID == null && licenseTitle == null) || (licenseID != null && licenseTitle != null))
				return null;

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(LicenseClassesProcedures.Find, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						LicenseClassParameterBinder.AddFindParameters(cmd, licenseID, licenseTitle);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							return reader.Read() ? LicenseClassesMapper.ReadDTO(reader) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LicenseClassesDAL), nameof(Find), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LicenseClassesDAL), nameof(Find), e.Message));
				return null;
			}
		}
	}
}
