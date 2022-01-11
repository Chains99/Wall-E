using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
    class Get : Instructions
    { char letter;
        public Get(char letter)
        {
            this.letter = letter;
        }

        public override string name
        {
            get
            {
                return "get"+letter;
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            consumer.Get(letter);
        }
    }
}
