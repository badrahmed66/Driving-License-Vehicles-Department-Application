using MyDVLD_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyDVLD_DAL.Mapper
{
    public static class CountryMapper
    {
        public static CountryDTO ReadDTO(SqlDataReader reader)
        {
            return new CountryDTO()
            {
                ID = Convert.ToInt32(reader["CountryID"]),
                Name = Convert.ToString(reader["CountryName"])
            };
        }

    }
}
