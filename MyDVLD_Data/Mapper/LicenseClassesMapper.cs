using MyDVLD_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace MyDVLD_DAL.Mapper
{
    public static class LicenseClassesMapper
    {
        public static LicenseClassesDTO ReadDTO(SqlDataReader reader)
        {
            return new LicenseClassesDTO()
            {
                LicenseID = Convert.ToInt32(reader["LicenseID"]),
                LicenseTitle = Convert.ToString(reader["LicenseTitle"]),
                LicenseFees = Convert.ToDecimal(reader["LicenseFees"]),
                LicenseDescription = Convert.ToString(reader["LicenseDescription"]),
                LicenseAllowMinAge = Convert.ToByte(reader["LicenseMinAllowAge"]),
                LicenseDefaultValidateLength = Convert.ToByte(reader["LicenseDefaultValidateLength"])
            };
        }
    }
}
