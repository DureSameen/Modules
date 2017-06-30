using ModuleB.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace ModuleB
{
    public class ModuleBModule : IModule
    {
        IRegionManager _regionManager;

        public ModuleBModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
             _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewB));
        }
    }
}