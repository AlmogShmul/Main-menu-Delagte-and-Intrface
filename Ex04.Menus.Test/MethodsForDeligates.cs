using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    internal class MethodsForDeligates
    {
        public void ShowVersion_OnChosen()
        {
            string version = "Version: 22.1.4.8930";
            Console.WriteLine(version);
            Wait();
        }

        public void CountCapital_OnChosen()
        {
            string userInputSentence = string.Empty;
            int countOfCapitalLetters = 0;
            Console.WriteLine("Please enter a sentence");
            userInputSentence = Console.ReadLine();
            while (userInputSentence == string.Empty)
            {
                Console.WriteLine("You did not enter an entry.Please enter your sentence.");
                userInputSentence = Console.ReadLine();
            }

            foreach (char letter in userInputSentence)
            {
                if (char.IsUpper(letter))
                {
                    countOfCapitalLetters++;
                }
            }

            Console.WriteLine("There were " + countOfCapitalLetters + " capital letters");
            Wait();
        }

        public void ShowDate_OnChosen()
        {
            DateTime currentDateTime = DateTime.Now;
            string massage = string.Format("The date now is: {0}", currentDateTime.ToShortDateString());
            Console.WriteLine(massage);
            Wait();
        }

        public void Time_OnChosen()
        {
            DateTime currentDateTime = DateTime.Now;
            string massage = string.Format("The time now is: {0}", currentDateTime.ToShortTimeString());
            Console.WriteLine(massage);
            Wait();
        }

        public void Wait()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}