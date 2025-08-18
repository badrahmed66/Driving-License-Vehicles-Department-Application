using MyDVLD_DAL.Validation;
using System;


namespace MyDVLD_BLL.Validation
{
    public static class PersonValidator
    {
        public static bool IsPersonAlreadyExists(out string errorMessage, int? personID, string nationalNo)
        {
            errorMessage = "";
            return PersonDALValidator.IsExists(out errorMessage, personID, nationalNo);
        }
    }
}
