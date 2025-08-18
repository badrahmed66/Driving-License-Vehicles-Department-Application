using System;
using MyDVLD_DTOs;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using MyDVLD_DAL;

namespace MyDVLD_DAL.ParameterBinder
{
	public static class TestParameterBinder
	{
		public static void PassGetLastTestParameters(SqlCommand cmd , int personID , int licenseID , int testTypeID)
		{
			cmd.Parameters.Add("@personID",SqlDbType.Int).Value = personID;
			cmd.Parameters.Add("@licenseClass",SqlDbType.Int).Value = licenseID;
			cmd.Parameters.Add("@testTypeID",SqlDbType.Int).Value = testTypeID;
		}

		public static void PassTestID(SqlCommand cmd , int testID)
		{
			cmd.Parameters.Add("@TestID", SqlDbType.Int).Value = testID;
		}


		public static void PassTestDTOForInsert(SqlCommand cmd , TestDTO testDTO)
		{
			cmd.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = testDTO.TestAppointmentID;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = testDTO.CreatedByUserID;
			cmd.Parameters.Add("@TestResult", SqlDbType.Bit).Value = testDTO.IsPassed;
			cmd.Parameters.Add("Notes", SqlDbType.NVarChar).Value = (object)testDTO.Notes ?? null;
		}

		public static void PassTestDTOForUpdate(SqlCommand cmd , TestDTO testDTO)
		{
			cmd.Parameters.Add("@TestID", SqlDbType.Int).Value = testDTO.TestID;
			cmd.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = testDTO.TestAppointmentID;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = testDTO.CreatedByUserID;
			cmd.Parameters.Add("@TestResult", SqlDbType.Bit).Value = testDTO.IsPassed;
			cmd.Parameters.Add("Notes", SqlDbType.NVarChar).Value = (object)testDTO.Notes ?? null;
		}

		public static void PassLocalDrivingLicenseID(SqlCommand cmd , int localDrivingID)
		{
			cmd.Parameters.Add("@LocalDrivingLicenseID", SqlDbType.Int).Value = localDrivingID;
		}
	}
}
