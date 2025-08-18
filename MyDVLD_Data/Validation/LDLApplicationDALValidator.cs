using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.Validation
{
    public static class LDLApplicationDALValidator
    {
        static public bool IsLDLAppIDForLicenseClassIDExists(int localAppID, int licenseClassID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.IsExists, con))
                    {
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.AddIsExists(cmd,localAppID ,licenseClassID);
                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(LocalDrivingLicenseApplicationDAL)}].[{nameof(IsLDLAppIDForLicenseClassIDExists)}] : {e.Message}");
                return false;
            }
        }
       
        static public bool IsPersonHasLocalAppForThisLicenseClass(int personID, int LicenseClassID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.IsPersonHasLocalAppForThisLicenseClassID, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        LDLApplicationParameterBinder.AddIsPersonHasLDLApplicationAlreadyParameters(cmd,personID,LicenseClassID);

                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(LocalDrivingLicenseApplicationDAL)}].[{nameof(IsPersonHasLocalAppForThisLicenseClass)}] : {e.Message}");
                return false;
            }
        }
        
        // count how many times the person took the test
        static public int TotalTrialsPerTest(int localID, int testTypeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.TotalTrailsPerTest, con))
                    {
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, localID, testTypeID);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int count))
                            return count;
                        else
                            return -1;

                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(LDLApplicationDALValidator)}].[{nameof(TotalTrialsPerTest)}] : {e.Message}");
                return 0;
            }
        }
        
        
        // check if local driving license application id has passed this test type
        static public bool HasPassedthisTestByLocalDrivingLicenseApplicationID(int lDLAppID, int testTypeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.HasPassedThisTest, con))
                    {
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd,lDLAppID,testTypeID);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(LDLApplicationDALValidator)}].[{nameof(HasActiveScheduleAppointmentForTestType)}] : {e.Message}");
                return false;
            }
        }

        static public bool HasTheTestBeenAttended(int LDLAppID, int TestTypeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.HasTheTestBeenAttended, con))
                    {
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, LDLAppID, TestTypeID);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(LDLApplicationDALValidator)}].[{nameof(HasTheTestBeenAttended)}] : {e.Message}");
                return false;
            }
        }

        static public bool HasActiveScheduleAppointmentForTestType(int lDLAppID, int testTypeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(LDLApplicationProcedures.HasActiveScheduleAppointmentForTestType, con))
                    {
						cmd.CommandType = CommandType.StoredProcedure;

						LDLApplicationParameterBinder.LDLAppIDAndTestTypeIDParameters(cmd, lDLAppID, testTypeID);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(LDLApplicationDALValidator)}].[{nameof(HasActiveScheduleAppointmentForTestType)}] : {e.Message}");
                return false;
            }
        }


    }
}
