using AutoMapper;
using Caliburn.Micro;
using CaliburnWPFApp.Helpers;
using CaliburnWPFApp.Library.Api;
using CaliburnWPFApp.Library.Models;
using CaliburnWPFApp.Models;
using CaliburnWPFApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CaliburnWPFApp
{
    public class Bootstrapper : BootstrapperBase
    {

        private SimpleContainer _container = new SimpleContainer();
        public Bootstrapper()
        {
            Initialize();
            ConventionManager.AddElementConvention<PasswordBox>(
           PasswordBoxHelper.BoundPasswordProperty,
           "Password",
           "PasswordChanged");
        }

        private IMapper ConfigureAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StagedCharacterStatModel, DisplayCharacterStatModel>();
            });

            var output = config.CreateMapper();

            return output;
        }

        protected override void Configure()
        {
            _container.Instance(ConfigureAutomapper());

            _container.Instance(_container) //set the above _container(variable) as its own singleton reference
                .PerRequest<ICharacterStatEndpoint, CharacterStatEndpoint>()
                .PerRequest<IUserEndpoint, UserEndpoint>();

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>()
                .Singleton<ILoggedInUserModel, LoggedInUserModel>()
                .Singleton<IApiHelper, ApiHelper>();

            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType)); //may have to come back and swap the service param to an interface, but for now it will function
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
