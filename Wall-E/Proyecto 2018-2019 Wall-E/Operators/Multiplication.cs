using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Operators
{
    class Multiplication : Instructions
    {
       
        public override string name
        {
            get
            {
                return  "mul";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            int a;
            int b;

            a = On.Pop();
            b = On.Pop();
            On.Push(b * a);

        }
    }
}
