using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconnect
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string loginUser = loginField.Text;
			string passUser = passText.Text;
			
			DB db = new DB();

			DataTable table = new DataTable();
			
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			string sqlcom = "SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP";

			MySqlCommand command = new MySqlCommand(sqlcom,db.GetConnection());
			command.Parameters.Add("@ul",MySqlDbType.VarChar).Value=loginUser;
			command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;


			// Команда, которую будем выполнять
			adapter.SelectCommand=command;


			// Заполняепм данные в объект table 
			adapter.Fill(table);
			
			if (table.Rows.Count > 0)
				MessageBox.Show("Yes");
			else MessageBox.Show("no");


		}

		private void button2exitautorization_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
