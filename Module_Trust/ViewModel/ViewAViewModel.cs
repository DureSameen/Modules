using Module_Trust.SCClientWebApi;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Services.Client;
using Telerik.Windows.Data;
 

namespace Module_Trust.ViewModels
{
    public class  ViewAViewModel : BindableBase
    {
        
       

		public ViewAViewModel()
		{

		}

        private string _title="Trust";
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
                    this.context = new Container(new Uri("http://localhost/SCClientApi/odata"));
                }

                return this.context;
            }
        }
        private VirtualQueryableCollectionView trusts;

        public VirtualQueryableCollectionView Trusts  { get
            {
               return this.trusts;
               
            }
        }


        public VirtualQueryableCollectionView SetDataSource()
        { 
            
            this.DataServiceCollection.Load((DataServiceQuery<Trust>)
                 this.Context.trust
                     .IncludeTotalCount()
                    // .Where(this.trusts.FilterDescriptors)
                    // .Sort(this.trusts.SortDescriptors)
                     .Skip(0).Take(10));

            this.trusts = new VirtualQueryableCollectionView(this.DataServiceCollection) { LoadSize = 10 };

            return this.trusts;
        }
      

	
        private DataServiceCollection<Trust> dataServiceCollection;
        public DataServiceCollection<Trust> DataServiceCollection
        {
            get
            {
                if (this.dataServiceCollection == null)
                {
                    this.dataServiceCollection = new DataServiceCollection<Trust>(this.Context);

                }

                return this.dataServiceCollection;
            }
        }
       
    }
}
