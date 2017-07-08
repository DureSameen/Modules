using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.SetupDialogue
{
   public class AppConfigurations
    {

       public string AppConfigName
       {
           get;
           set;
       }
          
         public string AssemblyPath
         {
             get;
             set;

         }

       public string SecretKey
       {
           get;
           set;
       }

       public AppSettingsSection AppSettings { get; set; }  
      
       
       public AppConfigurations()
       { }

       public AppConfigurations(string appConfigName, string assemblypath, string secretkey)
       {

           this.AppConfigName = appConfigName; 
           this.SecretKey = secretkey;
           int i = assemblypath.Length - 1;
           while (assemblypath[i] != '\\') --i;

           this.AssemblyPath = assemblypath.Substring(0, i) + "\\";

           var appconfigpath = this.AssemblyPath  +this.AppConfigName;

           this.AppSettings = AppSettingsManager.Load(appconfigpath);
       }


       public string GetSetting(string name)

       { return this.AppSettings.Settings[name].Value; }
    }
}
