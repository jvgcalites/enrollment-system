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
		public event EventHandler<LoginButtonClickedEventArgs> LoginButtonClicked;

		public Login()
		{
			InitializeComponent();
			new LoginCredentialsChecker(this);
			new LoginAccountVerifier(this);
		}

		private string GetEmailAddressFromTextBox()
			=> textBox_email.Text.Trim();

		private string GetPasswordFromTextBox()
			=> textBox_password.Text.Trim();

		private void button_login_Click(object sender, EventArgs e)
		{
			LoginButtonClicked?.Invoke(this,
				new LoginButtonClickedEventArgs
				{
					EmailAddress = GetEmailAddressFromTextBox(),
					Password = GetPasswordFromTextBox()
				});

			//Account studAccount = new Account();
			//string email = textBox_email.Text.Trim();
			//string passWord = textBox_password.Text.Trim();

			////Check first if input is valid
			////if (!ValidateInput(email, passWord))
			////{
			////	return;
			////}

			//if (studAccount.VerifyAccount("mllanderson@mymail.mapua.edu.ph", "2.0071e+009"))
			//{
			//	//get user account
			//	var loggedInStud = studAccount.GetStudentInfo();

			//	MessageBox.Show("Login success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

			//	//Instantiate the MainMenu
			//	EnrollmentSystem ui_main = new EnrollmentSystem(loggedInStud);
			//	textBox_email.ResetText();
			//	textBox_password.ResetText();
			//	this.Hide();
			//	ui_main.FormClosing += FormClosing_MainWindow;
			//	ui_main.Show();
			//}
			//else
			//{
			//	MessageBox.Show("Incorrect email or password entered.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	textBox_password.Focus();
			//	textBox_password.SelectAll();
			//}
		}
		public void LoginSuccess(Account studAccount)
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

		public void LoginFailed()
        {
			MessageBox.Show("Incorrect email or password entered.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			textBox_password.Focus();
			textBox_password.SelectAll();
		}

		private void FormClosing_MainWindow(object sender, FormClosingEventArgs e)
			=> this.Show();

		public void EmptyFieldsError()
			=> ShowErrorMessage("Email or Password cannot be empty.");

		public void InputLengthError()
			=> ShowErrorMessage("Email or Password must be at least 6 characters long.");

		public void PasswordRequirementsError()
			=> ShowErrorMessage("Password must consist of letters and numbers or underscore.");

		private void ShowErrorMessage(string message)
			=> MessageBox.Show(
				message,
				"Login",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
	}
}
