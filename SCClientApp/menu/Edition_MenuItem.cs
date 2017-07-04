using Microsoft.Practices.Unity;
using Module_Organization.Views;
using Prism.Modularity;
using Prism.Regions;
using SC.ViewModel;
using SC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.menu
{
   public class Edition_MenuItem : MenuItem
    {
        IModuleManager _moduleManager;

        IRegionManager _regionManager;
        IRegion        _region;
        IUnityContainer _container;
       ModuleVm _module;
       public Edition_MenuItem(ModuleVm module, IModuleManager moduleManager, IRegionManager  regionManager, IUnityContainer container)
            : base(module.Name, module.Name)
        {
            this._module=module;
            _moduleManager = moduleManager;
            _regionManager = regionManager;
            _container = container;
        }

        public override void OnItemSelected()
        {
              var catalog = (ModuleCatalog)_container.Resolve<IModuleCatalog>();
              _moduleManager.LoadModule("Module_"+ _module.Name +"Module");
             
                _region = _regionManager.Regions["ContentRegion"];
             
                var viewfullname = _module.TypeName.Replace(".dll", "") + ".Views.DefaultView";
              
                LoadViewInRegion<DefaultView>(_region, viewfullname);

               _regionManager.RequestNavigate("ContentRegion", new Uri(viewfullname, UriKind.Relative));


        }
        private void LoadViewInRegion<IViewType>(IRegion region, string viewName)
        {
            object view = region.GetView(viewName);
            if (view == null)
            {
                view = _container.Resolve<IViewType>();

                region.Add(view, viewName);
            }
        }

        
    }
}
