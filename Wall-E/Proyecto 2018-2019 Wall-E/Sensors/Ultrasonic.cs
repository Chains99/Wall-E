using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Sensors
{
    class Ultrasonic:Instructions
    {
        public override string name
        {
            get
            {
                return "distance";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            On.Ultrasonic();
        }
    }
}
