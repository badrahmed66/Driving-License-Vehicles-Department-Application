using MyDVLD_DTO;
using MyDVLD_DTOs;
using System;
using System.Data;


namespace MyDVLD_Business.Interfaces
{
	public interface ITestService
	{
		// find the last test and get its information by person ID , License ID and test type
		TestDTO GetLastTestInfo(int personID, int licenseID, TestTypeDTO.EnTestType testType);

		// Retrieve all tests in the system
		DataTable RetrieveAll();

		// find a specific test by its ID
		TestDTO FindByID(int testID);

		// this method will Decide Add or Update Process 
		bool Save(TestDTO testDTO);
		// count the passed tests by local driving license application id
		byte CountPassedTests(int localDrivingLicenseID);

		// check if the local driving license app id passed all tests or not
		bool PassedAllTests(int localDrivingLicenseID);
	}
}
