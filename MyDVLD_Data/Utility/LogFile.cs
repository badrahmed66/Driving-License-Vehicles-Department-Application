using MyDVLD_DAL;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MyDVLD_DAL.Utility
{
	public static class LogFile
	{
		public const string  eventLogSource = "DVLD_App";
		private const string FolderLogs = "Logs";

		public const string ErrorsFile = "ErrorLog.txt";
		public const string UsersLogin = "UsersLogin.txt";
		public const string ApplicationsInfo = "ApplicationsInfo.txt";
		public const string ApplicationTypes = "ApplicationTypes.txt";
		public const string Drivers = "Drivers.txt";
		public const string SystemInfo = "People.txt";
		public const string LicensesList = "LicenseList.txt";
		public const string TestAppointments = "TestAppointments.txt";

		public static void AddLogToFile(string className , string method , string message,string fileName)
		{
			try
			{
				string fullPath = Path.Combine(FolderLogs, fileName);


				if (!Directory.Exists(FolderLogs))
				{

					Directory.CreateDirectory(FolderLogs);
				}


				using(TextWriter ts = new StreamWriter(fullPath, true))
				{
					ts.WriteLine("=================================");
					ts.WriteLine(DateTime.Now);
					ts.WriteLine($"class : {className} - method : {method}");
					ts.WriteLine($"message : {message}");
					ts.WriteLine("=================================");

				}

			}
			catch (Exception e)
			{
				EventLog.WriteEntry(eventLogSource,$"class :{nameof(LogFile)} - method : {nameof(AddLogToFile)}\nmessage : failed to add exception in file log {e.Message}");
			}
		}

		
		public static string StringFormat(string className , string method , string message)
		{
			return $"class :{className} - method : {method} - message : {message}";
		}
	}
}
