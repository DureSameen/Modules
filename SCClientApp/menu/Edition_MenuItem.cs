using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using SC.ViewModel;
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
       

        IUnityContainer _container;
       ModuleVm _module;
       public Edition_MenuItem(ModuleVm module, IModuleManager moduleManager, IUnityContainer container)
            : base(module.Name, module.Name)
        {
            this._module=module;
            _moduleManager = moduleManager;

            _container = container;
        }

        public override void OnItemSelected()
        {
              var catalog = (ModuleCatalog)_container.Resolve<IModuleCatalog>();
              _moduleManager.LoadModule(_module.TypeName.Replace (".dll", ""));
        }
    }
}
