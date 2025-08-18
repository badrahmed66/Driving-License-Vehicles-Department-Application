using MyDVLD_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace MyDVLD_DAL.ParameterBinder
{
    public static class TestTypeParameterBinder
    {
        public static void AddUpdateParameters(SqlCommand cmd, TestTypeDTO testType)
        {
            cmd.Parameters.AddWithValue("@testTypeID",testType.ID);
            cmd.Parameters.AddWithValue("@testTypeTitle", testType.Title);
            cmd.Parameters.AddWithValue("@testTypeDescription", testType.Description);
            cmd.Parameters.AddWithValue("@testTypeFees", testType.Fees);
        }

        public static void AddInsertParameters(SqlCommand cmd, TestTypeDTO testType)
        {
            cmd.Parameters.AddWithValue("@testTypeTitle", testType.Title);
            cmd.Parameters.AddWithValue("@testTypeDescription", testType.Description);
            cmd.Parameters.AddWithValue("@testTypeFees", testType.Fees);
        }

        public static void AddTestTypeIDParameters(SqlCommand cmd , int ID)
        {
            cmd.Parameters.Add("@testTypeID", SqlDbType.Int).Value = ID;
        }

        public static void AddTestTypeTitleParameters(SqlCommand cmd , string title)
        {
            cmd.Parameters.Add("@testTypeTitle",SqlDbType.NVarChar,250).Value = title;
        }

        public static void AddTestTypeTitleAndIDParameters(SqlCommand cmd , int ID , string title)
        {
            cmd.Parameters.Add("@testTypeID",SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@testTypeTitle",SqlDbType.NVarChar,250).Value = title;
        }

    }
}
