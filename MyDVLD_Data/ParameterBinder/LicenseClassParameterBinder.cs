using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.ParameterBinder
{
    public static class LicenseClassParameterBinder
    {
        public static void AddFindParameters(SqlCommand cmd , int ?ID , string title)
        {
            cmd.Parameters.Add("@licenseID", SqlDbType.Int).Value =(object)ID ?? DBNull.Value;
            cmd.Parameters.Add("@licenseTitle", SqlDbType.NVarChar, 250).Value = (object)title??DBNull.Value;
        }
    }
}
