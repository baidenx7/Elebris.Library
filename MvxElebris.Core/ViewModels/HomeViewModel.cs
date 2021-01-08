using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {


        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand NavigateStatCommand { get; private set; }
        public HomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateStatCommand = new MvxAsyncCommand(() => _navigationService.Navigate<StatViewModel>());
        }
    }
}
