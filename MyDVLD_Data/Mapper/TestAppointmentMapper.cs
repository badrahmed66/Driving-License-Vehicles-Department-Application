using MyDVLD_DTO;
using MyDVLD_DTOs.TestAppointment;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.Mapper
{
	public static class TestAppointmentMapper
	{
		public static TestAppointmentDTO GetDTO(SqlDataReader reader)
		{
			return new TestAppointmentDTO()
			{
				TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]),
				TestTypeID = (TestTypeDTO.EnTestType)Convert.ToInt32(reader["TestTypeID"]),
				TestAppointmentDate = Convert.ToDateTime(reader["TestAppointmentDate"]),
				CreatedUserID = Convert.ToInt32(reader["CreatedByUserID"]),
				IsLocked = Convert.ToBoolean(reader["IsLocked"]),
				LDLApplicationID = Convert.ToInt32(reader["LDLApplicationID"]),
				PaidFees = Convert.ToDecimal(reader["PaidFees"]),
				RetakeTestApplicationID = reader["RetakeTestApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["RetakeTestApplicationID"]) : 0
			};
		}

		public static TestAppointmentViewDTO GetViewDTO(SqlDataReader reader)
		{
			return new TestAppointmentViewDTO()
			{
				TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]),
				LDLApplicationID = Convert.ToInt32(reader["LDLApplicationID"]),
				FullName = Convert.ToString(reader["FullName"]),
				TestAppointmentDate = Convert.ToDateTime(reader["TestAppointmentDate"]),
				PaidFees = Convert.ToDecimal(reader["PaidFees"]),
				IsLocked = Convert.ToBoolean(reader["IsLocked"]),
				TestTypeTitle = Convert.ToString(reader["TestTypeTitle"]),
				LicenseTitle = Convert.ToString(reader["LicenseTitle"])
			};
		}
	}
}
