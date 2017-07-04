using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.menu
{
    class Modules_MenuItem : MenuItem
    {
        public Modules_MenuItem()
            : base("Modules", "_Modules")
        {

        }

        public override void OnItemSelected()
        {
            // Top level item, we don't need to do anything.
        }
    }
}
