using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2018_2019_Wall_E
{
    public class Direction
    {
        public Direction(int Item1,int Item2)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
        }
        public Direction(string direction)
        {
            switch (direction)
            {
                case "north":
                    {
                        Item1 = -1;
                        Item2 = 0;
                        break;
                    }
                case "south":
                    {
                        Item1 = 1;
                        Item2 = 0;
                        break;
                    }
                case "east":
                    {
                        Item1 = 0;
                        Item2 = 1;
                        break;
                    }
                case "west":
                    {
                        Item1 = 0;
                        Item2 = -1;
                        break;
                    }
                default:throw new Exception("Invalid Direction");
            }
        }
        public int Item1 { get;private set; }
        public int Item2 { get;private set; }
        public void ChangeDirection(int a,int b)
        {
            Item1 = a; Item2 = b;
        }

    }
}
