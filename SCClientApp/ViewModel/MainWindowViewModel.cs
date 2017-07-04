using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using SC.ViewModel;
using SCClientApp.Common;
using SCClientApp.menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        MenuService menuService;

        public MainWindowViewModel(IModuleManager moduleManager,  IUnityContainer container)
        {
            this.menuService = new MenuService();

            Modules_MenuItem modules_Menu = new Modules_MenuItem(); 
            this.menuService.AddMenuItem(modules_Menu);


            EditionInfoManager mgr = new EditionInfoManager();
            EditionInfo editioninfo= mgr.ReadFromFile();

            foreach (var module in editioninfo.Modules)
            {
                Edition_MenuItem item = new Edition_MenuItem(module,moduleManager,container );
                this.menuService.AddMenuItem(item, "Modules");
              
            }

        }

        public List<MenuItem> ParentItems
        {
            get
            {
                return this.menuService.GetParentMenuItems();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
