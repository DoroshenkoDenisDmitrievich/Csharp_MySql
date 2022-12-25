using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconnect
{
	class DB
	{

		// MS Server : @"Data Source=USERCOMP\CSSQL05;Initial Catalog=forc;Integrated Security=True"

		//MySqlConnection ms = new MySqlConnection(@"Data Source=USERCOMP\CSSQL05;Initial Catalog=lesson;Integrated Security=True");


		// phpMyadmin :server=localhost;port=3306;username=root;password=root;database=itproger

		MySqlConnection ms = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=itproger");

		public void openConnection() 
		{
			if (ms.State == System.Data.ConnectionState.Closed)
			{
				ms.Open();
			}
		}

		public void closeConnection()
		{
			if (ms.State == System.Data.ConnectionState.Open)
			{
				ms.Close();
			}
		}

		public MySqlConnection GetConnection() 
		{
			return ms;		
		}

	}
}
