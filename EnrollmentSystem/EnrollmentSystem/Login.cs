using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		public static bool ValidateInput(string usern, string passw)
		{
			//Check if usern and passw are both empty strings
			if (usern == "" || passw == "")
			{
				MessageBox.Show("Email or Password cannot be empty.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			//Check if email is at least 6 characters
			//Check if passw is at least 6 characters, consists of letters, numbers, or underscore
			if (usern.Length < 6 || passw.Length < 6)
			{
				MessageBox.Show("Email or Password must be at least 6 characters long.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (!passw.All(ch => char.IsLetterOrDigit(ch) || ch.Equals('_')))
			{
				MessageBox.Show("Password must consist of letters and numbers or underscore.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void button_login_Click(object sender, EventArgs e)
		{
			Account studAccount = new Account();
			string email = textBox_email.Text.Trim();
			string passWord = textBox_password.Text.Trim();

			//Check first if input is valid
			//if (!ValidateInput(email, passWord))
			//{
			//	return;
			//}

			if (studAccount.VerifyAccount("mllanderson@mymail.mapua.edu.ph", "2.0071e+009"))
			{
				//get user account
				var loggedInStud = studAccount.GetStudentInfo();

				MessageBox.Show("Login success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

				//Instantiate the MainMenu
				EnrollmentSystem ui_main = new EnrollmentSystem(loggedInStud);
				textBox_email.ResetText();
				textBox_password.ResetText();
				this.Hide();
				ui_main.FormClosing += FormClosing_MainWindow;
				ui_main.Show();
			}
			else
			{
				MessageBox.Show("Incorrect email or password entered.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox_password.Focus();
				textBox_password.SelectAll();
			}
		}

		private void FormClosing_MainWindow(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}
	}
}
