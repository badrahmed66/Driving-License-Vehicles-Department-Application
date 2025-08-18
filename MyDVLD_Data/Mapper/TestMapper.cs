using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.Mapper
{
	public static class TestMapper
	{
		public static TestDTO GetDTO(SqlDataReader reader)
		{
			return new TestDTO()
			{
				TestID = Convert.ToInt32(reader["TestID"]),
				TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]),
				CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
				IsPassed = Convert.ToBoolean(reader["TestResult"]),
				Notes = Convert.ToString(reader["Notes"]),
			};
		}
	}
}
