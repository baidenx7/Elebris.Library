using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {

        private string _userName;
        private string _password;


        public string UserName
        {
            get { return _userName; }
            set 
            {
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

      

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public bool CanLogIn(string userName, string password)
        {
            bool output = false;
            if(userName.Length > 0 && password.Length > 0)
            {
                output = true;
            }

            return output;
        }

        public void LogIn(string userName, string password)
        {
            Console.WriteLine();
        }
    }
}
