using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
    class Set : Instructions
    {
        char letter;
        public Set(char letter)
        {
            this.letter = letter;
        }

        public override string name
        {
            get
            {
               return "set"+letter;
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            consumer.Set(letter);
        }
    }
}
