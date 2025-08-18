using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.SqlClient;
using MyDVLD_DTOs.TestAppointment;
using MyDVLD_DAL;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.ParameterBinder;

namespace MyDVLD_DAL.Behaviours
{
	/// <summary>
	/// Provides data access methods for handling Test Appointments in the system.
	/// Includes operations such as Find, Insert, Update, and retrieval by various filters.
	/// </summary>
	public static class TestAppointmentDAL
	{
		/// <summary>
		/// Finds a test appointment by its unique ID.
		/// </summary>
		/// <param name="testAppointmentID">The ID of the test appointment to find.</param>
		/// <returns>A <see cref="TestAppointmentDTO"/> object if found; otherwise, null.</returns>
		public static TestAppointmentDTO FindByID(int testAppointmentID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.FindByID, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestAppointmentBinder.PassFindByIDParameters(cmd, testAppointmentID);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							return reader.Read() ? TestAppointmentMapper.GetDTO(reader) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(FindByID)}");
				Debug.WriteLine(e.Message);
				return null;
			}
		}

		/// <summary>
		/// Gets the most recent test appointment for a given test type and local driving license ID.
		/// </summary>
		/// <param name="testTypeID">The ID of the test type.</param>
		/// <param name="localID">The ID of the local driving license.</param>
		/// <returns>A <see cref="TestAppointmentDTO"/> object representing the last appointment; otherwise, null.</returns>
		public static TestAppointmentDTO GetLastOne(int testTypeID, int localID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.GetLastOne, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestAppointmentBinder.PassTestTypeIDAndLocalDrivingIDParameters(cmd, testTypeID, localID);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							return reader.Read() ? TestAppointmentMapper.GetDTO(reader) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(GetLastOne)}");
				Debug.WriteLine(e.Message);
				return null;
			}
		}

		/// <summary>
		/// Gets all test appointments for a specific Local Driving License application.
		/// </summary>
		/// <param name="localDrivingLicenseID">The ID of the local driving license application.</param>
		/// <returns>A list of <see cref="TestAppointmentDTO"/> objects.</returns>
		public static List<TestAppointmentDTO> GetAllAppointmentsForLDLApp(int localDrivingLicenseID)
		{
			List<TestAppointmentDTO> list = new List<TestAppointmentDTO>();
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.GetAll, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.Add("@LocalDrivingLicenseID", SqlDbType.Int).Value = localDrivingLicenseID;
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								list.Add(TestAppointmentMapper.GetDTO(reader));
							}
							return list;
						}
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(GetAllAppointmentsForLDLApp)}");
				Debug.WriteLine(e.Message);
				return new List<TestAppointmentDTO>();
			}
		}

		/// <summary>
		/// Inserts a new test appointment into the database.
		/// </summary>
		/// <param name="dto">The <see cref="TestAppointmentDTO"/> object containing appointment data.</param>
		/// <returns>The ID of the newly inserted appointment if successful; otherwise, -1.</returns>
		public static int Insert(TestAppointmentDTO dto)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.Insert, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestAppointmentBinder.PassInsertParameters(cmd, dto);

						object ob = cmd.ExecuteScalar();
						if (ob != null && int.TryParse(ob.ToString(), out int newID))
							return newID;
						else
							return -1;
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(Insert)}");
				Debug.WriteLine(e.Message);
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing test appointment in the database.
		/// </summary>
		/// <param name="dto">The <see cref="TestAppointmentDTO"/> object containing updated appointment data.</param>
		/// <returns>True if the update was successful; otherwise, false.</returns>
		public static bool Update(TestAppointmentDTO dto)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.Update, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestAppointmentBinder.PassUpdateParameters(cmd, dto);
						return Convert.ToBoolean(cmd.ExecuteNonQuery());
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(Update)}");
				Debug.WriteLine(e.Message);
				return false;
			}
		}

		/// <summary>
		/// Gets test appointments for a given test type and local driving license ID.
		/// </summary>
		/// <param name="testType">The ID of the test type.</param>
		/// <param name="localDrivingID">The ID of the local driving license.</param>
		/// <returns>A <see cref="DataTable"/> containing the matching test appointments.</returns>
		public static DataTable GetTestAppointmentPerTestType(int testType, int localDrivingID)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.FindPerTestType, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						TestAppointmentBinder.PassTestTypeIDAndLocalDrivingIDParameters(cmd, testType, localDrivingID);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								dt.Load(reader);
							}
							return dt;
						}
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(GetTestAppointmentPerTestType)}");
				Debug.WriteLine(e.Message);
				return null;
			}
		}

		/// <summary>
		/// Gets the test ID related to a specific test appointment ID.
		/// </summary>
		/// <param name="testAppointmentID">The ID of the test appointment.</param>
		/// <returns>The test ID if found; otherwise, -1.</returns>
		public static int GetTestID(int testAppointmentID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(StoredProcedure.TestAppointmentProcedure.GetTestID, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = testAppointmentID;

						object result = cmd.ExecuteScalar();
						return (result != null && int.TryParse(result.ToString(), out int testID)) ? testID : -1;
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in {nameof(TestAppointmentDAL)}.{nameof(GetTestID)}");
				Debug.WriteLine(e.Message);
				return -1;
			}
		}
	}
}
