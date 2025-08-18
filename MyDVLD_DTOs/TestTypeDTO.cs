using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DTO
{
	/// <summary>
	/// Represents the type of a driving test (Vision, Theory, Practical, etc.).
	/// Contains metadata such as title, description, and associated fees.
	/// </summary>
	public class TestTypeDTO
    {
        public enum EnTestType { OnlyShow = 0 , Vision = 1 , Theory = 2 , Practical = 3};
        public int ID { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public decimal Fees {  get; set; }
    }
}
