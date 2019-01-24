namespace EnrollmentSystem
{
	partial class Login
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
			this.button_login = new System.Windows.Forms.Button();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.textBox_email = new System.Windows.Forms.TextBox();
			this.label_password = new System.Windows.Forms.Label();
			this.label_email = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(116, 121);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(75, 23);
			this.button_login.TabIndex = 14;
			this.button_login.Text = "Login";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.Click += new System.EventHandler(this.button_login_Click);
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(103, 78);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(141, 20);
			this.textBox_password.TabIndex = 13;
			// 
			// textBox_email
			// 
			this.textBox_email.Location = new System.Drawing.Point(103, 46);
			this.textBox_email.Name = "textBox_email";
			this.textBox_email.Size = new System.Drawing.Size(141, 20);
			this.textBox_email.TabIndex = 12;
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(38, 78);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(53, 13);
			this.label_password.TabIndex = 11;
			this.label_password.Text = "Password";
			// 
			// label_email
			// 
			this.label_email.AutoSize = true;
			this.label_email.Location = new System.Drawing.Point(38, 49);
			this.label_email.Name = "label_email";
			this.label_email.Size = new System.Drawing.Size(32, 13);
			this.label_email.TabIndex = 10;
			this.label_email.Text = "Email";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 174);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_email);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_email);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_login;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.TextBox textBox_email;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.Label label_email;
	}
}