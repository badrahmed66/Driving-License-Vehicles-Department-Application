using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;

namespace MyDVLD_DAL.Validation
{
    public static class ApplicationTypeDALValidator
    {
        static public bool IsExists(string title)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.IsExistsByTitle, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        ApplicationTypeParameterBinder.AddTitleParameters(cmd, title);
                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDALValidator)}].[{nameof(IsExists)}] : {e.Message}");
                return false;
            }
        }

        static public bool IsExistsExcludingItself(string title, int excludedID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ApplicationTypeProcedures.ISExistsExcludingItself, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        ApplicationTypeParameterBinder.AddIDAndTitleParameters(cmd, excludedID,title);

                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationTypeDALValidator)}].[{nameof(IsExistsExcludingItself)}] : {e.Message}");
                return false;
            }
        }
    }
}
