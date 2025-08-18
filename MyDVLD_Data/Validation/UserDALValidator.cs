using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;

namespace MyDVLD_DAL.Validation
{
    public static class UserDALValidator
    {
        static public bool IsExistsAsUser(int? personID = null , string userName = "" , int ? excludeUserID = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(UserProcedures.IsExists, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        UserParameterBinder.AddIsExistsParameters(cmd, userName, personID , excludeUserID);

                        return Convert.ToBoolean(cmd.ExecuteScalar()??false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(UserDALValidator)}].[{nameof(IsExistsAsUser)}] : {e.Message}");
                return false;
            }
        }

    }
}
