using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SCClientApp.SetupDialogue
{
    [RunInstaller(true)]
    public partial class CustomerModuleInstaller : System.Configuration.Install.Installer
    {
      
       
        public CustomerModuleInstaller()
        {
            
            InitializeComponent();

           
        }

         public override void Install(IDictionary stateSaver)
        {
          

        base.Install(stateSaver);
        


        string strSecretKey = Context.Parameters["SecretKey"];

        string assemblyPath = Context.Parameters["assemblyPath"];


        Debugger.Launch();

         var config=    new AppConfigurations( "SCClientApp.SetupDialogue.exe.config",assemblyPath,strSecretKey);
             


        string modules_dir = config.AssemblyPath + "Modules";

        if (!System.IO.Directory.Exists(modules_dir))
            ApplicationModules.Install(config);
        
         }

          
    }
}
