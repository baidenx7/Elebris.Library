using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core.ViewModels
{
    public class HomeViewModel : MvxNavigationViewModel
    {
        //ShowDictionaryBindingCommand = new MvxAsyncCommand(async () =>
        //    await NavigationService.Navigate<DictionaryBindingViewModel>()); WHATTTT DOES THIS MEAN

        //https://github.com/MvvmCross/MvvmCross/blob/master/Projects/Playground/Playground.Core/ViewModels/Navigation/ChildViewModel.cs
        public IMvxAsyncCommand ShowNavCommand { get; private set; }

        public HomeViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            //ShowNavCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<NavBarViewModel>()); //change to a show/hide for the navbar

        }

    }
}

