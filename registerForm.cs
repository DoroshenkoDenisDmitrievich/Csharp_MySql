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
	public partial class registerForm : Form
	{
		public registerForm()
		{   
			InitializeComponent();
//			this.button_register.Size = new Size(100,100);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button_register_Click(object sender, EventArgs e)
		{
			DB db = new DB();

			// phpMyAdmin: "INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", db.GetConnection()
			// MsSQLServer : "INSERT INTO `forc` (`a`, `b`) VALUES (@login, @pass)", db.GetConnection()


			MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", db.GetConnection());
			
			command.Parameters.Add("@login",MySqlDbType.VarChar).Value = login.Text;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
			
			db.openConnection();

			if (command.ExecuteNonQuery() == 1) MessageBox.Show("Accound was create");
			else MessageBox.Show("Accound was'n create");

			db.closeConnection();

		}


		Point lastPoint;

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();

			f1.Show();
		}
		
		private void button_register_MouseEnter(object sender, EventArgs e)
		{
			button_register.BackColor = Color.White;
		}

		private void button_register_MouseLeave(object sender, EventArgs e)
		{
			button_register.BackColor = Color.Silver;
		}


		
		private void registerForm_MouseMove(object sender, MouseEventArgs e)
		{

			//MouseButtons.Left - нажатие на левую клавишу мыши

			if (e.Button == MouseButtons.Left) 
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}

			

		}

		private void registerForm_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X,e.Y);
		}
	}
}
