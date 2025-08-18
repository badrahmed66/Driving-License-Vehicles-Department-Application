using MyDVLD_DTO.User;
using MyDVLD_DTOs.User;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyDVLD_DAL.ParameterBinder
{
    public static class UserParameterBinder
    {
        public static void AddInsertParameters(SqlCommand cmd, UserLoginDTO dto)
        {
            cmd.Parameters.AddWithValue("@userName", dto.UserName);
            cmd.Parameters.AddWithValue("@isActive", dto.IsActive);
            cmd.Parameters.AddWithValue("@hashedPassword", dto.HashedPassword);
            cmd.Parameters.AddWithValue("@personID", dto.PersonID);
        }
        
        public static void AddUpdateParameters(SqlCommand cmd, UserLoginDTO dto)
        {
            cmd.Parameters.Add("@userID", SqlDbType.Int).Value = dto.UserID;
            cmd.Parameters.Add("@userName", SqlDbType.NVarChar,50).Value = dto.UserName;
            cmd.Parameters.Add("@isActive",SqlDbType.Bit).Value = dto.IsActive;
            cmd.Parameters.Add("@hashedPassword", SqlDbType.NVarChar).Value = dto.HashedPassword;
            cmd.Parameters.Add("@personID",SqlDbType.Int ).Value = dto.PersonID;
        }

        public static void AddRetrieveParameters(SqlCommand cmd , UserFilterDTO filterDTO)
        {
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = (object)filterDTO.PersonID ?? DBNull.Value;

            cmd.Parameters.Add("@userID", SqlDbType.Int).Value = (object)filterDTO.UserID ?? DBNull.Value;

            cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 150).Value = (object)filterDTO.UserName ?? DBNull.Value;

            cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 150).Value = (object)filterDTO.FullName ?? DBNull.Value;

            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = (object)filterDTO.IsActive ?? DBNull.Value;
        }

        public static void AddUserNameparameters(SqlCommand cmd , string userName = null , int?userID = null)
        {
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@userID", userID);
        }

        public static void AddFindParameters(SqlCommand cmd ,int? userID , int ? userPersonID,string userName )
        {
            cmd.Parameters.Add("@userID", SqlDbType.Int).Value = (object)userID ?? DBNull.Value;

            cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = (object)userName ?? DBNull.Value;

            cmd.Parameters.Add("@userPersonID", SqlDbType.Int).Value = (object)userPersonID ?? DBNull.Value;

        }

        public static void AddUserIDParameters(SqlCommand cmd , int userID)
        {
            cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
        }

        public static void AddIsExistsParameters(SqlCommand cmd , string userName = "", int? personID = null,int?excludeUserID = null)
        {
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = (object)personID ?? DBNull.Value;
            cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = (object)userName ?? DBNull.Value;
            cmd.Parameters.Add("@excludeUserID",SqlDbType.Int).Value = (object)excludeUserID ?? DBNull.Value;
        }
    }
}
