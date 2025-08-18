using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using MyDVLD_DAL.ParameterBinder;
using MyDVLD_DAL.StoredProcedure;


namespace MyDVLD_DAL.Validation
{
    public static class ApplicationDALValidator
    {
        public static bool HasExistedRequest(int personID, int applicationTypeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(ApplicationProcedures.HasExistedRequest, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // input parameters
                        ApplicationParameterBinder.AddHasExistsRequest(cmd,personID, applicationTypeID);

                        // out put parameter
                        SqlParameter existsParam = new SqlParameter("@exists", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(existsParam);

                        cmd.ExecuteNonQuery();

                        return existsParam.Value != DBNull.Value && Convert.ToBoolean(existsParam.Value);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(ApplicationDALValidator)}].[{nameof(HasExistedRequest)}] : {e.Message}");
                return false;
            }
        }

    }
}
