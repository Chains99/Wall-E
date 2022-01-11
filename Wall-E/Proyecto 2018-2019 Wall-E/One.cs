using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
    public class One:Instructions
    {
        int a;

        public override string name
        {
            get
            {
                return "one";
            }
        }

        public override void Execute(Robot On ,Instructions_Consumer consumer)
        {
           
            a = On.Pop();
            On.Push(2 * a + 1);

        }
    }
}
