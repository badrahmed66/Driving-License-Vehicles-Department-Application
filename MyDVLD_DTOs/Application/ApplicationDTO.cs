using MyDVLD_DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Represents a general application in the system (e.g., driving license application).
	/// Stores information about the applicant, application type, status, 
	/// and metadata such as creation date, fees, and responsible user.
	/// </summary>
	public class ApplicationDTO
    {
        public enum Status : byte { New = 1, Cancel = 2, Complete = 3 }
  
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public int ApplicationTypeID { get; set; }
        public decimal ApplicationPaidFees { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime ApplicationLastStatusUpdateDate { get; set; }
        public Status ApplicationStatus { get; set; }

        // compositions
        public PersonDTO PersonInfoDTO { get; set; }
        public UserDTO UserInfoDTO { get; set; }
        public ApplicationTypeDTO ApplicationTypeInfoDTO { get; set; }
	    
	 }
}
