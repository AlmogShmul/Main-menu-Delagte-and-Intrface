using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private List<MenuItem> m_DelegatesMenuItems;

        public MainMenu(List<MenuItem> i_MenuItemsList)
        {
            m_DelegatesMenuItems = i_MenuItemsList;
        }

        public void Execute()
        {
            int userChosen;
            do
            {
                DelegatesMenu.PrintMenu("Delegates Main Menu", m_DelegatesMenuItems, "0 -> Exit");
                userChosen = DelegatesMenu.GetuserChosen(m_DelegatesMenuItems.Count);
                if (userChosen != -1)
                {
                    m_DelegatesMenuItems[userChosen].Item_Chosen();
                }
            }
            while (userChosen != -1);
        }
    }
}