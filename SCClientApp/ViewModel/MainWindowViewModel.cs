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

        public MainWindowViewModel(IModuleManager moduleManager,IRegionManager regionmanager,  IUnityContainer container)
        {
            this.menuService = new MenuService();
            EditionInfoManager mgr = new EditionInfoManager();
            EditionInfo editioninfo = mgr.ReadFromFile();





            foreach (var section in editioninfo.Sections)
            {
                Section_MenuItem section_Menu = new Section_MenuItem(section.Name);
                this.menuService.AddMenuItem(section_Menu);

                foreach (var module in section.Modules)
                {
                    Modules_MenuItem item = new Modules_MenuItem(module, moduleManager, regionmanager, container);
                    this.menuService.AddMenuItem(item, section.Name);

                }
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
