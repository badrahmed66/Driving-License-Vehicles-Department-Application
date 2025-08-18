using MyDVLD_DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DAL.Mapper
{
	public class DriverMapper
	{
		// to read driver DTO from SqlDataReader 
		public static DriverDTO ReadDTO(SqlDataReader r)
		{
			return new DriverDTO
			{
				DriverID = Convert.ToInt32(r["DriverID"]),
				PersonID = Convert.ToInt32(r["PersonID"]),
				CreatedByUserID = Convert.ToInt32(r["CreatedByUserID"]),
				CreatedDate = Convert.ToDateTime(r["CreatedDate"])
			};
		}
	}
}
