using Prism.Commands;
using Prism.Mvvm;
using System;
 

namespace ModuleA.ViewModels
{
    public class  ViewAViewModel : BindableBase
    {
        

        private string _title="Module A";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        
    }
}
