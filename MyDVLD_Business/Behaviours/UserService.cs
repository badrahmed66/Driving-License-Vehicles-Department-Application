using System;
using MyDVLD_DAL;
using System.Collections.Generic;
using MyDVLD_DTO;
using MyDVLD_DTO.User;
using MyDVLD_DTOs.User;
using MyDVLD_BLL.Validation;
using MyDVLD_DAL.Utility;

namespace MyDVLD_BLL
{

	/// <summary>
	/// Business Logic Layer (BLL) service for managing users.
	/// Acts as a middle layer between DAL and UI:
	/// - Handles validations
	/// - Applies password hashing
	/// - Provides user-friendly status messages
	/// </summary>
	public class UserService
	{
		private readonly UserDTO _user;

		public UserService(UserDTO user)
		{
			_user = user ?? throw new ArgumentNullException(nameof(user));
		}

		/// <summary>
		/// Retrieves all users with optional filtering.
		/// </summary>
		public static List<UserViewDTO> RetrieveAllUsers(string filterColumn = "", string filterValue = "")
		{
			return UserDAL.RetrieveWithFilter(filterColumn, filterValue);
		}

		/// <summary>
		/// Finds user login details by username or userID (used for authentication).
		/// </summary>
		private UserLoginDTO FindUserLoginDetails(string userName = null, int? userID = null)
		{
			if ((userID == null && userName == null) || (userID != null && userName != null)) return null;
			return UserDAL.FindUserLoginByName(userName, userID);
		}

		/// <summary>
		/// Retrieves detailed user information (including linked person info).
		/// </summary>
		public static UserDTO FindUserDetails(int? userID = null, string userName = null, int? userPersonID = null)
		{
			if ((userID == null && userPersonID == null && userName == null)
					|| (userID != null && userPersonID != null && userName != null))
				return null;

			UserDTO userInfo = UserDAL.FindByUserIDorNameorPersonIDorNationalNo(userID, userName, userPersonID);

			if (userInfo == null) return null;

			userInfo.PersonInfoDTO = PersonService.FindPersonByIDOrNationalNo(out string message, userInfo.PersonID, null);

			return userInfo;
		}

		/// <summary>
		/// Maps a standard UserDTO into a UserLoginDTO with hashed password.
		/// </summary>
		private UserLoginDTO MapToUserLogin(UserDTO user, string hashed)
		{
			return new UserLoginDTO()
			{
				UserID = user.UserID,
				UserName = user.UserName,
				PersonID = user.PersonID,
				IsActive = user.IsActive,
				HashedPassword = hashed
			};
		}

		/// <summary>
		/// Inserts a new user into the system after validating and hashing password.
		/// Returns success/failure with message.
		/// </summary>
		public bool Insert(string plainPassword, out string errorMessage)
		{
			errorMessage = "";

			if (!PersonValidator.IsPersonAlreadyExists(out errorMessage, _user.PersonID, null))
			{
				return false;
			}

			if (UserValidator.IsPersonAlreadyUser(personID: _user.PersonID, userName: null))
			{
				errorMessage = "This Person Already A user in the system";
				return false;
			}

			// make hash password method then map normal user to login user then insert him
			string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);
			UserLoginDTO userLogin = MapToUserLogin(_user, hashedPassword);

			int id = UserDAL.Insert(userLogin);

			if (id > 0)
			{
				errorMessage = "User Saved Successfuly";
				_user.UserID = id;
				LogFile.AddLogToFile(nameof(UserService), nameof(Insert), $"New User ID {id} has Added in the system", LogFile.SystemInfo);
				return true;
			}
			else
			{
				errorMessage = "an error occured during Inserting the user";
				return false;
			}
		}

		/// <summary>
		/// Updates an existing user (username or password if changed).
		/// Returns success/failure with message.
		/// </summary>
		public bool Update(string plainPassword, out string msg)
		{
			msg = "";

			if (_user.UserID <= 0)
			{
				msg = "Invalid user ID";
				return false;
			}

			UserLoginDTO originUser = FindUserLoginDetails(userID: _user.UserID);
			if (originUser == null)
			{
				msg = "invalid user";
				return false;
			}

			bool passwordChanged = !string.IsNullOrWhiteSpace(plainPassword) &&
					!UserValidator.VerifiyPlainTextWithHashedpassword(plainPassword, originUser.HashedPassword);

			if (passwordChanged)
			{
				originUser.HashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);
			}

			if (originUser.UserName != _user.UserName)
			{
				if (UserValidator.IsPersonAlreadyUser(_user.PersonID, _user.UserName, _user.UserID))
				{
					msg = "This User Name Took By another user";
					return false;
				}
			}
			originUser = MapToUserLogin(_user, originUser.HashedPassword);
			bool updated = UserDAL.Update(originUser);

			msg = updated ? "User Updated Successfuly" : "An Error occured while Updating";
			LogFile.AddLogToFile(nameof(UserService), nameof(Update), $"User ID {_user.UserID} has updated", LogFile.SystemInfo);
			return updated;
		}

		/// <summary>
		/// Deletes a user by ID after validation.
		/// Returns success/failure with message.
		/// </summary>
		public static bool Delete(int userID, out string errorMessage)
		{
			errorMessage = "";
			if (userID <= 0)
			{
				errorMessage = "Invalid User ID";
				return false;
			}
			if (UserDAL.Delete(userID))
			{
				errorMessage = "User Deleted Successfuly";
				LogFile.AddLogToFile(nameof(UserService), nameof(Delete), $"User ID {userID} has Deleted", LogFile.SystemInfo);
				return true;
			}
			else
			{
				errorMessage = "error occured during deleting the user";
				return false;
			}
		}
	}
}
