using System;
using MyDVLD_DTO;
using MyDVLD_DAL;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDVLD_DTO.User;
using MyDVLD_DTOs.User;
using MyDVLD_BLL.Validation;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Provides services for user authentication and session management.
	/// Handles login, logout, activity logging, and current user tracking.
	/// </summary>
	public static class UserAuthenticationService
	{
		/// <summary>
		/// Gets the currently logged-in user's information.
		/// </summary>
		public static UserDTO CurrentUserInfo { get; private set; }

		/// <summary>
		/// Logs a user activity in the system.
		/// </summary>
		/// <param name="userID">The ID of the user performing the activity.</param>
		/// <param name="userName">The username of the user performing the activity.</param>
		/// <param name="activityType">The type of activity (default is "Logged In").</param>
		/// <param name="details">Optional details about the activity.</param>
		public static void LogActivity(int userID, string userName, string activityType = "Logged In", string details = "")
		{
			LoginLogsData.AddLog(userID, userName, activityType, details);
		}

		/// <summary>
		/// Verifies the user's credentials.
		/// </summary>
		/// <param name="userName">The username to authenticate.</param>
		/// <param name="plainPassword">The plain text password to verify.</param>
		/// <returns>True if authentication is successful; otherwise, false.</returns>
		public static bool UserAuthentication(string userName, string plainPassword)
		{
			UserLoginDTO userLogin = UserDAL.FindUserLoginByName(userName);

			if (userLogin == null) return false;

			return UserValidator.VerifiyPlainTextWithHashedpassword(plainPassword, userLogin.HashedPassword) ?
					true : false;
		}

		/// <summary>
		/// Attempts to log in a user with the specified credentials.
		/// </summary>
		/// <param name="userName">The username of the user.</param>
		/// <param name="plainPassword">The plain text password of the user.</param>
		/// <param name="errorMessage">Returns an error message if login fails.</param>
		/// <returns>True if login is successful; otherwise, false.</returns>
		public static bool Login(string userName, string plainPassword, out string errorMessage)
		{
			errorMessage = "";

			CurrentUserInfo = null;

			if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(plainPassword))
			{
				errorMessage = "User name and Password Are Mandatory";
				return false;
			}

			UserLoginDTO userLogin = UserDAL.FindUserLoginByName(userName: userName);

			if (userLogin == null)
			{
				errorMessage = "invalid user name or password";
				return false;
			}

			if (!UserValidator.VerifiyPlainTextWithHashedpassword(plainPassword, userLogin.HashedPassword) || !userLogin.IsActive)
			{
				errorMessage = "Invalide password or the user is not acive connect with the Admin";
				return false;
			}

			CurrentUserInfo = UserService.FindUserDetails(userID: userLogin.UserID);

			LogActivity(userID: CurrentUserInfo.UserID, userName: CurrentUserInfo.UserName);

			return true;
		}

		/// <summary>
		/// Logs out the currently logged-in user.
		/// </summary>
		public static void Logout()
		{
			if (CurrentUserInfo != null)
			{
				LogActivity(CurrentUserInfo.UserID, CurrentUserInfo.UserName, "Logged out");
			}
			CurrentUserInfo = null;
		}

		/// <summary>
		/// Checks whether a user is currently logged in.
		/// </summary>
		/// <returns>True if a user is logged in; otherwise, false.</returns>
		public static bool IsLoggedIn()
		{
			return CurrentUserInfo != null;
		}

		/// <summary>
		/// Refreshes the current user data from the database.
		/// </summary>
		/// <param name="userName">The username of the user to refresh.</param>
		public static void RefreshCurrentUserData(string userName)
		{
			CurrentUserInfo = UserService.FindUserDetails(userName: userName);
		}
	}
}
