using MyDVLD_DAL.Interfaces;
using MyDVLD_DAL.Mapper;
using MyDVLD_DTOs;
using System;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDVLD_DAL.ParameterBinder;

namespace MyDVLD_DAL.Behaviours
{
	/// <summary>
	/// Provides data access methods for managing detained licenses,
	/// including retrieval, insertion, update, release, and status checks.
	/// </summary>
	public class DetainedLicenseDAL : IDetainedLicenseDAL
	{
		/// <summary>
		/// Retrieves a detained license record by its unique DetainID.
		/// </summary>
		/// <param name="detainID">The unique DetainID.</param>
		/// <returns>A DetainedLicenseDTO object if found, otherwise null.</returns>
		public DetainedLicenseDTO GetDetainedLicenseByID(int detainID)
		{
			string query = @"select * from DetainedLicenses where DetainID = @DetainID";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@DetainID",SqlDbType.Int).Value = detainID;

						using(SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? DetainedLicenseMapper.GetDTO(r) : null;
						}
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(GetDetainedLicenseByID)}\n{nameof(e.Message)}");
				return null;
			}
		}

		/// <summary>
		/// Retrieves a detained license record by LicenseID.
		/// </summary>
		/// <param name="licenseID">The related LicenseID.</param>
		/// <returns>A DetainedLicenseDTO object if found, otherwise null.</returns>
		public DetainedLicenseDTO GetDetainedLicenseByLicenseID(int licenseID)
		{
			string query = @"select * from DetainedLicenses where LicenseID = @LicenseID";

			try
			{
				using(SqlConnection con  = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@LicenseID",SqlDbType.Int).Value = licenseID;
						using(SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? DetainedLicenseMapper.GetDTO(r) : null;
						}
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(GetDetainedLicenseByLicenseID)}\n{nameof(e.Message)}");
				return null;
			}
		}

		/// <summary>
		/// Inserts a new detained license record into the database.
		/// </summary>
		/// <param name="detainedLicense">The detained license DTO containing details.</param>
		/// <returns>The generated DetainID if successful, otherwise -1.</returns>
		public int Insert(DetainedLicenseDTO detainedLicense)
		{
			string query = @"INSERT INTO DetainedLicenses
										(LicenseID,DetainDate,Fees,DetainByUserID,IsRelease,ReleaseDate
											,ReleasedByUserID,ReleaseApplicationID)
											VALUES
											(@LicenseID,@DetainDate,@Fees,@DetainByUserID,@IsRelease,@ReleaseDate,
											@ReleasedByUserID,@ReleaseApplicationID);
											SELECT SCOPE_IDENTITY();";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						// send the parameters from outer class
						DetainedLicenseBinder.InsertParameters(cmd, detainedLicense);

						return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(Insert)}\n{nameof(e.Message)}");
				return -1;
			}
		}

		/// <summary>
		/// Checks if a license is currently detained.
		/// </summary>
		/// <param name="licenseID">The LicenseID to check.</param>
		/// <returns>True if the license is detained, otherwise false.</returns>
		public bool IsLicenseDetained(int licenseID)
		{
			string query = @"SELECT IsDetained = 1
											FROM DetainedLicenses
											WHERE LicenseID = @LicenseID AND IsRelease = 0";
			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@LicenseID",SqlDbType.Int).Value = licenseID;

						return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(IsLicenseDetained)}\n{nameof(e.Message)}");

				return false;
			}
		}

		/// <summary>
		/// Releases a detained license by updating its status and release information.
		/// </summary>
		/// <param name="detainID">The DetainID of the license.</param>
		/// <param name="releaseByUserID">The user ID who releases the license.</param>
		/// <param name="releaseApplicationID">The application ID linked to the release.</param>
		/// <returns>True if the license was successfully released, otherwise false.</returns>
		public bool ReleaseDetainedLicense(int detainID, int releaseByUserID, int releaseApplicationID)
		{
			string query = @"UPDATE DetainedLicenses
											SET
											IsRelease = 1,
											ReleaseDate = GETDATE(),
											ReleasedByUserID = @ReleasedByUserID,
											ReleaseApplicationID = @ReleaseApplicationID
											WHERE
											DetainID = @DetainID";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						cmd.Parameters.Add("@DetainID",SqlDbType.Int).Value = detainID;
						cmd.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = releaseByUserID;
						cmd.Parameters.Add("@ReleaseApplicationID",SqlDbType.Int).Value = releaseApplicationID;

						return Convert.ToBoolean(cmd.ExecuteNonQuery());
					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(ReleaseDetainedLicense)}\n{nameof(e.Message)}");

				return false;
			}
		}

		/// <summary>
		/// Retrieves all detained licenses from the view.
		/// </summary>
		/// <returns>A DataTable containing detained licenses, or null if an error occurs.</returns>
		public DataTable RetrieveAll()
		{
			string query = @"select * from DetainedLicenses_View";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						DataTable dt = new DataTable();

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
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(RetrieveAll)}\n{nameof(e.Message)}");

				return null;
			}
		}

		/// <summary>
		/// Updates an existing detained license record in the database.
		/// </summary>
		/// <param name="detainedLicense">The detained license DTO containing updated details.</param>
		/// <returns>True if update succeeded, otherwise false.</returns>
		public bool Update(DetainedLicenseDTO detainedLicense)
		{
			string query = @"UPDATE DetainedLicenses
											SET
											LicenseID = @LicenseID,
											DetainDate = @DetainDate,
											Fees = @Fees,
											DetainByUserID = @DetainByUserID,
											IsRelease = @IsRelease,
											ReleaseDate = @ReleaseDate,
											ReleasedByUserID = @ReleaseByUserID,
											ReleaseApplicationID = @ReleaseApplicationID
											WHERE
											DetainID = @DetainID";

			try
			{
				using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using(SqlCommand cmd = new SqlCommand(query , con))
					{
						// Send the parameters
						DetainedLicenseBinder.UpdateParameters(cmd, detainedLicense);

						return Convert.ToBoolean(cmd.ExecuteNonQuery());

					}
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine($"Error In {nameof(DetainedLicenseDAL)}.{nameof(Update)}\n{nameof(e.Message)}");
				return false;
			}
		}
	}
}
