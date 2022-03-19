using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CapitalsCounter : MenuItem, IExecution
    {
        public CapitalsCounter(string i_Title) : base(i_Title)
        {
            /// The name / title of the item is initialized by signing the method
        }

        public void Execute()
        {
            GetCapitalCounter();
        }

        public void GetCapitalCounter()
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
            Console.Clear();
        }
    }
}