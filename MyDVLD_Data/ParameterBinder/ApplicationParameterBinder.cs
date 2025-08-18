using MyDVLD_DTO;
using MyDVLD_DTOs.Application;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace MyDVLD_DAL.ParameterBinder
{
    public static class ApplicationParameterBinder
    {
        public static void AddUpdateParameters(SqlCommand cmd, ApplicationDTO app)
        {
            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = app.ApplicationID;
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = app.PersonID;
            cmd.Parameters.Add("@createdByUserID", SqlDbType.Int).Value = app.CreatedByUserID;
            cmd.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = app.ApplicationTypeID;
            cmd.Parameters.Add("@paidFees", SqlDbType.Decimal, 18).Scale = 2;
            cmd.Parameters["@paidFees"].Value = app.ApplicationPaidFees;

            cmd.Parameters.Add("@lastStatusUpdateDate", SqlDbType.DateTime2).Value = app.ApplicationLastStatusUpdateDate;
            cmd.Parameters.Add("@appDate", SqlDbType.DateTime2).Value = app.ApplicationDate;
            cmd.Parameters.Add("@status", SqlDbType.TinyInt).Value = app.ApplicationStatus;
        }

        public static void AddInsertParameters(SqlCommand cmd, ApplicationDTO app)
        {
            cmd.Parameters.Add("@PersonID",SqlDbType.Int).Value = app.PersonID;
            cmd.Parameters.Add("@createdByUserID", SqlDbType.Int).Value = app.CreatedByUserID;
            cmd.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = app.ApplicationTypeID;
            cmd.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = app.ApplicationStatus;
            cmd.Parameters.Add("@ApplicationpaidFees", SqlDbType.Decimal, 18).Scale = 2;
            cmd.Parameters["@ApplicationpaidFees"].Value = app.ApplicationPaidFees;
            cmd.Parameters.Add("@ApplicationlastStatusDate", SqlDbType.DateTime2).Value = app.ApplicationLastStatusUpdateDate;
            cmd.Parameters.Add("@ApplicationDate", SqlDbType.DateTime2).Value = app.ApplicationDate;
        }

        public static void AddRetrieveParameters(SqlCommand cmd , ApplicationFilterDTO dto)
        {
            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = (object)dto.ApplicationID ?? DBNull.Value;
            cmd.Parameters.Add("@applicantPersonID", SqlDbType.Int).Value = (object)dto.ApplicantPersonID ?? DBNull.Value;
            cmd.Parameters.Add("@applicantNationalNo", SqlDbType.NVarChar, 50).Value = (object)dto.ApplicantNationalNo ?? DBNull.Value;
            cmd.Parameters.Add("@createdByUserID", SqlDbType.Int).Value = (object)dto.CreateByUserID ?? DBNull.Value;
            cmd.Parameters.Add("@userNationalNo", SqlDbType.NVarChar, 50).Value = (object)dto.CreateByUserNationalNo ?? DBNull.Value;
            cmd.Parameters.Add("@status", SqlDbType.TinyInt).Value = (object)dto.ApplicationStatus ?? DBNull.Value;
            cmd.Parameters.Add("@applicationTypeID", SqlDbType.Int).Value = (object)dto.ApplicatoinType ?? DBNull.Value;
        }

        public static void AddAppIDParameter(SqlCommand cmd , int appID)
        {
            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = (object)appID ?? DBNull.Value;
        }

        public static void AddHasExistsRequest(SqlCommand cmd,int personID , int applicationTypeID)
        {
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = personID;
            cmd.Parameters.Add("@applicationType", SqlDbType.Int).Value = applicationTypeID;
        }

        public static void AddAppIDAndStatus(SqlCommand cmd,int appID,byte status)
        {
            cmd.Parameters.Add("@applicationID",SqlDbType.Int).Value = appID;
            cmd.Parameters.Add("@newStatus", SqlDbType.Int).Value = status;
            cmd.Parameters.Add("@lastStatusDate", SqlDbType.DateTime).Value = DateTime.Now;
        }

        public static void AddGetAppIDForSpecificLicenseParameters(SqlCommand cmd,int personID , int appTypeID , int licenseID)
        {
            cmd.Parameters.Add("@personID", SqlDbType.Int).Value = personID;
            cmd.Parameters.Add("@appTypeID", SqlDbType.Int).Value = appTypeID;
            cmd.Parameters.Add("@licenseID",SqlDbType.Int).Value = licenseID;
        }

    }
}
