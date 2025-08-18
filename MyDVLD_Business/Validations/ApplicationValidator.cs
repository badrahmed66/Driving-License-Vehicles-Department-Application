using MyDVLD_DAL.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BLL.Validations
{
    public static class ApplicationValidator
    {
         public static bool HasExistsRequest(int personID , int applicationTypeID)
        {
            return ApplicationDALValidator.HasExistedRequest(personID, applicationTypeID);
        }


    }
}
