using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2018_2019_Wall_E.Objects
{
   public abstract class GameObject:IValue,ITakeable,IMobile
    {
       protected readonly string[] colors={"red","yellow","green,blue","brown","black","white"};
       protected readonly string[] shapes = { "nothing", "sphere", "box", "plant", "robot" };
       protected readonly string[] sizes ={"empty","small","medium","large"};

         
      
       public abstract  string color { get; }
       public  abstract string shape { get;  }
       public abstract string size { get;  }
       public abstract int number { get;  }

        public int color_()
        {
            return Array.IndexOf(colors, color);
        }

        public int shape_()
        {
            return Array.IndexOf(shapes, shape);
        }

        public int size_()
        {
            return Array.IndexOf(sizes,size);
        }

        public abstract bool Takeable();

        public abstract bool Mobile();
        
    }
}
                                                