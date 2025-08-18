using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using MyDVLD_DAL.StoredProcedure;
using MyDVLD_DAL.ParameterBinder;

namespace MyDVLD_DAL.Validation
{
    public static class PersonDALValidator
    {
        static public bool IsExists(out string errorMessage, int? personID, string nationalNo)
        {
            errorMessage = "";

            if ((personID != null && nationalNo != null)||(personID is null && nationalNo is null))
            {
                errorMessage = "You Must pass only one of (persond ID ) or (natoinal no)";
                return false;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(PersonProcedures.IsExistsByIDOrNationalNo, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        PersonParameterBinder.AddFindParameters(cmd, personID, nationalNo);

                        return Convert.ToBoolean(cmd.ExecuteScalar() ?? false);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error in [{nameof(PersonDALValidator)}].[{nameof(IsExists)}] : {e.Message}");
                return false;
            }
        }

    }
}
