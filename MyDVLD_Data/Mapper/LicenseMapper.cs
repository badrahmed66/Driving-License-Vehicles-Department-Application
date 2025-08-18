using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.Mapper
{
	public static  class LicenseMapper
	{
		// read License DTO object from Sql Data Reader
		public static LicenseDTO ReadDTO(SqlDataReader r)
		{
			return new LicenseDTO
			{
				LicenseID = Convert.ToInt32(r["LicenseID"]),
				DriverID = Convert.ToInt32(r["DriverID"]),
				CreatedByUserID = Convert.ToInt32(r["CreatedByUserID"]),
				LicenseClassID = Convert.ToInt32(r["LicenseClassID"]),
				ApplicationID = Convert.ToInt32(r["ApplicationID"]),
				IssueDate = Convert.ToDateTime(r["IssueDate"]),
				ExpirationDate = Convert.ToDateTime(r["ExpirationDate"]),
				Notes = (r["Notes"]) != DBNull.Value ? Convert.ToString(r["Notes"]) : string.Empty , // nullable property
				PaidFees = Convert.ToDecimal(r["PaidFees"]),
				IsActive = Convert.ToBoolean(r["IsActive"]),
				IssueReason = (LicenseDTO.EnIssueReason)Convert.ToByte(r["IssueReason"]),

			};
		}
	}
}
