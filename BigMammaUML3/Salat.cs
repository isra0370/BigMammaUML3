using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Salat : MenuItem
    {
        private bool _caesarSalat;
        private bool _pastaSalat;

        public Salat(bool caesarSalat, bool pastaSalat, int number, string name, string description, double price, MenuType menuType, bool isVegan,
            bool isOrganic) : base(number, name, description, price, menuType,
            isVegan, isOrganic)
        {
            _caesarSalat = caesarSalat;
            _pastaSalat = pastaSalat;
        }

        public bool CaesarSalat
        {
            get { return _caesarSalat; }
            set { _caesarSalat = value; }
        }

        public bool PastaSalat
        {
            get { return _pastaSalat; }
            set { _pastaSalat = value; }
        }

        public virtual string PrintInfo()
        {
            return
                $" CaesarSalat {_caesarSalat}, PastaSalat {_pastaSalat} " + base.PrintInfo();
        }

        public override string ToString()
        {
            return
                base.ToString() + $" CaesarSalat {_caesarSalat}, PastaSalat {_pastaSalat} ";
        }

    }
}


