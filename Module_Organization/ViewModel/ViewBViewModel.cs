using Prism.Commands;
using Prism.Mvvm;
using System;
using Telerik.Windows.Data;
using Module_Organization.SCClientWebApi;
using System.Data.Services.Client;
using System.Configuration;
 

namespace Module_Organization.ViewModels
{
    public class  ViewBViewModel : BindableBase
    {
        

        private string _title="Organization";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private Container context;
        public Container Context
        {
            get
            {
                if (this.context == null)
                {
                    this.context = new Container(new Uri(ConfigurationManager.AppSettings["clientwebapi_url"].ToString()));
                }

                return this.context;
            }
        }
        private VirtualQueryableCollectionView organizations;

        public VirtualQueryableCollectionView Organizations
        {
            get
            {
                return this.organizations;

            }
        }


        public VirtualQueryableCollectionView SetDataSource()
        {

            this.DataServiceCollection.Load((DataServiceQuery<Organization>)
                 this.Context.organization
                     .IncludeTotalCount()
                // .Where(this.trusts.FilterDescriptors)
                // .Sort(this.trusts.SortDescriptors)
                     .Skip(0).Take(10));

            this.organizations = new VirtualQueryableCollectionView(this.DataServiceCollection) { LoadSize = 10 };

            return this.organizations;
        }



        private DataServiceCollection<Organization> dataServiceCollection;
        public DataServiceCollection<Organization> DataServiceCollection
        {
            get
            {
                if (this.dataServiceCollection == null)
                {
                    this.dataServiceCollection = new DataServiceCollection<Organization>(this.Context);

                }

                return this.dataServiceCollection;
            }
        }
    }
}
