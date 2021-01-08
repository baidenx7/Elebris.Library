using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core.ViewModels
{
    public class ShellViewModel : MvxViewModel
    {

        private LoginViewModel _loginVM;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVM = loginVM;
            //activate homeVM mvx style
        }
    }
}
