using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.ServiceLocation;

namespace LearnPrism
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.RegisterInstance<IServiceLocator>(new UnityServiceLocator(container));

            container.RegisterType<IModuleInitializer, ModuleInitializer>();

            //This knows how to read from Configuration file
            //container.RegisterType<IModuleCatalog, ConfigurationModuleCatalog>();
            // or we can register the instance directly
            ConfigurationModuleCatalog moduleCatalog = new ConfigurationModuleCatalog();
            container.RegisterInstance<IModuleCatalog>(moduleCatalog);

            // Logs using System.IO.Writer
            TextLogger textLogger = new TextLogger();
            container.RegisterInstance<ILoggerFacade>(textLogger);

            //Initialized with the help of TextLogger, ConfigurationModuleCatalog and ModuleInitializer
            container.RegisterType<IModuleManager, ModuleManager>();

            IModuleManager moduleManager = container.Resolve<IModuleManager>();

            moduleManager.Run();
        }
    }
}
