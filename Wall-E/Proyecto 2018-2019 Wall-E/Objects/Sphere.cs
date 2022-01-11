using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2018_2019_Wall_E.Objects
{
   public class Sphere : GameObject
    {

        string colort;
        string sizet;
        int number_;
        public Sphere (string color,string size,int number)
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
                return "sphere";
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

        public override bool Takeable()
        {
            if (size == "small")
                return true;
            return false;
        }

        public override bool Mobile()
        {
            return true;
        }
    }
}
