using System;
using System.Data.SqlClient;
using MyDVLD_DTO;


namespace MyDVLD_DAL.Mapper
{
    public static class ApplicationTypeMapper
    {
        public static ApplicationTypeDTO GetDTO(SqlDataReader reader)
        {
            return new ApplicationTypeDTO()
            {
                ID = Convert.ToInt32(reader["ApplicationTypeID"]),
                Title = Convert.ToString(reader["ApplicationTypeTitle"]),
                Fees = Convert.ToDecimal(reader["ApplicationTypeFees"])
            };
        }
    }
}
