using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using MyDVLD_DTOs.TestAppointment;

namespace MyDVLD_DAL.ParameterBinder
{
	public static class TestAppointmentBinder
	{
		public static void PassFindByIDParameters(SqlCommand cmd , int testAppointmentID)
		{
			cmd.Parameters.Add("@testAppointmentID", SqlDbType.Int).Value = testAppointmentID;
		}

		public static void PassTestTypeIDAndLocalDrivingIDParameters(SqlCommand cmd , int testTypeID , int localID)
		{
			cmd.Parameters.Add("@TestTypeID",SqlDbType.Int).Value = testTypeID;
			cmd.Parameters.Add("@@LDLApplicationID", SqlDbType.Int).Value = localID;
		}

		public static void PassInsertParameters(SqlCommand cmd , TestAppointmentDTO dto)
		{
			cmd.Parameters.Add("@TestTypeID",SqlDbType.Int).Value = dto.TestTypeID;
			cmd.Parameters.Add("@TestAppointmentDate", SqlDbType.DateTime).Value = dto.TestAppointmentDate;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedUserID;
			cmd.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = dto.IsLocked;
			cmd.Parameters.Add("@LDLApplicationID", SqlDbType.Int).Value = dto.LDLApplicationID;
			cmd.Parameters.Add("@PaidFees",SqlDbType.Decimal).Value = dto.PaidFees;
			cmd.Parameters.Add("@RetakeTestApplicationID", SqlDbType.Int).Value = dto.RetakeTestApplicationID > 0 ? (object)dto.RetakeTestApplicationID: DBNull.Value;
		}

		public static void PassUpdateParameters(SqlCommand cmd, TestAppointmentDTO dto)
		{
			cmd.Parameters.Add("@TestTypeAppointmentID", SqlDbType.Int).Value = dto.TestAppointmentID;
			cmd.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = dto.TestTypeID;
			cmd.Parameters.Add("@TestAppointmentDate", SqlDbType.DateTime).Value = dto.TestAppointmentDate;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedUserID;
			cmd.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = dto.IsLocked;
			cmd.Parameters.Add("@LDLApplicationID", SqlDbType.Int).Value = dto.LDLApplicationID;
			cmd.Parameters.Add("@PaidFees", SqlDbType.Decimal).Value = dto.PaidFees;
			cmd.Parameters.Add("@RetakeTestApplicationID", SqlDbType.Int).Value = dto.RetakeTestApplicationID > 0 ? (object)dto.RetakeTestApplicationID : DBNull.Value;
		}



	}
}
