using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const int k_mainMenuLevel = 1;
        private readonly FinalLevelMenu r_FinalLevelMenu;

        public FinalLevelMenu FinalLevelMenu
        {
            get
            {
                return r_FinalLevelMenu;
            }
        }

        public MainMenu(string i_MenuTitle)
        {
            r_FinalLevelMenu = new FinalLevelMenu(i_MenuTitle);
        }

        public void AddMenuItem(MenuItem i_NewItemToAdded)
        {
            FinalLevelMenu.AddItem(i_NewItemToAdded);
        }

        public void Show()
        {
            FinalLevelMenu.Show(k_mainMenuLevel);
        }
    }
}