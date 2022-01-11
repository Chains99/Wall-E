using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
    class Conditionals : Instructions
    {
       
    
        public override string name
        {
            get
            {
                return "branch";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer )
        {
            if (On.Pop() != 0)
            {
                if (consumer.direction.Item1 == 1)
                    consumer.direction.ChangeDirection(0, -1);
                else if (consumer.direction.Item1 == -1)
                    consumer.direction.ChangeDirection(0, 1);
                else if (consumer.direction.Item2 == 1)
                    consumer.direction.ChangeDirection(1, 0);
                else if (consumer.direction.Item2 == -1)
                    consumer.direction.ChangeDirection(-1, 0);
            }
            else
            {
                if (consumer.direction.Item1 == 1)
                    consumer.direction.ChangeDirection(0, 1);
                else if (consumer.direction.Item1 == -1)
                    consumer.direction.ChangeDirection(0, -1);
                else if (consumer.direction.Item2 == 1)
                    consumer.direction.ChangeDirection(-1, 0);
                else if (consumer.direction.Item2 == -1)
                    consumer.direction.ChangeDirection(1, 0);

            }

        }
    }
}
