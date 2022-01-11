using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Operators
{
    class Or:Instructions
    {
        bool a = false;
        bool b = false;

        public override string name
        {
            get
            {
               return "or";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
           
            if (On.Pop() != 0)
                b = true;
            if (b || a)
                On.Push(1);
            else
                On.Push(0);


        }
    }
}
