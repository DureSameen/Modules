using Prism.Commands;
using Prism.Mvvm;
using System;
 

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

        
    }
}
