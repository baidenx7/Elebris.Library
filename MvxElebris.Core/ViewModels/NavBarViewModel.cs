using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core.ViewModels
{
   public class NavBarViewModel : MvxViewModel
    {

        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand NavigateLoginCommand { get; private set; }
        public IMvxAsyncCommand NavigateHomeCommand { get; private set; }
        public IMvxAsyncCommand NavigateStatCommand { get; private set; }
        public IMvxAsyncCommand NavigateAttributeCommand { get; private set; }
        public NavBarViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            //Create commands that will be used to navigate to the different views on the navbar

            NavigateLoginCommand = new MvxAsyncCommand(() => _navigationService.Navigate<LoginViewModel>());
            NavigateHomeCommand = new MvxAsyncCommand(() => _navigationService.Navigate<HomeViewModel>());

            NavigateStatCommand = new MvxAsyncCommand(() => _navigationService.Navigate<StatViewModel>());
            NavigateAttributeCommand = new MvxAsyncCommand(() => _navigationService.Navigate<AttributeViewModel>());
        }

    }
}
