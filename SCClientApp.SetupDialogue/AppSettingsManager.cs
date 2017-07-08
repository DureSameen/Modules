using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SCClientApp.SetupDialogue
{
   public class AppSettingsManager
    {

       public static AppSettingsSection Load(string path)
       {
           ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
           configFileMap.ExeConfigFilename = path;

           Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            

           return config.AppSettings;
       }
    }
}
