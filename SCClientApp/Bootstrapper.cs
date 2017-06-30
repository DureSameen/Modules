using Microsoft.Practices.Unity;
using Prism.Unity;
using SSClientApp.Views;
using System.Windows;
using Prism.Modularity;

namespace SSClientApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog= new DirectoryModuleCatalog() { ModulePath = @".\Modules"  };
            
            return catalog;
        }

        protected override void ConfigureModuleCatalog()
        {
          
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.Initialize();
        foreach(var module in catalog.Modules)
        {
           
            module.InitializationMode = InitializationMode.OnDemand;
            }
        
              }
    }
}
