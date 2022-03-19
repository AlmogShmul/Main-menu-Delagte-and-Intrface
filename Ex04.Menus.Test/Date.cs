using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Date : MenuItem, IExecution
    {
        public Date(string i_Title) : base(i_Title)
        {
            /// The name / title of the item is initialized by signing the method
        }

        public void Execute()
        {
            GetDate();
        }

        public void GetDate()
        {
            DateTime currentDateTime = DateTime.Now;
            string massage = string.Format("The date now is: {0}", currentDateTime.ToShortDateString());
            Console.WriteLine(massage);
            Wait();
            Console.Clear();
        }
    }
}