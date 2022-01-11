using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2018_2019_Wall_E
{
    public class Position
    {   
        public Position(int Item1,int Item2)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
        }
   
        public int Item1 { get; private set; }
        public int Item2 { get; private set; }
        public void ChangePosition(int a,int b)
        {
            Item1 = a;Item2 = b;
        }
       


    }
}
