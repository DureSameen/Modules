using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCClientApp.menu
{
    class Section_MenuItem : MenuItem
    {
        public Section_MenuItem(string name)
            : base(name, name)
        {

        }

        public override void OnItemSelected()
        {
            // Top level item, we don't need to do anything.
        }
    }
}
