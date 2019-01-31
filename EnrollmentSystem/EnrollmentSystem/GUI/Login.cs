using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EnrollmentSystem
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button_login_Click(object sender, EventArgs e)
		{
			//if textbox is empty
            if (textBox_email.Text == "" || textBox_password.Text == "")
            {
                ErrorLogin errorLogin = new ErrorLogin();
                errorLogin.ShowDialog();
            }
            else
            {
                Account studAccount = new Account();
                string email = textBox_email.Text;
                string passWord = textBox_password.Text;

                if (studAccount.VerifyAccount(email, passWord))
                {
                    //get user account
                    var loggedInStud = studAccount.GetStudentInfo();

					//show dialog box
                    SuccessfulLogin successful = new SuccessfulLogin();
                    successful.ShowDialog();
                    this.Hide();

                    //Instantiate the MainMenu
                    EnrollmentSystem ui_main = new EnrollmentSystem(loggedInStud);
                    textBox_email.ResetText();
                    textBox_password.ResetText();

                    ui_main.FormClosing += FormClosing_MainWindow;
                    ui_main.Show();
                }
                else
                {
					//show error login
                    ErrorLogin errorLogin = new ErrorLogin();
                    errorLogin.ShowDialog();
                }
            }
		}

		private void FormClosing_MainWindow(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}
	}
}
