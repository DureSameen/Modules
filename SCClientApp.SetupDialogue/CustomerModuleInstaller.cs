﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
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


        

         var config=    new AppConfigurations( "SCClientApp.SetupDialogue.exe.config",assemblyPath,strSecretKey);
             


        string modules_dir = config.AssemblyPath + "Modules";

        if (!System.IO.Directory.Exists(modules_dir))
            ApplicationModules.Install(config);
        
         }
         public override void Uninstall(IDictionary savedState)
         {
            
             base.Uninstall(savedState);

             


             string assemblyPath = Context.Parameters["assemblyPath"];
            
             var config = new AppConfigurations("SCClientApp.SetupDialogue.exe.config", assemblyPath, "");

             var extractPath = config.AssemblyPath + "Edition";

             var dir = new DirectoryInfo(config.AssemblyPath);

             foreach (var file in dir.EnumerateFiles("*.zip"))
             {
                 file.Delete();
             }

           if (System.IO.Directory.Exists(extractPath))
             System.IO.Directory.Delete(extractPath,true);
         
         }
          
    }
}
