using System;
using MyDVLD_DTO;
using MyDVLD_DTO.Person;
using System.Data.SqlClient;


namespace MyDVLD_DAL.Mapper
{
    public static class PersonMapper
    {
        public static PersonDTO GetDTO(SqlDataReader reader)
        {
            return new PersonDTO()
            {
                PersonID = Convert.ToInt32(reader["PersonID"]),
                NationalNo = Convert.ToString(reader["NationalNo"]),
                FirstName = Convert.ToString(reader["FirstName"]),
                SecondName = Convert.ToString(reader["SecondName"]),
                ThirdName = Convert.ToString(reader["ThirdName"]),
                LastName = Convert.ToString(reader["LastName"]),
                Gender = Convert.ToChar(reader["Gender"]),
                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                CountryID = Convert.ToInt32(reader["People_CountryID"]),
                Phone = Convert.ToString(reader["Phone"]),
                Email = Convert.ToString(reader["Email"]),
                Image = Convert.ToString(reader["Image"]),
                Address = Convert.ToString(reader["Address"]),
                CountryInfo = new CountryDTO()
                {
                    ID = Convert.ToInt32(reader["C_CountryID"]),
                    Name = Convert.ToString(reader["C_CountryName"])
                }
            };
        }

        public static PersonViewDTO GetViewDTO(SqlDataReader reader)
        {
            return new PersonViewDTO()
            {
                PersonID = Convert.ToInt32(reader["PersonID"]),
                NationalNo = Convert.ToString(reader["NationalNo"]),
                FullName = Convert.ToString(reader["FullName"]),
                Gender = Convert.ToChar(reader["Gender"]),
                Phone = Convert.ToString(reader["Phone"]),
                Email = reader["Email"] is DBNull ? null : Convert.ToString(reader["Email"]),
                Address = Convert.ToString(reader["Address"]),
                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                CountryName = Convert.ToString(reader["CountryName"]),
            };
        }

    }
}
