using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_Data.Mapper
{
	public static class InternationalLicenseMapper
	{
		// get DTO from Sql Data Reader
		public static InternationalLicenseDTO GetDTO(SqlDataReader r)
		{
			return new InternationalLicenseDTO()
			{
				InternationalLicenseID = Convert.ToInt32(r["InternationalLicenseID"]),
				IssueDate = Convert.ToDateTime(r["IssueDate"]),
				IsActive = Convert.ToBoolean(r["IsActive"]),
				DriverID = Convert.ToInt32(r["DriverID"]),
				CreatedByUserID = Convert.ToInt32(r["CreatedByUserID"]),
				RelatedToLocalLicenseID = Convert.ToInt32(r["IssuedUsingLocalLicenseID"]),
				ApplicationID = Convert.ToInt32(r["ApplicationID"]),
				ExpirationDate = Convert.ToDateTime(r["ExpirationDate"])
			};
		}


	}
}
