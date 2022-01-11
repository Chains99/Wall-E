using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Actions;
using Proyecto_2018_2019_Wall_E.Flow_Control;
using Proyecto_2018_2019_Wall_E.Objects;
using Proyecto_2018_2019_Wall_E.Operators;
using Proyecto_2018_2019_Wall_E.Sensors;

namespace Proyecto_2018_2019_Wall_E
{
   public class Instructions_Dictionary
    {
         static Dictionary<string, Instructions> keys = new Dictionary<string, Instructions>();
         public static Instructions GetValue(string key)
        {
            Instructions value;
            if (keys.TryGetValue(key, out value))
                return value;
            return null;    
        } 
        public static void Agregate()
        {   //actions
            keys.Add("forward", new Forward());
            keys.Add("backward", new Backward());
            keys.Add("right", new Right());
            keys.Add("left", new Left());
            keys.Add("drop", new Drop());
            //numbers
            keys.Add("number", new Number());
            keys.Add("zero", new Zero());
            keys.Add("one", new One());
            //operators
            keys.Add("add", new Sum());
            keys.Add("sub", new Substraction());
            keys.Add("mul", new Multiplication());
            keys.Add("div", new Division());
            keys.Add("mod", new Module());
            keys.Add("inc", new Increase());
            keys.Add("dec", new Decrease());
            keys.Add("land", new LAnd());
            keys.Add("lor", new Lor());
            keys.Add("lxor", new LXor());
            keys.Add("lnot", new LNot());
            keys.Add("and", new And());
            keys.Add("or", new Or());
            keys.Add("not", new Not());
            keys.Add("eq", new Equals_());
            keys.Add("neq", new NotEquals());
            keys.Add("lt", new LT());
            keys.Add("leq", new LeQ());
            keys.Add("gt", new GT());
            keys.Add("geq", new GEQ());
            keys.Add("ternary", new Ternary());
            //
            keys.Add("getAt", new GetAt());
            keys.Add("setAt", new SetAt());
            //sensors
            keys.Add("distance", new Ultrasonic());
            keys.Add("color", new WebCam());
            keys.Add("shape", new Kinect());
            keys.Add("code", new BarbacodeScanner());
            keys.Add("loaded", new Weight());
            keys.Add("time", new Chronometer());
            keys.Add("direction", new Compass());
            //controller's flow
            keys.Add("NE", new NorthEast());
            keys.Add("SE", new SouthEast());
            keys.Add("NW", new NorthWest());
            keys.Add("SW", new SouthWest());
            keys.Add("TS", new T_South());
            keys.Add("TE", new T_East());
            keys.Add("TN", new T_North());
            keys.Add("TW", new T_West());
            keys.Add("branch", new Conditionals());
            //routines
            keys.Add("call", new Call());
            keys.Add("routine", new Routine());
            keys.Add("recCall", new RecCall());
            //program's instructions
            keys.Add("start", new Start());
            keys.Add("return", new Return());
            keys.Add("print", new Print());
            //get
            keys.Add("getA", new Get('A'));
            keys.Add("getB", new Get('B'));
            keys.Add("getC", new Get('C'));
            keys.Add("getD", new Get('D'));
            keys.Add("getE", new Get('E'));
            keys.Add("getF", new Get('F'));
            keys.Add("getG", new Get('G'));
            keys.Add("getH", new Get('H'));
            keys.Add("getI", new Get('I'));
            keys.Add("getJ", new Get('J'));
            keys.Add("getK", new Get('K'));
            keys.Add("getL", new Get('L'));
            keys.Add("getM", new Get('M'));
            keys.Add("getN", new Get('N'));
            keys.Add("getO", new Get('O'));
            keys.Add("getP", new Get('P'));
            keys.Add("getQ", new Get('Q'));
            keys.Add("getR", new Get('R'));
            keys.Add("getS", new Get('S'));
            keys.Add("getT", new Get('T'));
            keys.Add("getU", new Get('U'));
            keys.Add("getV", new Get('V'));
            keys.Add("getW", new Get('W'));
            keys.Add("getX", new Get('X'));
            keys.Add("getY", new Get('Y'));
            keys.Add("getZ", new Get('Z'));
            //set
            keys.Add("setA", new Set('A'));
            keys.Add("setB", new Set('B'));
            keys.Add("setC", new Set('C'));
            keys.Add("setD", new Set('D'));
            keys.Add("setE", new Set('E'));
            keys.Add("setF", new Set('F'));
            keys.Add("setG", new Set('G'));
            keys.Add("setH", new Set('H'));
            keys.Add("setI", new Set('I'));
            keys.Add("setJ", new Set('J'));
            keys.Add("setK", new Set('K'));
            keys.Add("setL", new Set('L'));
            keys.Add("setM", new Set('M'));
            keys.Add("setN", new Set('N'));
            keys.Add("setO", new Set('O'));
            keys.Add("setP", new Set('P'));
            keys.Add("setQ", new Set('Q'));
            keys.Add("setR", new Set('R'));
            keys.Add("setS", new Set('S'));
            keys.Add("setT", new Set('T'));
            keys.Add("setU", new Set('U'));
            keys.Add("setV", new Set('V'));
            keys.Add("setW", new Set('W'));
            keys.Add("setX", new Set('X'));
            keys.Add("setY", new Set('Y'));
            keys.Add("setZ", new Set('Z'));
            //autoguide
            keys.Add("autoguidewesteast", new Autoguide("westeast"));
            keys.Add("autoguidenorthsouth", new Autoguide("northsouth"));








        }                                                                            

         

    }
}
