
using Caliburn.Micro;
using System.Threading.Tasks;

namespace CaliburnWPFApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        private LoginViewModel _loginVM;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVM = loginVM;
        }

        //public async Task SetUp()
        //{

        //    await ActiveItemAsync(_loginVM);
        //}


    }
}


//https://github.com/Caliburn-Micro/Caliburn.Micro/issues/697