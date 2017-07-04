using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SCClientApp.menu
{
    public abstract class MenuItem
    {
        private string name;

        private string text;

        private ObservableCollection<MenuItem> subItems;

        private ICommand onSelected;

        private MenuItem parent;

        public MenuItem(string name, string text)
        {
            this.name = name;
            this.text = text;
            this.subItems = new ObservableCollection<MenuItem>();
        }

        public string Name { get { return this.name; } }

        public string Text { get { return this.text; } }

        public MenuItem Parent { get { return this.parent; } set { this.parent = value; } }

        public ICommand OnSelected
        {
            get
            {
                if (this.onSelected == null)
                {
                    this.onSelected = new MenuCommand(this.OnItemSelected, this.ItemCanBeSelected);
                }
                return this.onSelected;
            }
        }

        public ObservableCollection<MenuItem> SubItems
        {
            get
            {
                return this.subItems;
            }
        }

        public void AddSubMenu(MenuItem menuItem)
        {
            this.subItems.Add(menuItem);
        }

        public void RemoveSubMenu(MenuItem menuItem)
        {
            if (this.subItems.Contains(menuItem))
            {
                this.subItems.Remove(menuItem);
            }
        }

        public abstract void OnItemSelected();

        public virtual bool ItemCanBeSelected()
        {
            return true;
        }
    }
}
