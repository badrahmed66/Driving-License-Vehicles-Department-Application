using MyDVLD_DAL;
using MyDVLD_DAL.Interfaces;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.Utility;
using MyDVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MyDVLD_DAL.Behaviours
{
	/// <summary>
	/// Provides data access methods for managing licenses in the system.
	/// Supports CRUD operations, retrieval by different criteria,
	/// and utility methods for working with licenses.
	/// </summary>
	public class LicenseDAL : ILicenseDAL
	{
		/// <summary>
		/// Deactivates a license by setting its IsActive flag to false.
		/// </summary>
		/// <param name="licenseID">The ID of the license to deactivate.</param>
		/// <returns>True if the update succeeded, otherwise false.</returns>
		public bool DeActivateLicense(int licenseID)
		{
			string query = @"UPDATE Licenses
											SET
											IsActive = 0
											WHERE
											LicenseID = @LicenseID";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@LicenseID",SqlDbType.Int).Value = licenseID;

						return Convert.ToBoolean(cmd.ExecuteNonQuery());
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(LicenseDAL), nameof(DeActivateLicense), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LicenseDAL), nameof(DeActivateLicense), e.Message));
				return false;
			}
		}

		/// <summary>
		/// Finds a license by its unique ID.
		/// </summary>
		/// <param name="ID">The license ID to search for.</param>
		/// <returns>A <see cref="LicenseDTO"/> if found, otherwise null.</returns>
		public LicenseDTO FindByLicenseID(int ID)
		{
			string query = "select * from Licenses where LicenseID = @LicenseID";

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open(); 
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@LicenseID", SqlDbType.Int).Value = ID;

						using(SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? LicenseMapper.ReadDTO(r) : null;
						}
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(LicenseDAL), nameof(FindByLicenseID), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LicenseDAL), nameof(FindByLicenseID), e.Message));
				return null;
			}
		}

		/// <summary>
		/// Finds a license by the driver ID it belongs to.
		/// </summary>
		/// <param name="driverID">The driver ID linked to the license.</param>
		/// <returns>A <see cref="LicenseDTO"/> if found, otherwise null.</returns>
		public LicenseDTO FindByDriverID(int driverID)
		{
			string query = "select * from Licenses where DriverID = @DriverID";

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = driverID;

						using (SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? LicenseMapper.ReadDTO(r) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LicenseDAL), nameof(FindByDriverID), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LicenseDAL), nameof(FindByDriverID), e.Message));
				return null;
			}
		}

		/// <summary>
		/// Gets the active license ID for a driver in a specific license class.
		/// </summary>
		/// <param name="personID">The person ID of the driver.</param>
		/// <param name="licenseClassID">The class ID of the license.</param>
		/// <returns>The license ID if found, otherwise -1.</returns>
		public int GetActiveLicenseIDToDriver(int personID, int licenseClassID)
		{
			string query = @"SELECT Licenses.LicenseID 
													FROM Licenses
													JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
													WHERE
													Drivers.PersonID = @PersonID AND
													Licenses.LicenseClassID = @LicenseClassID AND
													Licenses.IsActive = 1";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@PersonID",SqlDbType.Int).Value = personID;
						cmd.Parameters.Add("@LicenseClassID",SqlDbType.Int).Value = licenseClassID;

						return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(GetActiveLicenseIDToDriver), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(DriverDAL), nameof(GetActiveLicenseIDToDriver), e.Message));
				return -1;
			}
		}

		/// <summary>
		/// Retrieves all licenses from the database.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all license records, or null if an error occurs.</returns>
		public DataTable RetrieveAll()
		{
			string query = "select * from Licenses";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query, con))
					{
						using(SqlDataReader r = cmd.ExecuteReader())
						{
							DataTable dt = new DataTable();
							dt.Load(r);

							return dt;
						}
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(RetrieveAll), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(DriverDAL), nameof(RetrieveAll), e.Message));
				return null;
			}
		}

		/// <summary>
		/// Inserts a new license record into the database.
		/// </summary>
		/// <param name="license">The license DTO containing license data to insert.</param>
		/// <returns>The ID of the newly inserted license, or -1 if insertion failed.</returns>
		public int Insert(LicenseDTO license)
		{
			string query = @"INSERT INTO	Licenses
										(DriverID,CreatedByUserID,ApplicationID,LicenseClassID,IssueDate,ExpirationDate,
										PaidFees,IsActive,IssueReason,Notes)
										VALUES
										(@DriverID,@CreatedByUserID,@ApplicationID,@LicenseClassID,@IssueDate,
										@ExpirationDate,@PaidFees,@IsActive,@IssueReason,@Notes);
										SELECT SCOPE_IDENTITY();";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						LicenseParameterBinder.Insert(cmd, license);

						return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(Insert), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(DriverDAL), nameof(Insert), e.Message));
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing license record in the database.
		/// </summary>
		/// <param name="license">The license DTO containing updated license data.</param>
		/// <returns>True if the update succeeded, otherwise false.</returns>
		public bool Update(LicenseDTO license)
		{
			string query = @"UPDATE Licenses
														SET
														DriverID = @DriverID,
														CreatedByUserID = @CreatedByUserID,
														LicenseClassID = @LicenseClassID,
														ApplicationID = @ApplicationID,
														IssueDate = @IssueDate,
														IssueReason = @IssueReason,
														ExpirationDate = @ExpirationDate,
														PaidFees = @PaidFees,
														IsActive = @IsActive,
														Notes = @Notes
														WHERE
														LicenseID = @LicenseID";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						LicenseParameterBinder.Update(cmd, license);
						return Convert.ToBoolean(cmd.ExecuteNonQuery());
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(Update), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(DriverDAL), nameof(Update), e.Message));
				return false;
			}
		}


		/// <summary>
		/// Retrieves all licenses for a specific driver in a given license class.
		/// </summary>
		/// <param name="driverID">The driver's ID.</param>
		/// <param name="licenseClassID">The license class ID.</param>
		/// <returns>A <see cref="DataTable"/> with the licenses, or null if none found.</returns>
		public DataTable RetrieveForDriver(int driverID, int licenseClassID)
		{
			string query = @"SELECT * FROM Licenses
														WHERE
														DriverID = @DriverID and
														LicenseClassID = @LicenseClassID";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = driverID;
						cmd.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = licenseClassID;

						DataTable dt = new DataTable();
						using(SqlDataReader r = cmd.ExecuteReader())
						{
							while (r.Read())
								dt.Load(r);

							return dt;
						}
					}
				}
			}
			catch( Exception e)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(RetrieveForDriver), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(DriverDAL), nameof(RetrieveForDriver), e.Message));
				return null;
			}

		}

		/// <summary>
		/// Retrieves all licenses owned by a driver, ordered by active status and expiration date.
		/// </summary>
		/// <param name="driverID">The ID of the driver.</param>
		/// <returns>A <see cref="DataTable"/> containing the driver's licenses, or null if none found.</returns>
		public DataTable GetLicensesByDriverID(int driverID)
		{
			DataTable dt = new DataTable();

			string query = @"select 
										L.LicenseID , L.ApplicationID , C.LicenseTitle ,L.IssueDate, L.ExpirationDate ,L.IsActive
										from Licenses as L
										JOIN LicenseClasses AS C ON L.LicenseClassID = C.LicenseID
										where
										L.DriverID = @driverID
										order by L.IsActive desc , ExpirationDate desc";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@driverID", SqlDbType.Int).Value = driverID;

						using(SqlDataReader r = cmd.ExecuteReader())
						{
							if (r.HasRows)
								dt.Load(r);

							return dt;
						}
					}
				}
			}
			catch(Exception e)
			{
				LogFile.AddLogToFile(nameof(DriverDAL), nameof(GetLicensesByDriverID), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(DriverDAL), nameof(GetLicensesByDriverID), e.Message));
				return null;
			}
		}

	}
}
