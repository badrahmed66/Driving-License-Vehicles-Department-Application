using MyDVLD_DTO;
using System;
using System.Data.SqlClient;


namespace MyDVLD_DAL.Mapper
{
    public static class TestTypeMapper
    {
        public static TestTypeDTO GetDTO(SqlDataReader reader)
        {
            return new TestTypeDTO()
            {
                ID = Convert.ToInt32(reader["TestTypeID"]),
                Title = Convert.ToString(reader["TestTypeTitle"]),
                Description = Convert.ToString(reader["TestTypeDescription"]),
                Fees = Convert.ToDecimal(reader["TestTypeFees"])
            };
        }
    }
}
