using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL
{
	/// <summary>
	/// Provides methods to log user login activities into the database.
	/// </summary>
	public class LoginLogsData
	{
		/// <summary>
		/// The stored procedure responsible for inserting login activity logs into the database.
		/// </summary>
		private const string sp_AddLog = "AddLog";

		/// <summary>
		/// Inserts a new login log record into the database.
		/// </summary>
		/// <param name="userID">The ID of the user who performed the activity. Nullable.</param>
		/// <param name="userName">The username of the user who performed the activity.</param>
		/// <param name="activityType">The type of activity performed (e.g., login, logout).</param>
		/// <param name="details">Optional details about the activity.</param>
		public static void AddLog(int? userID, string userName, string activityType, string details = "")
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DataPath.ConnectionPath))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(sp_AddLog, con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						cmd.Parameters.AddWithValue("@userID", userID);
						cmd.Parameters.AddWithValue("@userName", userName);
						cmd.Parameters.AddWithValue("@activityType", activityType);
						cmd.Parameters.AddWithValue("@details", details);

						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Error in [LoginLogsData].[AddLog] : {e.Message}");
				Debug.WriteLine($"[Stack Trace] : {e.StackTrace}");
			}
		}
	}
}
