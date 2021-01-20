using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxElebris.Core.ViewModels
{
    public class ShellViewModel : MvxNavigationViewModel
    {
        //ShowDictionaryBindingCommand = new MvxAsyncCommand(async () =>
        //    await NavigationService.Navigate<DictionaryBindingViewModel>()); WHATTTT DOES THIS MEAN

        //https://github.com/MvvmCross/MvvmCross/blob/master/Projects/Playground/Playground.Core/ViewModels/Navigation/ChildViewModel.cs
        public IMvxAsyncCommand ShowNavCommand { get; private set; }

        public IMvxAsyncCommand ShowRootCommand { get; private set; }
        public ShellViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowNavCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<NavBarViewModel>());

        }
    }
}
