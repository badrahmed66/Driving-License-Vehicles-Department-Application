using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.Mapper
{
	public static class DetainedLicenseMapper
	{
		// read Detained License DTO from Data Reader
		public static DetainedLicenseDTO GetDTO(SqlDataReader reader)
		{
			return new DetainedLicenseDTO()
			{
				DetainID = Convert.ToInt32(reader["DetainID"]),
				LicenseID = Convert.ToInt32(reader["LicenseID"]),
				DetainedDate = Convert.ToDateTime(reader["DetainDate"]),
				Fees = Convert.ToDecimal(reader["Fees"]),
				DetainedByUserID = Convert.ToInt32(reader["DetainByUserID"]),
				IsReleased = Convert.ToBoolean(reader["IsRelease"]),
				ReleasedDate = reader["ReleaseDate"] != DBNull.Value ? (DateTime?)reader["ReleaseDate"] : null,
				ReleasedByUserID = reader["ReleasedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["ReleasedByUserID"]) : -1,
				ReleaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ReleaseApplicationID"]) : -1
			};
		}
	}
}
