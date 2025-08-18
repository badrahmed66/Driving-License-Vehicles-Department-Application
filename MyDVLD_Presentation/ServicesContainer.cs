using MyDVLD_Business.Behaviours;
using MyDVLD_Business.Interfaces;
using MyDVLD_DAL.Behaviours;
using MyDVLD_DAL.Interfaces;
using System.Windows.Forms;


namespace MyDVLD_Presentation
{
	public class ServicesContainer
	{
		private ITestDAL _testDAL;

		private IDriverDAL _driverDAL;

		private ILicenseDAL _licenseDAL;

		private IDetainedLicenseDAL _detainedLicenseDAL;

		private IInternationalLicenseDAL _internationalLicenseDAL;
		public ServicesContainer()
		{
			// only Build the DAL interfaces all for one time
			_testDAL = new TestDAL();

			_driverDAL = new DriverDAL();

			_licenseDAL = new LicenseDAL();

			_detainedLicenseDAL = new DetainedLicenseDAL();
			_internationalLicenseDAL = new InternationalLicenseDAL();
		}

		// Factor method to Create The BLL Interfaces for each one
		public ITestService CreateTestService() => new TestService(_testDAL);

		public IDriverService CreateDriverService() => new DriverService(_driverDAL);

		public ILicenseService CreateLicneseService() => new LicenseService(_licenseDAL,CreateDriverService(),CreateDetainedLicenseService());

		public IDetainedLicenseService CreateDetainedLicenseService() => new DetainedLicenseService(_detainedLicenseDAL);

		public IInternationalLicenseService CreateInternationalLicenseService() => new InternationalLicenseService(_internationalLicenseDAL,CreateDriverService());
	}
}
