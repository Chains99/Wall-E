using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
   public class Print : Instructions
    {  public string console { get; private set; }
        public Print()
        {
            console = "";
        }

        public override string name
        {
            get
            {
                return "print";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            console = On.Pop().ToString();
        }
    }
}
