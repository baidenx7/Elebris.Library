
using Caliburn.Micro;
using CaliburnWPFApp.EventModels;
using CaliburnWPFApp.Library.Models;
using System.Threading;
using System.Threading.Tasks;

namespace CaliburnWPFApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {

        ILoggedInUserModel _user;
        StatViewModel _statView;
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

        public ShellViewModel(IEventAggregator events, ILoggedInUserModel user,
            StatViewModel statView)
        {
            _events = events;
            _user = user;
            _events.SubscribeOnPublishedThread(this);
            _statView = statView; //stored this way so it isn't refreshed when the page is left. If i understand correctly IoC would pass in a new copy
            ActivateItemAsync(IoC.Get<LoginViewModel>()); //creates a NEW instance so info doesnt need to be manually wiped
        }

        public async Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            await ActivateItemAsync(_statView);
            NotifyOfPropertyChange(() => IsLoggedIn);
        }


        public void UserManagement()
        {
            ActivateItemAsync(IoC.Get<UserDisplayViewModel>());
        }
        public void LogOut()
        {
            _user.ResetUserModel();
            ActivateItemAsync(IoC.Get<LoginViewModel>());
            NotifyOfPropertyChange(() => IsLoggedIn);
        }
        public void ExitApplication()
        {
            TryCloseAsync();
        }

    }
}


//https://github.com/Caliburn-Micro/Caliburn.Micro/issues/697