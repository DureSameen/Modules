using Microsoft.Practices.Unity;
using Prism.Unity;
using SSClientApp.Views;
using System.Windows;
using Prism.Modularity;
using SCClientApp.helpers;

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
            string modules_dir = @".\Edition\Modules";

            return new DirectoryModuleCatalog() { ModulePath = modules_dir };
        }
         

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
           
            foreach (var module in catalog.Modules)
            {

                module.InitializationMode = InitializationMode.OnDemand;
            }
        
              }
    }
}
