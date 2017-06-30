using Prism.Commands;
using Prism.Mvvm;
using System;
 

namespace ModuleB.ViewModels
{
    public class  ViewBViewModel : BindableBase
    {
        

        private string _title="Module B";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        
    }
}
