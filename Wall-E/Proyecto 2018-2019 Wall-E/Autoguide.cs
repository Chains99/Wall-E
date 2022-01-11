using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
    class Autoguide : Instructions
    { public string GetDirection { get; private set; }
        public Autoguide(string direction)
        {
            GetDirection = direction;
        }
        public override string name
        {
            get
            {
                return "autoguide" + GetDirection;
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
           
        }
    }
}
