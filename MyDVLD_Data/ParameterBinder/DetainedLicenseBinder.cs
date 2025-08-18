using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.ParameterBinder
{
	public static class DetainedLicenseBinder
	{
		// parameters for insert method
		public static void InsertParameters(SqlCommand cmd ,DetainedLicenseDTO dto)
		{
			cmd.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;
			cmd.Parameters.Add("@DetainDate", SqlDbType.DateTime).Value = dto.DetainedDate;
			cmd.Parameters.Add("@Fees", SqlDbType.Decimal).Value = dto.Fees;
			cmd.Parameters.Add("@DetainByUserID", SqlDbType.Int).Value = dto.DetainedByUserID;
			cmd.Parameters.Add("@IsRelease", SqlDbType.Bit).Value = dto.IsReleased;
			cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = dto.ReleasedDate.HasValue ? (object)dto.ReleasedDate : DBNull.Value;
			cmd.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = dto.ReleasedByUserID > 0 ? (object)dto.ReleasedByUserID : DBNull.Value;
			cmd.Parameters.Add("@ReleaseApplicationID", SqlDbType.Int).Value = dto.ReleaseApplicationID > 0 ? (object)dto.ReleaseApplicationID : DBNull.Value;
		}

		// send the parameters form update method
		public static void UpdateParameters(SqlCommand cmd , DetainedLicenseDTO dto)
		{
			cmd.Parameters.Add("@DetainID", SqlDbType.Int).Value = dto.DetainID;
			cmd.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;
			cmd.Parameters.Add("@DetainDate", SqlDbType.DateTime).Value = dto.DetainedDate;
			cmd.Parameters.Add("@Fees", SqlDbType.Decimal).Value = dto.Fees;
			cmd.Parameters.Add("@DetainByUserID", SqlDbType.Int).Value = dto.DetainedByUserID;
			cmd.Parameters.Add("@IsRelease", SqlDbType.Bit).Value = dto.IsReleased;
			cmd.Parameters.Add("@ReleasDate", SqlDbType.DateTime).Value = (object)dto.ReleasedDate ?? DBNull.Value;
			cmd.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = (object)dto.ReleasedByUserID ?? DBNull.Value;
			cmd.Parameters.Add("@ReleasedApplicationID", SqlDbType.Int).Value = (object)dto.ReleaseApplicationID ?? DBNull.Value;
		}
	}
}
