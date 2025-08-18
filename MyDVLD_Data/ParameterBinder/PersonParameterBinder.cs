using MyDVLD_DTO;
using MyDVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;


namespace MyDVLD_DAL.ParameterBinder
{
    public static class PersonParameterBinder
    {
        public static void AddInsertParameters(SqlCommand cmd, PersonDTO person)
        {
            cmd.Parameters.Add("@nationalNo", SqlDbType.NVarChar, 50).Value = person.NationalNo;
            cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 50).Value = person.FirstName;
            cmd.Parameters.Add("@secondName", SqlDbType.NVarChar, 50).Value = person.SecondName;

            cmd.Parameters.Add("@thirdName", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(person.ThirdName) ? (object)DBNull.Value : person.ThirdName;

            cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 50).Value = person.LastName;
            cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = person.Gender;
            cmd.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = person.DateOfBirth;
            cmd.Parameters.Add("@countryID", SqlDbType.Int).Value = person.CountryID;
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = person.Phone;

            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 150).Value = string.IsNullOrEmpty(person.Email) ? (object)DBNull.Value : person.Email;

            cmd.Parameters.Add("@image", SqlDbType.NVarChar, int.MaxValue).Value = string.IsNullOrEmpty(person.Image) ? (object)DBNull.Value : person.Image;

            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 150).Value = person.Address;
        }

        public static void AddUpdateParameters(SqlCommand cmd, PersonDTO person)
        {
            cmd.Parameters.Add("@PersonID",SqlDbType.Int).Value = person.PersonID;
            cmd.Parameters.Add("@nationalNo", SqlDbType.NVarChar, 50).Value = person.NationalNo;
            cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 50).Value = person.FirstName;
            cmd.Parameters.Add("@secondName", SqlDbType.NVarChar, 50).Value = person.SecondName;
            cmd.Parameters.Add("@thirdName", SqlDbType.NVarChar, 50).Value = person.ThirdName;
            cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 50).Value = person.LastName;
            cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = person.Gender;
            cmd.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = person.DateOfBirth;
            cmd.Parameters.Add("@countryID", SqlDbType.Int).Value = person.CountryID;
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = person.Phone;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 150).Value = person.Email;
            cmd.Parameters.Add("@image", SqlDbType.NVarChar, int.MaxValue).Value = person.Image;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 150).Value = person.Address;
        }

        public static void AddDeleteParameters(SqlCommand cmd , int ID)
        {
            cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;
        }

        public static void AddRetrieveParameters(SqlCommand cmd , PersonFilterDTO filter)
        {
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = (object)filter.PersonID ?? DBNull.Value;
            cmd.Parameters.Add("@nationalNo", SqlDbType.NVarChar, 50).Value = (object)filter.NationalNo ?? DBNull.Value;
            cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 50).Value = (object)filter.FirstName ?? DBNull.Value;
            cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 50).Value = (object)filter.LastName ?? DBNull.Value;
            cmd.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = (object)filter.Country ?? DBNull.Value;
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = (object)filter.Phone ?? DBNull.Value;
            cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = (object)filter.Gender ?? DBNull.Value;
        }

        public static void AddFindParameters(SqlCommand cmd , int?personID , string nationalNo)
        {
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = (object)personID ?? DBNull.Value;

            cmd.Parameters.Add("@nationalNo", SqlDbType.NVarChar, 150).Value = (object)nationalNo ?? DBNull.Value;
        }

    }
}
