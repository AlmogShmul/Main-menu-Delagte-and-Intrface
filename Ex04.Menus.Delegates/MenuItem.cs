using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        protected string m_MenuTitle;

        public event Action OnChosen;

        public MenuItem(string i_MenuTitle)
        {
            m_MenuTitle = i_MenuTitle;
        }

        public override string ToString()
        {
            return m_MenuTitle;
        }

        // $G$ CSS-999 (-3) Bad method name, should be in the form of camelCase, without any underline.
        internal virtual void Item_Chosen()
        {
            OnChosen?.Invoke();
        }
    }
}