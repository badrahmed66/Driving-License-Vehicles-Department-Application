using MyDVLD_DAL.Behaviours;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.Utility;
using MyDVLD_DTO;
using MyDVLD_DTOs.LocalDrivingLicenseApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MyDVLD_DAL
{
	/// <summary>
	/// Provides data access methods for managing Local Driving License Applications.
	/// Includes retrieval, insertion, updating, deletion, and test-related checks.
	/// </summary>
	public class LocalDrivingLicenseApplicationDAL
	{
		/// <summary>
		/// Retrieves a filtered list of local driving license applications based on the given filter column and value.
		/// </summary>
		public static List<LocalDrivingLicenseApplicationViewDTO> RetrieveLDLApplicationsWithFilter(string filterColumn = "", string filterValue = "")
		{
			var localAppList = new List<LocalDrivingLicenseApplicationViewDTO>();

			var filters = new LDLApplicationFilterDTO();

			if (!string.IsNullOrWhiteSpace(filterColumn) && !string.IsNullOrWhiteSpace(filterValue))
			{
				switch (filterColumn)
				{
					case "LDL App ID":
						if (int.TryParse(filterValue, out int localID))
							filters.LocalDrivingLicenseID = localID;
						else
							return localAppList;
						break;

					case "National No":
						filters.NationalNo = filterValue;
						break;

					case "Full Name":
						filters.FullName = filterValue;
						break;

					case "App Status":
						{
							switch (filterValue.ToLower())
							{
								case "new":
									filters.Status = 1;
									break;

								case "cancel":
									filters.Status = 2;
									break;

								case "complete":
									filters.Status = 3;
									break;
							}
							break;
						}
					default:
						return localAppList;
				}
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.RetrieveWithFiltering, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.AddRetrieveParameters(cmd, filters);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								localAppList.Add(LDLApplicationMapper.GetDTOView(reader));
							}
							return localAppList;
						}
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(RetrieveLDLApplicationsWithFilter), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(RetrieveLDLApplicationsWithFilter), e.Message));
				return new List<LocalDrivingLicenseApplicationViewDTO>();
			}
		}

		/// <summary>
		/// Inserts a new local driving license application and returns the generated ID.
		/// </summary>
		static public int InsertLDLApplication(LocalDrivingLicenseApplicationDTO localApp)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.Add, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.AddInsertParameters(cmd, localApp);

						object result = cmd.ExecuteScalar();

						if (result != null && int.TryParse(result.ToString(), out int newID))
							return newID;
						else
							return -1;
					}
				}
			}
			catch (Exception e)
			{

				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(InsertLDLApplication), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(InsertLDLApplication), e.Message));
				return -1;
			}
		}

		/// <summary>
		/// Updates an existing local driving license application.
		/// </summary>
		static public bool UpdateLDLApplication(LocalDrivingLicenseApplicationDTO localApp)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.Update, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.AddUpdateParameters(cmd, localApp);

						return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
					}
				}
			}
			catch (Exception e)
			{

				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(UpdateLDLApplication), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(UpdateLDLApplication), e.Message));
				return false;
			}
		}

		/// <summary>
		/// Deletes a local driving license application by its ID.
		/// </summary>
		static public bool DeleteLDLApplication(int lDLAppID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.Delete, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.Add("@localApplicationID", SqlDbType.Int).Value = lDLAppID;
						return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(DeleteLDLApplication), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(DeleteLDLApplication), e.Message));
				return false;
			}
		}

		/// <summary>
		/// Finds a local driving license application by either LDLAppID or ApplicationID.
		/// </summary>
		static public LocalDrivingLicenseApplicationDTO FindLDLApplicationByLDLApplicationIDorApplicationID(int? LDLAppID = null, int? applicationID = null)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.FindApplicationByID, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.AddLDLApplicationIDParameters(cmd, LDLAppID, applicationID);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							return reader.Read() ? LDLApplicationMapper.GetDTO(reader) : null;
						}
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(FindLDLApplicationByLDLApplicationIDorApplicationID), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(FindLDLApplicationByLDLApplicationIDorApplicationID), e.Message));
				return null;
			}
		}

		/// <summary>
		/// Checks whether the applicant has passed a specific test type.
		/// </summary>
		public static bool HasPassedTest(int localDrivingID, int testTypeID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.HasPassedThisTest, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, localDrivingID, testTypeID);
						return Convert.ToBoolean(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(HasPassedTest), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(HasPassedTest), e.Message));
				return false;
			}
		}

		/// <summary>
		/// Checks whether the applicant has attended a specific test type.
		/// </summary>
		public static bool HasAttendedTest(int localDrivingID, int testTypeID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.HasTheTestBeenAttended, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, localDrivingID, testTypeID);
						return Convert.ToBoolean(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(HasAttendedTest), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(HasAttendedTest), e.Message));
				return false;
			}
		}

		/// <summary>
		/// Checks whether the applicant has an active scheduled appointment for a specific test type.
		/// </summary>
		public static bool HasActiveScheduleAppointment(int localDrivingID, int testTypeID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.HasActiveScheduleAppointmentForTestType, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, localDrivingID, testTypeID);

						return Convert.ToBoolean(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(HasActiveScheduleAppointment), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(HasActiveScheduleAppointment), e.Message));
				return false;
			}
		}

		/// <summary>
		/// Gets the total number of trial attempts for a specific test type by the applicant.
		/// </summary>
		public static byte TotalTrailsTests(int localDrivingID, int testTypeID)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.TotalTrailsPerTest, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, localDrivingID, testTypeID);
						return Convert.ToByte(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception e)
			{
				LogFile.AddLogToFile(nameof(LocalDrivingLicenseApplicationDAL), nameof(TotalTrailsTests), e.Message, LogFile.ErrorsFile);

				EventLog.WriteEntry(LogFile.eventLogSource,
					LogFile.StringFormat(nameof(LocalDrivingLicenseApplicationDAL), nameof(TotalTrailsTests), e.Message));
				return 0;
			}
		}
	}
}
