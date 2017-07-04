using Module_Organization.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace Module_Organization
{
    public class Module_OrganizationModule : IModule
    {
        IRegionManager _regionManager;

        public Module_OrganizationModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
             _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewB));
        }
    }
}