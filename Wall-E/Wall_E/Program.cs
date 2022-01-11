using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2018_2019_Wall_E.Objects;
using Proyecto_2018_2019_Wall_E;

namespace Wall_E
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Wall_E());
        }
    }

    //new Robot(new GameObject[4, 5],5,"north","black",new Position(0,0)))
 
}
