using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level03OOP
{
    class human
    {

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 5)
                    _age = 5;
                else if (value > 100)
                    _age = 100;
                else
                    _age = value;
            }
        }

        //constructor
        public human()
        {
            _age = 1;
        }

        //Methord
        public void IncreateAge()
        {
            Age++;
        }
    }
}
