using System;
using BaaS.App.Autbank;
using BaaS.Interfaces.Autbank.App;
using BaaS.Interfaces.Autbank.Repositories;
using BaaS.Interfaces.Autbank.Services;
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
            _container.Register<IEBankApp, EBankApp>(Lifestyle.Scoped);
        }

        private static void RegisterServices()
        {
            _container.Register<IEBankService, EBankService>(Lifestyle.Scoped);
        }

        private static void RegisterRepositories()
        {
            _container.Register<IEBankRepository, EBankRepository>(Lifestyle.Scoped);
        }

        private static void RegisterProxys()
        {
        }

    }
}
