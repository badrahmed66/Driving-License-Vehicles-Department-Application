using MyDVLD_DAL.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BLL.Validation
{
    public static class UserValidator
    {
        public static bool IsPersonAlreadyUser(int? personID , string userName ,int?excludeUserID = null)
        {
            if ((personID is null && userName is null)|| (personID != null && userName != null)) return false;

            return UserDALValidator.IsExistsAsUser(personID, userName,excludeUserID);
        }

        public static bool VerifiyPlainTextWithHashedpassword(string plainTextPassword , string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainTextPassword, hashedPassword);
        }

        public static string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }
    }
}
