using MyDVLD_DAL.Interfaces;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.Utility;
using MyDVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MyDVLD_DAL.Behaviours
{
	/// <summary>
	/// Data access layer for handling Test records.
	/// Provides methods to retrieve, insert, update, and count test records in the database.
	/// </summary>
	public class TestDAL : ITestDAL
	{
		/// <summary>
		/// Gets the most recent test information for a specific person, license, and test type.
		/// </summary>
		/// <param name="personID">The person's ID.</param>
		/// <param name="licenseID">The driving license ID.</param>
		/// <param name="testTypeID">The type of test ID.</param>
		/// <returns>A <see cref="TestDTO"/> object if found; otherwise, null.</returns>
		public TestDTO GetLastTestInfo(int personID, int licenseID, int testTypeID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestProcedures.GetLastTestInfo, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestParameterBinder.PassGetLastTestParameters(cmd, personID, licenseID, testTypeID);
						using (SqlDataReader dr = cmd.ExecuteReader())
						{
							return dr.Read() ? TestMapper.GetDTO(dr) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestDAL), nameof(GetLastTestInfo), e.Message));

				LogFile.AddLogToFile(nameof(TestDAL), nameof(GetLastTestInfo), e.Message, LogFile.ErrorsFile);
				return null;
			}
		}

		/// <summary>
		/// Retrieves all test records from the database.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all test records; null if an error occurs.</returns>
		public DataTable RetrieveTests()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestProcedures.RetieveAll, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
								dt.Load(reader);

							return dt;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestDAL), nameof(RetrieveTests), e.Message));

				LogFile.AddLogToFile(nameof(TestDAL), nameof(RetrieveTests), e.Message, LogFile.ErrorsFile);
				return null;
			}
		}

		/// <summary>
		/// Finds a test record by its ID.
		/// </summary>
		/// <param name="id">The test ID.</param>
		/// <returns>A <see cref="TestDTO"/> object if found; otherwise, null.</returns>
		public TestDTO FindByID(int id)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestProcedures.FindByID, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestParameterBinder.PassTestID(cmd, id);
						using (SqlDataReader r = cmd.ExecuteReader())
						{
							return r.Read() ? TestMapper.GetDTO(r) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestDAL), nameof(FindByID), e.Message));

				LogFile.AddLogToFile(nameof(TestDAL), nameof(FindByID), e.Message, LogFile.ErrorsFile);
				return null;
			}
		}

		/// <summary>
		/// Inserts a new test record into the database.
		/// </summary>
		/// <param name="dto">The <see cref="TestDTO"/> object containing test data.</param>
		/// <returns>The ID of the newly inserted test record if successful; otherwise, -1.</returns>
		public int Insert(TestDTO dto)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestProcedures.Insert, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestParameterBinder.PassTestDTOForInsert(cmd, dto);
						return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestDAL), nameof(Insert), e.Message));

				LogFile.AddLogToFile(nameof(TestDAL), nameof(Insert), e.Message, LogFile.ErrorsFile);
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing test record in the database.
		/// </summary>
		/// <param name="dto">The <see cref="TestDTO"/> object containing updated test data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		public bool Update(TestDTO dto)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestProcedures.Update, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestParameterBinder.PassTestDTOForUpdate(cmd, dto);
						return Convert.ToBoolean(cmd.ExecuteNonQuery());
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestDAL), nameof(Update), e.Message));

				LogFile.AddLogToFile(nameof(TestDAL), nameof(Update), e.Message, LogFile.ErrorsFile);
				return false;
			}
		}

		/// <summary>
		/// Counts the number of passed tests for a specific local driving license.
		/// </summary>
		/// <param name="localDrivingLicenseID">The local driving license ID.</param>
		/// <returns>The number of passed tests as a byte; 0 if an error occurs.</returns>
		public byte CountPassedTests(int localDrivingLicenseID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(TestProcedures.CountPassedTests, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestParameterBinder.PassLocalDrivingLicenseID(cmd, localDrivingLicenseID);
						object result = cmd.ExecuteScalar();
						return result != null ? Convert.ToByte(result) : (byte)0;
					}
				}
			}
			catch (Exception e)
			{
				EventLog.WriteEntry(LogFile.eventLogSource, LogFile.StringFormat(nameof(TestDAL), nameof(CountPassedTests), e.Message));

				LogFile.AddLogToFile(nameof(TestDAL), nameof(CountPassedTests), e.Message, LogFile.ErrorsFile);
				return 0;
			}
		}
	}
}
