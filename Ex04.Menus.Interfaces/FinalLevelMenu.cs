using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class FinalLevelMenu : MenuItem
    {
        private const int k_Exit = 0;

        private readonly List<MenuItem> r_MenuitemsList = new List<MenuItem>();

        private readonly List<int> r_LevelList = new List<int>();

        public FinalLevelMenu(string i_Title) : base(i_Title)
        {
            r_MenuitemsList.Add(null);
            r_LevelList.Add(k_Exit);
        }

        public void AddItem(MenuItem i_NewItemToAdd)
        {
            int levelToAdd = r_LevelList.Count;
            r_MenuitemsList.Add(i_NewItemToAdd);
            r_LevelList.Add(levelToAdd);
        }

        private int getUserSelect()
        {
            int userInputSelect = 0;
            bool flag = true;
            while (flag)
            {
                string inputFromUser = string.Empty;
                inputFromUser = Console.ReadLine();
                int.TryParse(inputFromUser, out userInputSelect);
                flag = !int.TryParse(inputFromUser, out userInputSelect) || !r_LevelList.Contains(userInputSelect);
                Console.WriteLine("The value is not Valid!");
                Console.WriteLine("Please enter a number between 0 to 2:");
            }

            return userInputSelect;
        }

        private void printMenuByMenuLevel(int i_Level)
        {
            Console.WriteLine("{0}{1}{0}", "**", this.ItemTitle);
            Console.WriteLine("-----------------------");
            int index = 0;
            int lenghtOffevelList = r_LevelList.Count;
            for (index = 1; index < lenghtOffevelList; index++)
            {
                Console.WriteLine("{0} -> {1}", index, r_MenuitemsList[index].ToString());
            }

            if (i_Level == 1)
            {
                Console.WriteLine("0 -> Exit");
                Console.WriteLine("Enter your request: (1 to 2 or press '0' to Exit)");
            }
            else
            {
                Console.WriteLine("0 -> Back");
                Console.WriteLine("Enter your request: (1 to 2 or press '0' to Back)");
            }
        }

        public void Show(int i_Level)
        {
            FinalLevelMenu finalLevelMenu;
            int inputChoice;
            do
            {
                printMenuByMenuLevel(i_Level);
                inputChoice = getUserSelect();
                Console.Clear();
                finalLevelMenu = r_MenuitemsList[inputChoice] as FinalLevelMenu;
                finalLevelMenu?.Show(i_Level + 1);
                if (r_MenuitemsList[inputChoice] is IExecution)
                {
                    ((IExecution)r_MenuitemsList[inputChoice]).Execute();
                }
            }
            while (inputChoice != k_Exit);
        }
    }
}
