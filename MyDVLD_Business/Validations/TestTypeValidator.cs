using System;
using MyDVLD_DAL.Validation;


namespace MyDVLD_BLL.Validation
{
    public static class TestTypeValidator
    {
        public static bool IsExists(string testTitle)
        {
            return TestTypeDALValidator.IsExists(testTitle);
        }

        public static bool IsTestTypeTitleExistsExcludingItself(string title, int id)
        {
            return TestTypeDALValidator.IsExiststExcludingItself(title, id);
        }
    }
}
