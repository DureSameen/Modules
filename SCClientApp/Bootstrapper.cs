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
            string working_dir = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("SCClientApp.exe", "");
            string modules_dir = working_dir+ "Modules";
            
            var catalog = new DirectoryModuleCatalog() { ModulePath = modules_dir };
            
            return catalog;
        }

        protected override void ConfigureModuleCatalog()
        {
          
            var catalog = (ModuleCatalog)ModuleCatalog;
            //catalog.Initialize();
        foreach(var module in catalog.Modules)
        {
           
            module.InitializationMode = InitializationMode.OnDemand;
            }
        
              }
    }
}
