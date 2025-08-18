using MyDVLD_DTO;
using System;
using System.Data.SqlClient;


namespace MyDVLD_DAL.Mapper
{
    public static class LDLApplicationMapper
    {
        public static LocalDrivingLicenseApplicationDTO GetDTO(SqlDataReader reader)
        {
            return new LocalDrivingLicenseApplicationDTO()
            {
                LocalDrivingLicenseAppID = Convert.ToInt32(reader["LDLApplicationID"]),
                ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]),
            };
        }

        public static LocalDrivingLicenseApplicationViewDTO GetDTOView(SqlDataReader reader)
        {
            return new LocalDrivingLicenseApplicationViewDTO()
            {
                LocalDrivingLicenseAppID = Convert.ToInt32(reader["LDLApplicationID"]),
                LicenseClassTitle = Convert.ToString(reader["LicenseTitle"]),
                PersonNationalNoID = Convert.ToString(reader["NationalNo"]),
                PersonFullName = Convert.ToString(reader["FullName"]),
                ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]),
                ApplicationStatus = Convert.ToString(reader["Status"]),
                PassedTestCount = Convert.ToByte(reader["PassedTestCount"])

            };
        }
    }
}
