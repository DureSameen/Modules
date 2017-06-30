using Prism.Commands;
using Prism.Mvvm;
using System;
 

namespace Module_Trust.ViewModels
{
    public class  ViewAViewModel : BindableBase
    {
        

        private string _title="Trust";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        
    }
}
