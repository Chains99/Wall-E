using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Operators
{
    class GEQ : Instructions
    {
        int a;
        int b;

        public override string name
        {
            get
            {
                return "geq";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            
            a = On.Pop();
            b = On.Pop();

            if (b >= a)
                On.Push(1);
            else On.Push(0);
        }
    }
}
