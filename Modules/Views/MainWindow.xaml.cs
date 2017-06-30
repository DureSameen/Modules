using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace Modules.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IModuleManager _moduleManager;
        IRegionManager _regionManager;
        IRegion _region;
        IUnityContainer _container;
        public MainWindow(IModuleManager moduleManager, IRegionManager regionManager, IUnityContainer  container)
        {
            InitializeComponent();
            _moduleManager = moduleManager;
            _regionManager = regionManager;
            _container = container;
            var catalog = (ModuleCatalog)_container.Resolve<IModuleCatalog>();
 
             foreach (var module in catalog.Modules )
                 _moduleManager.LoadModule(module.ModuleName);
             
        }


       
      

      
    }
}
