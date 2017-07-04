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
        //protected override IModuleCatalog CreateModuleCatalog()
        //{

           
        //    var catalog = new DirectoryModuleCatalog() { ModulePath = modules_dir };
            
        //    return catalog;
        //}

        protected override void ConfigureModuleCatalog()
        {
            var moduleAType = typeof(Module_Trust.Module_TrustModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleAType.Name,
                ModuleType = moduleAType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.OnDemand
            });
            var modulebType = typeof(Module_Organization.Module_OrganizationModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = modulebType.Name,
                ModuleType = modulebType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.OnDemand
            });

        //    var catalog = (ModuleCatalog)ModuleCatalog;
        //    //catalog.Initialize();
        //foreach(var module in catalog.Modules)
        //{
           
        //    module.InitializationMode = InitializationMode.OnDemand;
        //}
        
              }
    }
}
