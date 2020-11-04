using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Pizza : MenuItem
    {
        private bool _deepPan;

        public Pizza(bool deepPan, int number, string name, string description, double price, MenuType menuType, bool isVegan,
            bool isOrganic) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _deepPan = deepPan;
        }

        public bool DeepPan
        {
            get { return _deepPan;}
            set { _deepPan = value; }
        }

        public virtual string PrintInfo()
        {
            return $" DeepPan {_deepPan} " + base.PrintInfo();
        }

        public override string ToString()
        {
            return base.ToString()+ $" DeepPan {_deepPan} " ;
        }
    }
}
