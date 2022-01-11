    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2018_2019_Wall_E.Objects
{
  public class Box : GameObject
    {
        int number_;
        string colort;
        string sizet;

        public Box(string color, string size, int number)
        {
           
            colort = color;
            sizet = size;
            number_ = number;
        }

        public override string color
        {
            get
            {
                return colort;
            }
        }

        public override string shape
        {
            get
            {
                return "box";
            }
        }

        public override string size
        {
            get
            {
                return sizet;
            }
        }

        public override int number
        {
            get
            {
                return number_;
            }
        }

        public override bool Mobile()
        {
            if (size != "large")
                return true;
            return false;
        }

        public override bool Takeable()
        {
            if (size == "small")
                return true;
            return false;
        }
    }
}
