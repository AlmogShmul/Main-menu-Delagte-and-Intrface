using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class DelegatesMenu
    {
        internal static void PrintMenu(string i_MenuTitle, List<MenuItem> i_MenuItems, string i_ChoiceNumber)
        {
            Console.Clear();
            Console.WriteLine("{0}{1}{0}", "**", i_MenuTitle);
            Console.WriteLine("-----------------------");
            for (int i = 0; i < i_MenuItems.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", (i + 1).ToString(), i_MenuItems[i].ToString());
            }

            if (i_ChoiceNumber != "0 -> Back")
            {
                Console.WriteLine("{0}", i_ChoiceNumber);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter your request: (1 to 2 or press '0' to Exit)");
            }
            else
            {
                Console.WriteLine("{0}", i_ChoiceNumber);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter your request: (1 to 2 or press '0' to Back)");
            }
        }

        internal static int GetuserChosen(int i_NumOfOptions)
        {
            string stringFromUser = string.Empty;
            int userChosen;
            bool isNumber;
            do
            {
                stringFromUser = Console.ReadLine();
                isNumber = int.TryParse(stringFromUser, out userChosen);
                if (!isNumber || userChosen < 0 || userChosen > i_NumOfOptions)
                {
                    Console.WriteLine("The value is not Valid!");
                    Console.WriteLine("Please enter a number between 0 to {0}:", i_NumOfOptions);
                }
            }
            while (!isNumber || userChosen < 0 || userChosen > i_NumOfOptions);

            return userChosen - 1;
        }
    }
}