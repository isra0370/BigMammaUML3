using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        private Dictionary<int, IMenuItem> _menuItems;

        public MenuCatalog()
        {
            _menuItems = new Dictionary<int, IMenuItem>();
        }

        public int Count
        {
            get { return _menuItems.Count; }
        }

        public void Add(IMenuItem aMenuItem)
        {
            if (!_menuItems.ContainsKey(aMenuItem.Number))
            {
                int key = aMenuItem.Number;
                _menuItems.Add(key, aMenuItem);
            }
            else
            {
                throw new MenuItemNumberExist("MenuItem eksisterer allerede");
            }
        }

        public IMenuItem Search(int number)
        {
            if (_menuItems.ContainsKey(number))
            {
                return _menuItems[number];
            }
            else
            {
                return null;
            }
        }

        public void Delete(int number)
        {
            if (_menuItems.ContainsKey(number))
            {
                _menuItems.Remove(number);
            }
        }

        public void PrintPizzasMenu()
        {
            foreach (var p in _menuItems)
            {
                Console.WriteLine(p.Value.ToString());
            }
        }

        public void PrintBeveragesMenu()
        {
            foreach (var b in _menuItems)
            {
                Console.WriteLine(b.Value.ToString());
            }
        }

        public void PrintSalatsMenu()
        {
            foreach (var s in _menuItems)
            {
                Console.WriteLine(s.Value.ToString());
            }

        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            if (_menuItems.ContainsKey(number))
            {
                _menuItems[number] = theMenuItem;
            }
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> returnList = new List<IMenuItem>();
            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m.IsVegan == true)
                {
                    returnList.Add(m);
                }
            }
            return returnList;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> returList = new List<IMenuItem>();
            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m.IsOrganic == true)
                {
                    returList.Add(m);
                }
            }
            return returList;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem mostExpensive = null;
            if (_menuItems.Count > 0)
            {
                mostExpensive = _menuItems.Values.FirstOrDefault();
                foreach (IMenuItem m in _menuItems.Values)
                {
                    if (m.Price > mostExpensive.Price)
                    {
                        mostExpensive = m;
                    }
                }
            }
            return mostExpensive;
        }

        public virtual string PrintInfo()
        {
            string t = "";
            foreach (IMenuItem m in _menuItems.Values)
            {
                t = t + ((MenuItem)m);
            }

            return t;
        }

        public override string ToString()
        {
            string t = "";
            foreach (IMenuItem m in _menuItems.Values)
            {
                t = t + ((MenuItem)m) + "\n";
            }

            return t;
        }
    }
}
