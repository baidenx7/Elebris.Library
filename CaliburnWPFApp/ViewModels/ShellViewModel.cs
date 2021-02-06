
using Caliburn.Micro;
using CaliburnWPFApp.EventModels;
using System.Threading;
using System.Threading.Tasks;

namespace CaliburnWPFApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {

        private StatViewModel _statVM;
        private SimpleContainer _container;


        private readonly IEventAggregator _events;

        public ShellViewModel(IEventAggregator events, StatViewModel statVM, SimpleContainer container)
        {
            _container = container;
            _events = events;
            _statVM = statVM;



            _events.SubscribeOnPublishedThread(this);
            ActivateItemAsync(_container.GetInstance<LoginViewModel>());
        }

        public async Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            await ActivateItemAsync(_statVM);
        }

        //public async Task SetUp()
        //{

        //    await ActiveItemAsync(_loginVM);
        //}


    }
}


//https://github.com/Caliburn-Micro/Caliburn.Micro/issues/697