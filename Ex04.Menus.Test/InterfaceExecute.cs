using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfaceExecute
    {
        public void Run()
        {
            MainMenu mainMenu = new MainMenu("Interface Main Menu");

            FinalLevelMenu verisonAndCapitals = new FinalLevelMenu("Verison and Capital");
            FinalLevelMenu dateAndTimeMenu = new FinalLevelMenu("Show Date/Time");

            Version verison = new Version("Show Verison");
            CapitalsCounter capitalCounterFromSentence = new CapitalsCounter("Count Capitals");

            Date date = new Date("Show Date");
            Time time = new Time("Show Time");

            mainMenu.AddMenuItem(verisonAndCapitals);
            mainMenu.AddMenuItem(dateAndTimeMenu);
            verisonAndCapitals.AddItem(verison);
            verisonAndCapitals.AddItem(capitalCounterFromSentence);
            dateAndTimeMenu.AddItem(date);
            dateAndTimeMenu.AddItem(time);
            mainMenu.Show();
        }
    }
}