
namespace SQLconnect
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.loginField = new System.Windows.Forms.TextBox();
			this.passText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2exitautorization = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(277, 268);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(290, 53);
			this.button1.TabIndex = 0;
			this.button1.Text = "Вход";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// loginField
			// 
			this.loginField.Location = new System.Drawing.Point(277, 147);
			this.loginField.Multiline = true;
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(290, 20);
			this.loginField.TabIndex = 1;
			// 
			// passText
			// 
			this.passText.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.passText.Location = new System.Drawing.Point(277, 200);
			this.passText.Multiline = true;
			this.passText.Name = "passText";
			this.passText.Size = new System.Drawing.Size(290, 20);
			this.passText.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(287, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 55);
			this.label1.TabIndex = 3;
			this.label1.Text = "Autorization";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(168, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "login:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(167, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "password:";
			// 
			// button2exitautorization
			// 
			this.button2exitautorization.BackColor = System.Drawing.Color.Red;
			this.button2exitautorization.Location = new System.Drawing.Point(765, -1);
			this.button2exitautorization.Name = "button2exitautorization";
			this.button2exitautorization.Size = new System.Drawing.Size(23, 23);
			this.button2exitautorization.TabIndex = 6;
			this.button2exitautorization.Text = "X";
			this.button2exitautorization.UseVisualStyleBackColor = false;
			this.button2exitautorization.Click += new System.EventHandler(this.button2exitautorization_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2exitautorization);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passText);
			this.Controls.Add(this.loginField);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2exitautorization;
	}
}