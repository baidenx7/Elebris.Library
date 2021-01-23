using MvvmCross.ViewModels;

namespace MvxElebris.Core.ViewModels
{
    public class ShellViewModel : MvxViewModel
    {
        private NavBarViewModel navigationVM;
        private MvxViewModel displayVM;

        public NavBarViewModel NavigationVM { get => navigationVM; set => navigationVM = value; }
        public MvxViewModel DisplayVM { get => displayVM; set => displayVM = value; }
    }
}


