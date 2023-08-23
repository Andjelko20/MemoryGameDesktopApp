using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
	public class Conn
	{
		private static SqlConnection _conn = null;

		public static SqlConnection conn
		{
			get
			{
				if (_conn == null)
					_conn = new SqlConnection(@"Data Source=(localdb)\server1; Initial Catalog = MemoryGameDatabase; Integrated Security = True");
				return _conn;
			}
		}

	}
}
