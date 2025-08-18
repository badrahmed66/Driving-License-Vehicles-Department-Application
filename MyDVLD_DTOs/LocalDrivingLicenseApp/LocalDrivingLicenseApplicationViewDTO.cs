using System;


namespace MyDVLD_DTO
{
    /// <summary>
    /// this model class will represent the View Of Local Driving License Application table in DAL
    /// use it in case Read from the database
    /// </summary>
    public class LocalDrivingLicenseApplicationViewDTO
    {
            public int LocalDrivingLicenseAppID { get; set; }
            public string LicenseClassTitle { get; set; }
            public string PersonNationalNoID { get; set; }
            public string PersonFullName { get; set; }
            public DateTime ApplicationDate { get; set; }
            public byte PassedTestCount { get; set; }
            public string ApplicationStatus { get; set; }
        
    }
}
