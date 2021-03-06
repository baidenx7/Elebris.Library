
using Caliburn.Micro;
using CaliburnWPFApp.EventModels;
using System.Threading;
using System.Threading.Tasks;

namespace CaliburnWPFApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {

        private StatViewModel _statVM;


        private readonly IEventAggregator _events;

        public ShellViewModel(IEventAggregator events, StatViewModel statVM)
        {
            _events = events;
            _statVM = statVM;

            _events.SubscribeOnPublishedThread(this);
            ActivateItemAsync(IoC.Get<LoginViewModel>()); //creates a NEW instance so info doesnt need to be manually wiped
        }

        public async Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            await ActivateItemAsync(_statVM);
        }
    }
}


//https://github.com/Caliburn-Micro/Caliburn.Micro/issues/697