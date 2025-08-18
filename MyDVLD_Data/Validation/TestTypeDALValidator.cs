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
    public static class TestTypeDALValidator
    {
        static public bool IsExists(string testTitle)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.IsExistsByTitle, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        TestTypeParameterBinder.AddTestTypeTitleParameters(cmd, testTitle);

                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(TestTypeDALValidator)}][{nameof(IsExists)}] : {e.Message}");
                return false;
            }
        }

        static public bool IsExiststExcludingItself(string title, int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(TestTypeProcedures.IsTestExistsExcludingItself, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        TestTypeParameterBinder.AddTestTypeTitleAndIDParameters(cmd, id, title);

                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(TestTypeDALValidator)}].[{nameof(IsExiststExcludingItself)}] : {e.Message}");
                return false;
            }
        }

    }
}
