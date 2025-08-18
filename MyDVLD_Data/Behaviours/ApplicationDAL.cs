using System;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using MyDVLD_DTO;
using MyDVLD_DAL.Mapper;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DTOs.Application;

namespace MyDVLD_DAL
{
	/// <summary>
	/// Provides data access methods for managing Application records in the database.
	/// Includes CRUD operations, status updates, and validation checks.
	/// </summary>
	public class ApplicationDAL
    {


		/// <summary>
		/// Retrieves a list of applications based on optional filter column and value.
		/// </summary>
		/// <param name="filterColumn">The column to filter by (e.g., "Application ID").</param>
		/// <param name="filterValue">The value to match in the filter column.</param>
		/// <returns>A list of applications matching the filter, or empty list if none found.</returns>
		/// </summary>
		static public List<ApplicationDTO> RetrieveApplicationsWithFilter(string filterColumn = "" , string filterValue = "")
        {
            var appList = new List<ApplicationDTO>();

            var filters = new ApplicationFilterDTO();

            if(!string.IsNullOrWhiteSpace(filterColumn) || !string.IsNullOrWhiteSpace(filterValue))
            {
                switch (filterColumn)
                {
                    case "Application ID":
                        if (int.TryParse(filterValue, out int value))
                            filters.ApplicationID = value;
                        else
                            return appList;
                            break;

                    case "Applicant Person ID":
                        if (int.TryParse(filterValue, out int applicantValue))
                            filters.ApplicantPersonID = applicantValue;
                        else
                            return appList;
                            break;

                    case "Applicant National No":
                        filters.ApplicantNationalNo = filterColumn;
                        break;

                    case "Created By User ID":
                        if (int.TryParse(filterValue, out int userID))
                            filters.CreateByUserID = userID;
                        else
                            return appList;
                            break;

                    case "Created By User National No":
                        filters.CreateByUserNationalNo = filterColumn;
                        break;

                    case "Application Type":
                        if (int.TryParse(filterValue, out int appType))
                            filters.ApplicatoinType = appType;
                        else
                            return appList;
                            break;

                    case "Application Status":
                        if (int.TryParse(filterValue, out int appStatus))
                            filters.ApplicationStatus = (byte)appStatus;
                        else
                            return appList;
                            break;

                    default:
                        return appList;

                }
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(ApplicationProcedures.RetrieveWithFilter, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddRetrieveParameters(cmd, filters);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                appList.Add(ApplicationMapper.GetDTO(reader));
                            }
                            return appList;
                        }
                    }
                }
            }
            catch (Exception e) 
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(RetrieveApplicationsWithFilter)}] : {e.Message}");
                return new List<ApplicationDTO>();
            }
        }

		/// <summary>
		/// Finds a specific application by its unique ID.
		/// </summary>
		/// <param name="appID">The application ID to search for.</param>
		/// <returns>The application if found, otherwise null.</returns>
    /// </summary>
		static public ApplicationDTO FindApplicatioinByID(int appID)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.FindByID, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddAppIDParameter(cmd, appID);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read() ? ApplicationMapper.GetDTO(reader) : null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error In [{nameof(ApplicationDAL)}].[{nameof(FindApplicatioinByID)}] : {e.Message}");
                return null;
            }
        }

		/// <summary>
		/// Inserts a new application into the database.
		/// </summary>
		/// <param name="app">DTO containing application details.</param>
		/// <returns>The newly created application ID, or -1 if insertion failed.</returns>
		static public int InsertApplication(ApplicationDTO app)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))   
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.Add, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddInsertParameters(cmd, app);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int newAppID))
                            return newAppID;
                        else
                            return -1;
                    }
                }
            }
            catch(Exception e) 
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(InsertApplication)}] : {e.Message}");
                return -1;
            }
        }

		/// <summary>
		/// Updates an existing application in the database.
		/// </summary>
		/// <param name="app">DTO containing updated application details.</param>
		/// <returns>True if update succeeded, otherwise false.</returns>
		static public bool UpdateApplication(ApplicationDTO app)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.Update, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddUpdateParameters(cmd, app);


                        return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch (Exception e) 
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(UpdateApplication)}] : {e.Message}");
                return false;
            }
        }

		/// <summary>
		/// Deletes an application from the database.
		/// </summary>
		/// <param name="appID">The ID of the application to delete.</param>
		/// <returns>True if delete succeeded, otherwise false.</returns>
		static public bool DeleteApplication(int appID)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.Delete, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddAppIDParameter(cmd, appID);

                        return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch(Exception e) 
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(DeleteApplication)}] : {e.Message}");
                 return false;
            }
        }

		/// <summary>
		/// Updates the status of an application.
		/// </summary>
		/// <param name="appID">The ID of the application to update.</param>
		/// <param name="appStatus">The new status value.</param>
		/// <returns>True if update succeeded, otherwise false.</returns>
		public static bool UpdateStatus(int appID , byte appStatus)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.UpdateStatus, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddAppIDAndStatus(cmd,appID,appStatus);

                        return Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch(Exception e)
            {
				Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(UpdateStatus)}] : {e.Message}");
                return false;
			}
		}

		/// <summary>
		/// Gets the active application ID for a specific person and application type.
		/// </summary>
		/// <param name="personID">The person's ID.</param>
		/// <param name="appTypeID">The application type ID.</param>
		/// <returns>The active application ID, or -1 if none exists.</returns>
		public static int GetActiveAppID(int personID , int appTypeID)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.GetActiveAppID, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddHasExistsRequest(cmd,personID,appTypeID);

                        return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);

					}
                }
            }
            catch( Exception e )
            {
				Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(GetActiveAppID)}] : {e.Message}");
				return -1;
			}
        }


		/// <summary>
		/// Checks if an application with a given ID exists in the database.
		/// </summary>
		/// <param name="applicationID">The application ID to check.</param>
		/// <returns>True if exists, otherwise false.</returns>
		public static bool IsExist(int applicationID)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.IsExist, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddAppIDParameter(cmd,applicationID);

                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch(Exception e)
            {
				Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(IsExist)}] : {e.Message}");
				return false;
			}
        }

        public static bool HasActiveApplication(int personID , int appTypeID)
        {
            return GetActiveAppID(personID, appTypeID) != -1;
        }

		/// <summary>
		/// Checks if a person already has an active application of a specific type.
		/// </summary>
		/// <param name="personID">The person's ID.</param>
		/// <param name="appTypeID">The application type ID.</param>
		/// <returns>True if an active application exists, otherwise false.</returns>
		public static int GetActiveAppIDForSpecificLicense(int personID , int appTypeID , int licenseID) 
        {
            try
            {
                using(SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(ApplicationProcedures.GetActiveAppIDForSpecificLicense, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationParameterBinder.AddGetAppIDForSpecificLicenseParameters(cmd,personID,appTypeID,licenseID);

                        return Convert.ToInt32(cmd.ExecuteScalar() ?? -1);
                    }
                }
            }
            catch( Exception e )
            {
				Debug.WriteLine($"Error in [{nameof(ApplicationDAL)}].[{nameof(GetActiveAppIDForSpecificLicense)}] : {e.Message}");
				return -1;
			}
        }

    }
}
