using MyDVLD_DTOs;
using System;
using System.Data;
using System.Data.SqlClient;


namespace MyDVLD_DAL.ParameterBinder
{
	public static class LicenseParameterBinder
	{
		public static void Insert(SqlCommand cmd , LicenseDTO license)
		{
			cmd.Parameters.Add("@DriverID",SqlDbType.Int).Value = license.DriverID;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = license.CreatedByUserID;
			cmd.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = license.ApplicationID;
			cmd.Parameters.Add("LicenseClassID",SqlDbType.Int).Value = license.LicenseClassID;
			cmd.Parameters.Add("@IssueDate",SqlDbType.DateTime).Value = license.IssueDate;
			cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = license.ExpirationDate;
			cmd.Parameters.Add("@PaidFees", SqlDbType.Int).Value = license.PaidFees;
			cmd.Parameters.Add("@IsActive", SqlDbType.Int).Value = license.IsActive;
			cmd.Parameters.Add("@IssueReason", SqlDbType.TinyInt).Value = license.IssueReason;
			cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = (object)license.Notes ?? DBNull.Value;
		}

		public static void Update(SqlCommand cmd, LicenseDTO license)
		{
			cmd.Parameters.Add("@LicenseID", SqlDbType.Int).Value = license.LicenseID;
			cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = license.DriverID;
			cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = license.CreatedByUserID;
			cmd.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = license.ApplicationID;
			cmd.Parameters.Add("LicenseClassID", SqlDbType.Int).Value = license.LicenseClassID;
			cmd.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = license.IssueDate;
			cmd.Parameters.Add("@ExpirationDate", SqlDbType.Int).Value = license.ExpirationDate;
			cmd.Parameters.Add("@PaidFees", SqlDbType.Int).Value = license.PaidFees;
			cmd.Parameters.Add("@IsActive", SqlDbType.Int).Value = license.IsActive;
			cmd.Parameters.Add("@IssueReason", SqlDbType.TinyInt).Value = license.IssueReason;
			cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = (object)license.Notes ?? DBNull.Value;
		}
	}
}
