using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.helpers
{
    public class CommonHelper
    {

        public static string WorkingFolderPath
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("SCClientApp.exe", ""); }
        }
    }
}
