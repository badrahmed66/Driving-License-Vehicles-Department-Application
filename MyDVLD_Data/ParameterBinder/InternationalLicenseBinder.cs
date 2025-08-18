using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_Data.ParameterBinder
{
	public static  class InternationalLicenseBinder
	{
		// insert method parameters
		public static void Insert(SqlCommand cmd , InternationalLicenseDTO dto)
		{
			cmd.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
			cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
			cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
			cmd.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = dto.RelatedToLocalLicenseID;
			cmd.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
			cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;
		}

		public static void Update(SqlCommand cmd , InternationalLicenseDTO dto)
		{
			cmd.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = dto.InternationalLicenseID;
			cmd.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
			cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
			cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
			cmd.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = dto.RelatedToLocalLicenseID;
			cmd.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
			cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;
		}

	}
}
