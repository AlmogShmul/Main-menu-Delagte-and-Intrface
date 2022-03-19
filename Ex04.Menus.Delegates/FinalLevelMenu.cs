using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class FinalLevelMenu : MenuItem
    {
        private List<MenuItem> m_DelegatesMenuItems;

        public FinalLevelMenu(string i_MenuTitle, List<MenuItem> i_MenuItems) : base(i_MenuTitle)
        {
            m_DelegatesMenuItems = i_MenuItems;
        }

        internal override void Item_Chosen()
        {
            base.Item_Chosen();
            int userChosen;
            do
            {
                DelegatesMenu.PrintMenu(m_MenuTitle, m_DelegatesMenuItems, "0 -> Back");
                userChosen = DelegatesMenu.GetuserChosen(m_DelegatesMenuItems.Count);
                if (userChosen != -1)
                {
                    Console.Clear();
                    m_DelegatesMenuItems[userChosen].Item_Chosen();
                }
            }
            while (userChosen != -1);
        }
    }
}