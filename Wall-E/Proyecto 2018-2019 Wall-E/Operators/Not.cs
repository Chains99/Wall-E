﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;

namespace Proyecto_2018_2019_Wall_E.Operators
{
    class Not:Instructions
    {
        public override string name
        {
            get
            {
                return "not";
            }
        }

        public override void Execute(Robot On, Instructions_Consumer consumer)
        {
            
            if (On.Pop() != 0)
                On.Push(0);
            else
                On.Push(1);
        }
    }
}
