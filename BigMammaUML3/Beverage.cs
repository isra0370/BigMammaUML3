using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Beverage : MenuItem
    {
        private bool _alcohol;

        public Beverage(bool alcohol, int number, string name, string description, double price, MenuType menuType,
            bool isVegan, bool isOrganic) : base(number, name, description, price, menuType, isVegan,
            isOrganic)
        {
            _alcohol = alcohol;
        }

        public bool Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }

        public virtual string PrintInfo()
        {
            return $" Alcohol {_alcohol} ";
        }

        public override string ToString()
        {
            return
               base.ToString()+ $" Alcohol {_alcohol} ";
        }
    }
}
