using Module_Organization.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace Module_Organization
{
    public class OrganizationModule : IModule
    {
        IRegionManager _regionManager;

        public OrganizationModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
             _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewB));
        }
    }
}