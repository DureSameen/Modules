using SC.ViewModel;
using SCClientApp.Common;
using SCClientApp.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.menu
{
    public class EditionInfoManager
    {


        public EditionInfo ReadFromFile()
        {
            string json = System.IO.File.ReadAllText(CommonHelper.WorkingFolderPath + "\\Edition\\edition_info.json");

            return JsonHelper.Deserialize<EditionInfo>(json);

        
        
        }

    }
}
