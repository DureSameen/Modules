using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using SCClientApp.ViewModel;
using System.Windows;

namespace SSClientApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IModuleManager _moduleManager;
        IRegionManager _regionManager;

        IUnityContainer _container;
        public MainWindow(IModuleManager moduleManager, IUnityContainer  container)
        {
            InitializeComponent();
            _moduleManager = moduleManager;
            
            _container = container;
          
            this.DataContext = new MainWindowViewModel(moduleManager,  container);
        }


       
      

      
    }
}
