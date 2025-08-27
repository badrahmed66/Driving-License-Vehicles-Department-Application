using System;
using System.Data.SqlClient;
using MyDVLD_DAL;
using MyDVLD_DAL.Interfaces;
using MyDVLD_DTOs;
using System.Data;
using System.Diagnostics;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.Utility;

namespace MyDVLD_DAL.Behaviours
{
	/// <summary>
	/// Provides data access operations for drivers, 
	/// including retrieval, insertion, and update functionality.
	/// </summary>
	public class DriverDAL : IDriverDAL
	{
		/// <summary>
		/// Retrieves a driver record by its unique DriverID.
		/// </summary>
		/// <param name="driverID">The DriverID of the driver to retrieve.</param>
		/// <returns>A DriverDTO object if found, otherwise null.</returns>
		public DriverDTO FindByDriverID(int driverID)
		{
			string query = "SELECT * FROM Drivers where DriverID = @DriverID";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@DriverID",SqlDbType.Int).Value = driverID;

						using(SqlDataReader r = cmd.ExecuteReader())
						{
							return (r.Read()) ? DriverMapper.ReadDTO(r) : null;
						}
					}
				}
			}
			catch(Exception ex)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(FindByDriverID), ex.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(DriverDAL), nameof(FindByDriverID), ex.Message));

				return null;
			}
		}

		/// <summary>
		/// Retrieves a driver record by the related PersonID.
		/// </summary>
		/// <param name="personID">The PersonID linked to the driver.</param>
		/// <returns>A DriverDTO object if found, otherwise null.</returns>
		public DriverDTO FindByPersonID(int personID)
		{
			string query = "SELECT * FROM Drivers where PersonID = @PersonID";

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = personID;

						using (SqlDataReader r = cmd.ExecuteReader())
						{
							return (r.Read()) ? DriverMapper.ReadDTO(r) : null;
						}
					}
				}
			}
			catch (Exception ex)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(FindByPersonID), ex.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(DriverDAL), nameof(FindByPersonID), ex.Message));
				return null;
			}
		}

		/// <summary>
		/// Retrieves all drivers with their full details (joined with People table).
		/// </summary>
		/// <returns>A DataTable containing drivers, or null if an error occurs.</returns>
		public DataTable RetrieveAll()
		{
			string query = @"SELECT  
											D.DriverID , D.PersonID , (P.FirstName + ' ' + P.SecondName + ' ' +
											ISNULL(P.ThirdName,'') + ' ' + P.LastName ) AS FullName , D.CreatedByUserID , D.CreatedDate
									FROM Drivers as D
									join People as P ON D.PersonID = P.PersonID";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						using (SqlDataReader r = cmd.ExecuteReader())
						{
							DataTable dt = new DataTable();
								dt.Load(r);

							return dt;
						}
					}
					
				}
			}
			catch(Exception ex)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(RetrieveAll), ex.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(DriverDAL), nameof(RetrieveAll), ex.Message));
				return null;
			}
		}

		/// <summary>
		/// Inserts a new driver record into the database.
		/// </summary>
		/// <param name="driver">The driver DTO containing details to insert.</param>
		/// <returns>The generated DriverID if successful, otherwise -1.</returns>
		public int Insert(DriverDTO driver)
		{
			string query = @"INSERT INTO Drivers
											(PersonID , CreatedByUserID , CreatedDate)
									Values 
										(@PersonID , @CreatedByUserID , @CreatedDate)
	
									SELECT SCOPE_IDENTITY();";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = driver.PersonID;
						cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = driver.CreatedByUserID;
						cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = driver.CreatedDate;

						return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
					}
				}
			}
			catch(Exception ex)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(Insert), ex.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(DriverDAL), nameof(Insert), ex.Message));
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing driver record in the database.
		/// </summary>
		/// <param name="driver">The driver DTO containing updated details.</param>
		/// <returns>True if update succeeded, otherwise false.</returns>
		public bool Update(DriverDTO driver)
		{
			string query = @"UPDATE Drivers
													Set
													PersonID = @PersonID , 
													CreatedByUserID = @CreatedByUserID,
													CreatedDate = @CreatedDate
													WHERE
													DriverID = @DriverID";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@DriverID",SqlDbType.Int).Value = driver.DriverID;
						cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = driver.PersonID;
						cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = driver.CreatedByUserID;
						cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = driver.CreatedDate;

						return Convert.ToBoolean(cmd.ExecuteNonQuery());
					}
				}
			}
			catch(Exception ex)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(Update), ex.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(DriverDAL), nameof(Update), ex.Message));
				return false;
			}
		}

	}
}
