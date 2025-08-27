using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD_BLL;
using MyDVLD_Business.Interfaces;
using MyDVLD_Business.Behaviours;
using MyDVLD_DAL.Behaviours;
using MyDVLD_DAL.Interfaces;
using MyDVLD_Presentation.Users;
using System.Diagnostics;
using System.Threading;


namespace MyDVLD_Presentation
{
	internal static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (!EventLog.SourceExists("DVLD_App"))
			{
				EventLog.CreateEventSource("DVLD_App", "Application");
			}
			// pass the container object in the form login
			Application.Run(new FrmLoginScreen(new ServicesContainer()));
		}
	}
}
