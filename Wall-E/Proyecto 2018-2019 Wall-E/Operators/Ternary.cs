using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Operators
{
    class Ternary : Instructions
    {
        public override string name
        {
            get
            {
                return "ternary";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            int a = On.Pop();
            int b = On.Pop();
            int c = On.Pop();
            if (c != 0) On.Push(b); else On.Push(a);
                
        }
    }
}
