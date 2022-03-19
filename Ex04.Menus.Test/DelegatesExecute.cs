using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal static class DelegatesExecute
    {
        internal static MainMenu GetDelegatesMainMenu()
        {
            MethodsForDeligates methods = new MethodsForDeligates();

            List<MenuItem> versionAndCapitalItems = new List<MenuItem>();
            List<MenuItem> dateAndTimeItems = new List<MenuItem>();

            versionAndCapitalItems.Add(new MenuItem("Count Capital"));
            versionAndCapitalItems.Add(new MenuItem("Show Version"));
            dateAndTimeItems.Add(new MenuItem("Show Date"));
            dateAndTimeItems.Add(new MenuItem("Show Time"));

            versionAndCapitalItems[1].OnChosen += methods.ShowVersion_OnChosen;
            versionAndCapitalItems[0].OnChosen += methods.CountCapital_OnChosen;
            dateAndTimeItems[0].OnChosen += methods.ShowDate_OnChosen;
            dateAndTimeItems[1].OnChosen += methods.Time_OnChosen;

            FinalLevelMenu versionAndDigitsMenu = new FinalLevelMenu("Version and Capitals", versionAndCapitalItems);
            FinalLevelMenu showDateOrTimeMenu = new FinalLevelMenu("Show Date/Time", dateAndTimeItems);
            List<MenuItem> mainMenuItems = new List<MenuItem>
                                               {
                                                   versionAndDigitsMenu,
                                                   showDateOrTimeMenu
                                               };

            return new MainMenu(mainMenuItems);
        }
    }
}