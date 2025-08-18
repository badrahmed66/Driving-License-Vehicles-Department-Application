using System;
using MyDVLD_DTO;
using System.Data.SqlClient;

namespace MyDVLD_DAL.Mapper
{
    public static class ApplicationMapper
    {

        public static ApplicationDTO GetDTO(SqlDataReader reader)
        {
            return new ApplicationDTO()
            {
                ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                PersonID = Convert.ToInt32(reader["PersonID"]),
                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]),
                ApplicationStatus = (ApplicationDTO.Status)reader["ApplicationStatus"],
                ApplicationPaidFees = Convert.ToDecimal(reader["ApplicationPaidFees"]),
                ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]),
                ApplicationLastStatusUpdateDate = Convert.ToDateTime(reader["ApplicationLastStatusDate"])
            };
        }
    }
}
