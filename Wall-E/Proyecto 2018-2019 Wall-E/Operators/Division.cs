using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Operators
{
    class Division : Instructions
    {
        int a;
        int b;

        public override string name
        {
            get
            {
                return "div";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
           
            a = On.Pop();
            if (a == 0)
                throw new Exception("Division by zero");
            b = On.Pop();
            On.Push((int)(b / a));

        }
    }
}
