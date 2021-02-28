using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem
{
    public class LoginAccountVerifier
    {
        private LoginButtonClickedEventArgs UserInput;

		private Login LoginUI;

		private Account Account = new Account();

		public LoginAccountVerifier(Login loginUI)
		{
			LoginUI = loginUI;
			SubscribeToLoginButtonEvent();
		}

		private void SubscribeToLoginButtonEvent()
			=> LoginUI.LoginButtonClicked += VerifyAccount;


		public void VerifyAccount(object sender, LoginButtonClickedEventArgs eventArgs)
		{
			bool isVerified = Account.VerifyAccount(eventArgs.EmailAddress, eventArgs.Password);
			if (isVerified)
				LoginUI.LoginSuccess(Account);
			else
				LoginUI.LoginFailed();
		}

	}
}
