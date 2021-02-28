
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem
{
	public class LoginCredentialsChecker
	{
		private string EmailAddress;

		private string Password;

		private Login LoginUI;
		public LoginCredentialsChecker(Login loginUI)
		{
			LoginUI = loginUI;
			SubscribeToLoginButtonEvent();
		}

		private void SubscribeToLoginButtonEvent()
			=> LoginUI.LoginButtonClicked += ValidateUserLogin;

		private bool EmailAddressOrPasswordIsEmpty()
			=> EmailAddress == "" || Password == "" ;

		private void SetEmailAddress(string emailAddress)
			=> EmailAddress = emailAddress;

		private void SetPassword(string password)
			=> Password = password;

		private bool EmailAddressOrPasswordIsShorterThan(int len)
			=> EmailAddress.Length < 6 || Password.Length < 6;

		private bool PasswordConsistsOfLettersAndNumbersOrUnderScore()
			=> !Password.All(ch => char.IsLetterOrDigit(ch) || ch.Equals('_'));

		public void ValidateUserLogin(object sender, LoginButtonClickedEventArgs eventArgs)
		{
			SetEmailAddress(eventArgs.EmailAddress);
			SetPassword(eventArgs.Password);

			if (EmailAddressOrPasswordIsEmpty())
				LoginUI.EmptyFieldsError();
			else if (EmailAddressOrPasswordIsShorterThan(6))
				LoginUI.InputLengthError();
			else if (PasswordConsistsOfLettersAndNumbersOrUnderScore())
				LoginUI.PasswordRequirementsError();
		}
	}
}
