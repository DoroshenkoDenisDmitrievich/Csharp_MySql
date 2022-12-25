
namespace SQLconnect
{
	partial class registerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.login = new System.Windows.Forms.TextBox();
			this.button_register = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(382, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(-5, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "login:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(302, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 55);
			this.label1.TabIndex = 9;
			this.label1.Text = "Registration";
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.password.Location = new System.Drawing.Point(498, 199);
			this.password.Multiline = true;
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(290, 20);
			this.password.TabIndex = 8;
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(65, 200);
			this.login.Multiline = true;
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(290, 20);
			this.login.TabIndex = 7;
			// 
			// button_register
			// 
			this.button_register.BackColor = System.Drawing.Color.Silver;
			this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_register.Location = new System.Drawing.Point(65, 266);
			this.button_register.Name = "button_register";
			this.button_register.Size = new System.Drawing.Size(290, 53);
			this.button_register.TabIndex = 6;
			this.button_register.Text = "Зарегистрироваться";
			this.button_register.UseVisualStyleBackColor = false;
			this.button_register.Click += new System.EventHandler(this.button_register_Click);
			this.button_register.MouseEnter += new System.EventHandler(this.button_register_MouseEnter);
			this.button_register.MouseLeave += new System.EventHandler(this.button_register_MouseLeave);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(776, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "x";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(498, 266);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(290, 53);
			this.button2.TabIndex = 13;
			this.button2.Text = "Войти";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// registerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.password);
			this.Controls.Add(this.login);
			this.Controls.Add(this.button_register);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "registerForm";
			this.Text = "registerForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registerForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerForm_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.Button button_register;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}