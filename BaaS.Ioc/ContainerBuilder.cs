using System;
using BaaS.App.Autbank;
using BaaS.Repositories.Autbank.Interfaces;
using BaaS.Repositories.Autbank;
using BaaS.Services.Autbank;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using BaaS.App.Autbank.Interfaces;
using BaaS.Services.Autbank.Interfaces;

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
            _container.Register<IEBankApp, EBankApp>(Lifestyle.Scoped);
            _container.Register<IInfobankApp, InfobankApp>(Lifestyle.Scoped);
            _container.Register<IPixApp, PixApp>(Lifestyle.Scoped);
        }

        private static void RegisterServices()
        {
            _container.Register<IEBankService, EBankService>(Lifestyle.Scoped);
            _container.Register<IInfobankService, InfobankService>(Lifestyle.Scoped);
            _container.Register<IPixService, PixService>(Lifestyle.Scoped);
        }

        private static void RegisterRepositories()
        {
            _container.Register<IEBankRepository, EBankRepository>(Lifestyle.Scoped);
            _container.Register<IInfobankRepository, InfobankRepository>(Lifestyle.Scoped);
            _container.Register<IPixRepository, PixRepository>(Lifestyle.Scoped);
        }

        private static void RegisterProxys()
        {
        }

    }
}
