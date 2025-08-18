using MyDVLD_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;
using MyDVLD_DTOs;
using MyDVLD_Data.Mapper;
using MyDVLD_Data.ParameterBinder;

namespace MyDVLD_DAL.Behaviours
{
	/// <summary>
	/// Provides data access operations for International Licenses, 
	/// including retrieval, insertion, update, and lookup by IDs.
	/// </summary>
	public class InternationalLicenseDAL : IInternationalLicenseDAL
	{
		/// <summary>
		/// Retrieves all international licenses with driver and user details.
		/// </summary>
		/// <returns>A DataTable with licenses data, or null if an error occurs.</returns>
		public DataTable Retrieve()
		{
			string query = @"select I.InternationalLicenseID 
, (People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName) As FullName, I.IssueDate , I.ExpirationDate , I.DriverID , I.IssuedUsingLocalLicenseID , I.ApplicationID ,
I.IsActive , Users.UserName as ByUserName

from InternationalLicenses as I
join Drivers on I.DriverID = Drivers.DriverID
join People on Drivers.PersonID = People.PersonID
join Users on UserID = I.CreatedByUserID";

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						using (SqlDataReader r = cmd.ExecuteReader())
						{
							DataTable dt = new DataTable();
							if (r.HasRows)
								dt.Load(r);

							return dt;
						}
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(Retrieve)}\n{nameof(e.Message)}");
				return null;
			}
		}

		/// <summary>
		/// Finds the most recent international license record by DriverID.
		/// </summary>
		/// <param name="driverID">The ID of the driver.</param>
		/// <returns>An InternationalLicenseDTO object if found, otherwise null.</returns>
		public InternationalLicenseDTO FindByDriverID(int driverID)
		{
			string query = @"select 
											InternationalLicenseID , IssueDate , IsActive , DriverID , CreatedByUserID ,	IssuedUsingLocalLicenseID, ApplicationID , ExpirationDate
											from InternationalLicenses
											where
											DriverID = @DriverID
											order by ExpirationDate desc";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open(); 
					using(SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = driverID;

						using(SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? InternationalLicenseMapper.GetDTO(r) : null;
						}
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(FindByDriverID)}\n{nameof(e.Message)}");
				return null;
			}
		}


		/// <summary>
		/// Retrieves all international licenses for a specific driver.
		/// </summary>
		/// <param name="driverID">The driver ID to filter by.</param>
		/// <returns>A DataTable containing licenses, or null if an error occurs.</returns>
		public DataTable RetrieveAll(int driverID)
		{
			string query = @"select * from InternationalLicenses 
											where DriverID = @DriverID				
											order by IsActive , ExpirationDate desc";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = driverID;
						using(SqlDataReader r = cmd.ExecuteReader())
						{
							DataTable dt = new DataTable();
							if (r.HasRows)
								dt.Load(r);

							return dt;
						}
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(RetrieveAll)}\n{nameof(e.Message)}");
				return null;
			}
		}

		/// <summary>
		/// Finds an international license by its unique ID.
		/// </summary>
		/// <param name="id">The InternationalLicenseID.</param>
		/// <returns>An InternationalLicenseDTO object if found, otherwise null.</returns>
		public InternationalLicenseDTO FindByInternationalID(int id)
		{
			string query = @"select 
												InternationalLicenseID , IssueDate , IsActive , DriverID , CreatedByUserID , IssuedUsingLocalLicenseID,ApplicationID , ExpirationDate
												from InternationalLicenses
												where
												InternationalLicenseID = @InternationalLicenseID
												order by ExpirationDate desc";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@InternationalLicenseID",SqlDbType.Int).Value = id;

						using(SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? InternationalLicenseMapper.GetDTO(r) : null;
						}
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(FindByInternationalID)}\n{nameof(e.Message)}");
				return null;
			}
		}

		/// <summary>
		/// Inserts a new international license and deactivates previous ones for the same driver.
		/// </summary>
		/// <param name="dto">The DTO containing license details.</param>
		/// <returns>The generated InternationalLicenseID if successful, otherwise -1.</returns>
		public int Insert(InternationalLicenseDTO dto)
		{
			string query = @"UPDATE InternationalLicenses
												SET
												IsActive = 0
												WHERE DriverID = @DriverID;
												
												INSERT INTO InternationalLicenses
												(IssueDate , IsActive , DriverID , CreatedByUserID ,IssuedUsingLocalLicenseID ,
												ApplicationID , ExpirationDate)
												VALUES(@IssueDate,@IsActive,@DriverID,@CreatedByUserID,
												@IssuedUsingLocalLicenseID,
												@ApplicationID,@ExpirationDate);
												
												SELECT SCOPE_IDENTITY();";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query, con))
					{
						// send the parameters to the command object
						//InternationalLicenseBinder.Insert(cmd, dto);
						cmd.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
						cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
						cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
						cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
						cmd.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = dto.RelatedToLocalLicenseID;
						cmd.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
						cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;

						return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(Insert)}\n{nameof(e.Message)}");
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing international license record.
		/// </summary>
		/// <param name="dto">The DTO with updated license details.</param>
		/// <returns>True if update was successful, otherwise false.</returns>
		public bool Update(InternationalLicenseDTO dto)
		{
			string query = @"UPDATE InternationalLicenses
											SET
											IssueDate = @IssueDate,
											IsActive = @IsActive,
											DriverID = @DriverID,
											CreatedByUserID = @CreatedByUserID,
											IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
											ApplicationID = @ApplicationID,
											ExpirationDate = @ExpirationDate
											WHERE InternationalLicenseID = @InternationalLicenseID";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						// send the parameters to the command object
						InternationalLicenseBinder.Update(cmd, dto);

						return Convert.ToBoolean(cmd.ExecuteNonQuery());

					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(Update)}\n{nameof(e.Message)}");
				return false;
			}
		}

		/// <summary>
		/// Gets the currently active international license ID for a given driver.
		/// </summary>
		/// <param name="driverID">The driver ID to check.</param>
		/// <returns>The active InternationalLicenseID if found, otherwise -1.</returns>
		public int GetActiveInternationalLicenseID(int driverID)
		{
			string query = @"SELECT TOP 1 InternationalLicenseID
											FROM InternationalLicenses
											WHERE DriverID = @DriverID 
											AND 
											IsActive = 1
											ORDER BY ExpirationDate desc";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.Add("@DriverID",SqlDbType.Int).Value = driverID;

						return Convert.ToInt32(cmd.ExecuteScalar()??-1);
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error in {nameof(InternationalLicenseDAL)}.{nameof(GetActiveInternationalLicenseID)}\n{nameof(e.Message)}");
				return -1;
			}
		}
	}
}
