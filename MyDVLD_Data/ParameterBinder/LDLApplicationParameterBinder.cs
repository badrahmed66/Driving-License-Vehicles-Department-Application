using MyDVLD_DTO;
using MyDVLD_DTOs.LocalDrivingLicenseApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.ParameterBinder
{
    public static class LDLApplicationParameterBinder
    {
        public static void AddInsertParameters(SqlCommand cmd, LocalDrivingLicenseApplicationDTO localApp)
        {
            cmd.Parameters.AddWithValue("@applicationID", localApp.ApplicationID);
            cmd.Parameters.AddWithValue("@licenseClassID", localApp.LicenseClassID);
        }

        public static void AddUpdateParameters(SqlCommand cmd, LocalDrivingLicenseApplicationDTO localApp)
        {
            cmd.Parameters.AddWithValue("@localApplicationID", localApp.LocalDrivingLicenseAppID);
            cmd.Parameters.AddWithValue("@applicationID", localApp.ApplicationID);
            cmd.Parameters.AddWithValue("@licenseClassID", localApp.LicenseClassID);
        }

        public static void AddRetrieveParameters(SqlCommand cmd , LDLApplicationFilterDTO filter)
        {
                cmd.Parameters.Add("@localAppID", SqlDbType.Int).Value = (object)filter.LocalDrivingLicenseID ?? DBNull.Value;

                cmd.Parameters.Add("@nationalNo", SqlDbType.NVarChar, 150).Value = (object)filter.NationalNo ?? DBNull.Value;

                cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 200).Value = (object)filter.FullName ?? DBNull.Value;

                cmd.Parameters.Add("@appStatus", SqlDbType.TinyInt).Value = (object)filter.Status ?? DBNull.Value;
        }

        public static void AddLDLApplicationIDParameters(SqlCommand cmd,int? lDLAppID = null , int? applicationID = null)
        {
            cmd.Parameters.Add("@localDrivingID", SqlDbType.Int).Value = (object)lDLAppID ??DBNull.Value;
            cmd.Parameters.Add("@applicationID", SqlDbType.Int).Value = (object)applicationID??DBNull.Value;
        }

        public static void AddIsExists(SqlCommand cmd,int localAppID,int licenseClassID)
        {
            cmd.Parameters.AddWithValue("@localDrivingLicenseID", localAppID);
            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
        }

        public static void AddIsPersonHasLDLApplicationAlreadyParameters(SqlCommand cmd , int personID , int LicenseClassID)
        {
            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@licenseClassID", LicenseClassID);
        }

        public static void LDLAppIDAndTestTypeIDParameters(SqlCommand cmd , int localID , int testTypeID)
        {
            cmd.Parameters.AddWithValue("@lDLAppID", localID);
            cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
        }




    }
}
