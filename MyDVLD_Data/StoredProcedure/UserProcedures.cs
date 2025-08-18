using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.StoredProcedure
{
    public static class UserProcedures
    {
		/// <summary>
		/// Retrieves a list of users with optional filters for user ID, username, active status, full name, or person ID.
		/// </summary>
		/// <param name="userID">User ID filter (optional)</param>
		/// <param name="userName">Username filter (optional)</param>
		/// <param name="isActive">Active status filter (optional)</param>
		/// <param name="fullName">Full name filter (optional)</param>
		/// <param name="personID">Person ID filter (optional)</param>
		public const string RetrieveWithFilter = "Users_RetrieveUsersListWithFilter";
		/// <summary>
		/// Retrieves user details based on optional filters.
		/// </summary>
		/// <param name="userID">User ID to filter by (optional)</param>
		/// <param name="userName">User name to filter by (optional)</param>
		/// <param name="userPersonID">Person ID associated with the user (optional)</param>

		public const string FindWithOptions = "Users_FindUserDetails";

		/// <summary>
		/// Retrieves user login details by username or user ID.
		/// </summary>
		/// <param name="userName">Username to search for (optional)</param>
		/// <param name="userID">User ID to search for (optional)</param>

		public const string FindForLogin = "Users_FindUserDetailsForLoginByUserName";

		/// <summary>
		/// Checks if a user exists by person ID or username, optionally excluding a specific user ID.
		/// </summary>
		/// <param name="personID">Person ID to check (optional)</param>
		/// <param name="userName">Username to check (optional)</param>
		/// <param name="excludeUserID">User ID to exclude from check (optional)</param>
		public const string IsExists = "Users_IsExistsAsUser";

		/// <summary>
		/// Adds a new user to the system.
		/// </summary>
		/// <param name="userName">Username of the new user</param>
		/// <param name="isActive">Indicates if the user is active</param>
		/// <param name="hashedPassword">Hashed password for the user</param>
		/// <param name="personID">Associated person ID</param>
		/// <returns>ID of the newly created user</returns>
		public const string Add = "Users_AddUser";

		/// <summary>
		/// Updates a user's details including username, hashed password, active status, and associated person ID.
		/// </summary>
		/// <param name="userID">ID of the user to update</param>
		/// <param name="userName">New username</param>
		/// <param name="isActive">New active status</param>
		/// <param name="hashedPassword">New hashed password</param>
		/// <param name="personID">Associated person ID</param>
		public const string Update = "Users_UpdateDetails";

		/// <summary>
		/// Deletes a user from the system.
		/// </summary>
		/// <param name="userID">ID of the user to delete</param>

		public const string Delete = "Users_DeleteUser";
    }
}
