using System;
using MyDVLD_DTO;
using System.Data.SqlClient;
using System.Data;


namespace MyDVLD_DAL.ParameterBinder
{
    public static class ApplicationTypeParameterBinder
    {
        public static void AddInsertParameters(SqlCommand cmd, ApplicationTypeDTO dto)
        {
            cmd.Parameters.AddWithValue("@applicationTypeTitle", dto.Title);
            cmd.Parameters.AddWithValue("@applicationTypeFees", dto.Fees);
        }

        public static void AddUpdateParameters(SqlCommand cmd, ApplicationTypeDTO dto)
        {
            cmd.Parameters.AddWithValue("@applicationTypeID", dto.ID);
            cmd.Parameters.AddWithValue("@applicationTypeTitle", dto.Title);
            cmd.Parameters.AddWithValue("@applicationTypeFees", dto.Fees);
        }

        public static void AddApplicationTypeIDParameters(SqlCommand cmd, int ID)
        {
            cmd.Parameters.Add("@applicationTypeID",SqlDbType.Int).Value = ID;
        }

        public static void AddIDAndTitleParameters(SqlCommand cmd, int excludedID, string title)
        {
            cmd.Parameters.AddWithValue("@applicationTypeTitle", title);
            cmd.Parameters.AddWithValue("@applicationTypeID", excludedID);
        }

        public static void AddTitleParameters(SqlCommand cmd , string title)
        {
            cmd.Parameters.AddWithValue("@applicationTypeTitle", title);
        }
    }
}
