
using Caliburn.Micro;
using CaliburnWPFApp.EventModels;
using CaliburnWPFApp.Library.Models;
using System.Threading;
using System.Threading.Tasks;

namespace CaliburnWPFApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {

        private StatViewModel _statVM;
        ILoggedInUserModel _user;

        private readonly IEventAggregator _events;

        public bool IsLoggedIn
        {
            get
            {
                bool output = false;

                if (string.IsNullOrWhiteSpace(_user.Token) == false)
                {
                    output = true;
                }


                    return output;
            }
        }

        public ShellViewModel(IEventAggregator events, StatViewModel statVM, ILoggedInUserModel user)
        {
            _events = events;
            _statVM = statVM;
            _user = user;
            _events.SubscribeOnPublishedThread(this);
            ActivateItemAsync(IoC.Get<LoginViewModel>()); //creates a NEW instance so info doesnt need to be manually wiped
        }

        public async Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            await ActivateItemAsync(_statVM);
            NotifyOfPropertyChange(() => IsLoggedIn);
        }



        public void LogOut()
        {
            _user.ResetUserModel();
            ActivateItemAsync(IoC.Get<LoginViewModel>());
            NotifyOfPropertyChange(() => IsLoggedIn);
        }
    }
}


//https://github.com/Caliburn-Micro/Caliburn.Micro/issues/697