using System;
using MyDVLD_DAL.Validation;

namespace MyDVLD_BLL.Validation
{
    public static  class ApplicationTypeValidator
    {
        public static  bool IsExistsExcludingItself(string title, int id)
        {
            return ApplicationTypeDALValidator.IsExistsExcludingItself(title, id);
        }

        public static bool IsExists(string title)
        {
            return ApplicationTypeDALValidator.IsExists(title);
        }
    }
}
