using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_ItemTitle;

        public string ItemTitle
        {
            get
            {
                return m_ItemTitle;
            }

            set
            {
                m_ItemTitle = value;
            }
        }

        public MenuItem(string i_MenuItemTitle)
        {
            ItemTitle = i_MenuItemTitle;
        }

        public override string ToString()
        {
            return ItemTitle;
        }

        public void Wait()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}