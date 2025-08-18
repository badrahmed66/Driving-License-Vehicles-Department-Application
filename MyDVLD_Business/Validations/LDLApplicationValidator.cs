using MyDVLD_DAL.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BLL.Validations
{
    public static class LDLApplicationValidator
    {
        public static bool VerifyLDLApplicationForLicenseClassIDExists(int localID , int licenseID)
        {
            return LDLApplicationDALValidator.IsLDLAppIDForLicenseClassIDExists(localID,licenseID);
        }

        public static bool VerifyDidPersonHaveLDLApplicationForThisLicenseClass(int personID , int licenseID)
        {
            return LDLApplicationDALValidator.IsPersonHasLocalAppForThisLicenseClass(personID,licenseID);
        }

        public static byte GetTotalOfTrialsPerTestType(int localID , int testTypeID)
        {
            return (byte)LDLApplicationDALValidator.TotalTrialsPerTest(localID,testTypeID);
        } 

        public static bool HasPersonPassedTest(int personID , int testTypeID)
        {
            return LDLApplicationDALValidator.HasPassedthisTestByLocalDrivingLicenseApplicationID(personID,testTypeID);
        }

        public static bool HasTestBeenAttended(int locolID , int testTypeID)
        {
            return LDLApplicationDALValidator.HasTheTestBeenAttended(locolID,testTypeID);
        }

        public static bool HasActiveScheduleAppointmentForTest(int localID , int testTypeID)
        {
            return LDLApplicationDALValidator.HasActiveScheduleAppointmentForTestType(localID,testTypeID);
        }

    }
}
