using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E
{
    public abstract class Instructions
    {
        public abstract string name { get; }

        public abstract void Execute(Robot On, Instructions_Consumer consumer);
    }
}
