using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Flow_Control
{
     class T_South:Instructions
    {
        int a;

        public override string name
        {
            get
            {
                return "TS";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            Random b = new Random();
            if (consumer.direction.Item1 == -1)
            {
                a = b.Next(-1, 2);
                while (a == 0)
                {
                    a = b.Next(-1, 2);
                }
                consumer.direction.ChangeDirection(0, a);

            }
            else if (consumer.direction.Item2 == 1 || consumer.direction.Item2 == -1)
                consumer.direction.ChangeDirection(1, 0);
        }
    }
}
