using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTOs.Application
{
	/// <summary>
	/// Represents a set of optional filtering criteria 
	/// for retrieving or searching application records.
	/// Each property can be null, allowing flexible filtering.
	/// </summary>
	public class ApplicationFilterDTO
    {

        public int? ApplicationID {  get; set; }
        public int? ApplicantPersonID {  get; set; }
        public string ApplicantNationalNo {  get; set; }
        public int? CreateByUserID {  get; set; }
        public string CreateByUserNationalNo {  get; set; }
        public int? ApplicatoinType {  get; set; }
        public byte? ApplicationStatus {  get; set; }
    }
}
