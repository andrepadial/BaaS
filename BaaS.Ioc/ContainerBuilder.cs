using System;
using BaaS.App.Autbank;
using BaaS.Interfaces.Autbank.App;
using BaaS.Repositories.Autbank;
using BaaS.Services.Autbank;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace BaaS.Ioc
{
    public class ContainerBuilder
    {
        private static Container _container;

        static ContainerBuilder() => CreateContainer();

        public static T ObterInstancia<T>()
           where T : class =>
           _container.GetInstance<T>();

        public static Container Container() => _container;

        private static void CreateContainer()
        {
            _container = new Container();
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            RegisterApplications();
            RegisterServices();
            RegisterRepositories();
            RegisterProxys();
        }

        private static void RegisterApplications()
        {
            _container.Register<EBankApp>();
        }

        private static void RegisterServices()
        {
            _container.Register<EBankService>();
        }

        private static void RegisterRepositories()
        {
            _container.Register<EBankRepository>();
        }

        private static void RegisterProxys()
        {
        }

    }
}
