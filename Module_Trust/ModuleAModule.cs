using Microsoft.Practices.Unity;
using Module_Trust.ViewModels;
using Module_Trust.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace Module_Trust
{
    public class Module_TrustModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;
        public Module_TrustModule(RegionManager regionManager, IUnityContainer  container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {

            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));

        }
    }
}