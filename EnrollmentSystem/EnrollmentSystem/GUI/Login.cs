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
			string email = textBox_email.Text;
			string passWord = textBox_password.Text;

			//if textbox is empty
			if (email == "" || passWord == "")
            {
                ErrorLogin errorLogin = new ErrorLogin();
                errorLogin.ShowDialog();
            }
            else
            {
                Account studAccount = new Account();

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
				else if (AdminAccount(email))
				{
					AdminForm adminAcc = new AdminForm();
					textBox_email.ResetText();
					textBox_password.ResetText();
					MessageBox.Show("Login success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					adminAcc.FormClosing += FormClosing_MainWindow;
					adminAcc.Show();

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


		public bool AdminAccount(string adminEmail)
		{
			string connectionString =
			ConfigurationManager.ConnectionStrings["EnrollmentDB"]?.ConnectionString;
			SqlConnection connection = new SqlConnection(connectionString);
			SqlDataAdapter adapter = new SqlDataAdapter("getPWAdmin", connection);
			adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand.Parameters.AddWithValue("@emailAdmin", adminEmail);
			DataTable pass = new DataTable();
			adapter.Fill(pass);
			connection.Close();

			if (pass.Rows.Count > 0)
			{
				if ((string)pass.Rows[0][0] == textBox_password.Text)
				{

					return true;
				}
				else
				{
					return false;
				}
			}
			else
				return false;
		}
	}
}
