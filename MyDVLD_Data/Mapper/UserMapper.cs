using MyDVLD_DTO;
using MyDVLD_DTO.User;
using MyDVLD_DTOs.User;
using System;
using System.Data.SqlClient;


namespace MyDVLD_DAL.Mapper
{
    public static class UserMapper
    {
        public static UserLoginDTO GetLoginDTO(SqlDataReader reader)
        {
            return new UserLoginDTO()
            {
                UserID = Convert.ToInt32(reader["UserID"]),
                UserName = Convert.ToString(reader["UserName"]),
                HashedPassword = Convert.ToString(reader["HashedPassword"]),
                IsActive = Convert.ToBoolean(reader["IsActive"]),
                PersonID = Convert.ToInt32(reader["PersonID"]),
            };
        }

        public static UserDTO GetDTO(SqlDataReader reader)
        {
            return new UserDTO()
            {
                UserID = Convert.ToInt32(reader["UserID"]),
                UserName = Convert.ToString(reader["UserName"]),
                PersonID = Convert.ToInt32(reader["PersonID"]),
                IsActive = Convert.ToBoolean(reader["IsActive"]),
            };
        }

        public static UserViewDTO ReadDTOView(SqlDataReader reader)
        {
            return new UserViewDTO()
            {
                UserID = Convert.ToInt32(reader["UserID"]),
                PersonID = Convert.ToInt32(reader["PersonID"]),
                FullName = Convert.ToString(reader["FullName"]),
                UserName = Convert.ToString(reader["UserName"]),
                IsActive = Convert.ToBoolean(reader["IsActive"])
            };
        }

    }
}
