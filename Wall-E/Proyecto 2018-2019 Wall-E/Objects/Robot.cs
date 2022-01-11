using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                      
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.RobotObjects;

namespace Proyecto_2018_2019_Wall_E.Objects
{  
    public class Robot : GameObject
    {
        Stack<int> pila;    
        int[]lineal_memory;
        List<Instructions[,]> routineslist;
        List<int> numberInst;
        int timer;
        public bool isCall { get;  set; }
        public bool finished { get; set; }
        public string Name { get; private set; }
        public string value { get { if (pila.Count == 0) return "Empty"; return pila.Peek().ToString(); } }
        public string GetDirection { get; private set; }
         
        public GameObject inside { get; private set; }
        Direction direction;
        Position position;
        int number_;
        GameObject[,] map;
        string[] directions = { "north", "east", "south", "west" };
        string direction_;
        Stack<Instructions_Consumer> executions;
        string color1;
        public Instructions_Consumer consumer;
        
 
                     
        public Robot(GameObject[,] map, int number,string direction,string color,Position position,string name)
        {
            isCall = true;
            numberInst = new List<int>();
            timer = 0;
            Name = name;
            finished = false;
            color1 = color;
            this.map = map;
            number_= number;
            pila = new Stack<int>();
            lineal_memory = new int[1000000];
            routineslist = new List<Instructions[,]>();
            GetDirection = direction;
            this.direction = new Direction(direction);
            this.direction_ = direction;
            this.position = new Position(position.Item1, position.Item2);
            inside=null;
            executions = new Stack<Instructions_Consumer>();
            routineslist.Add(new Instructions[10, 20]);
            numberInst.Add(0);
            
        }
        public void BottonStop()
        {
            if (executions.Count != 0)
            { executions.Clear();
                executions.Push(new Instructions_Consumer(routineslist[0], this, 0)); }
        }
        
       
        public void GetAt()
        {  
            int a = pila.Pop();
            if (a < 0 || a >= lineal_memory.Length)
                throw new Exception("Index out of range");
            pila.Push(lineal_memory[a]);
        }
        public void SetAt()
        {
            if (pila.Count < 2)
                throw new Exception("The robot need at least two valors in the stack");
            int a = pila.Pop();
            if (a < 0 || a >= lineal_memory.Length)
                throw new Exception("Index out of range");
            int b = pila.Pop();
            lineal_memory[a] = b;
        }
        public void Push(int a)
        {
            pila.Push(a); 
        }
        public int Pop()
        {
            if (pila.Count == 0)
                throw new Exception("Robot's stack is empty");
          return pila.Pop();
        }
        public int Peek()
        {
            if (pila.Count == 0)
                throw new Exception("Robot's stack is empty");
            return pila.Peek();
        }
        public int MatrixHeight(int index)
        {
            if (index < 0 || index >= routineslist.Count)
                throw new Exception("Index out of range");
            return routineslist[index].GetLength(0);
        }
        public int MatrixWidth(int index)
        {
            if (index < 0 || index >= routineslist.Count)
                throw new Exception("Index out of range");
            return routineslist[index].GetLength(1);
        }
        public void AddRoutine(int rows,int cols)
        {   
            
            routineslist.Add(new Instructions[rows, cols]);
            numberInst.Add(0);

        }
        public int GetNInstructions(int index)
        {
            if (index < 0 || index >= numberInst.Count)
                throw new Exception("Index out of range");
            return numberInst[index]; 
        }
        public void AddInstructions(Instructions inst,int i,int j,int index)// permite agregar o cambiar las instrucciones definidas dentro
        {
            if (index < 0 || index >= routineslist.Count)
                throw new Exception("Index out of range");
            Instructions[,] matrix = routineslist[index];
            if (i < 0 || i >= matrix.GetLength(0) || j < 0 || j >= matrix.GetLength(1))
                throw new Exception("Index out of range");
            if (routineslist[index][i, j] == null) numberInst[index]++;
            routineslist[index][i, j] = inst;
            
        }
        public int Count()// m devuelve el entero con la ctdad d rutinas
        {
         
           return routineslist.Count; 

        }
        public Instructions InstPos(int i, int j, int index)//devuelve la instruccion dada la posicion
        {
            if (routineslist.Count != 0)
            {
                if (index < 0 || index >= routineslist.Count)
                    throw new Exception("Index out of range");
                Instructions[,] matrix = routineslist[index];
                if (i < 0 || i >= matrix.GetLength(0) || j < 0 || j >= matrix.GetLength(1))
                    throw new Exception("Index out of range");
                return routineslist[index][i, j];
            }
            return null;
        }
        public void ConfigRoutine(int index,int files,int cols) // permite configuras una matrix de instruccion ya definida
        {
            if (index < 0 || index >= routineslist.Count)
                throw new Exception("Index out of range");
            routineslist[index] = new Instructions[files, cols];
            numberInst[index] = 0;
        }
        public void Autoguide()
        {
            for (int i = 0; i < routineslist.Count; i++)
            {
                new Instructions_Consumer(routineslist[i], this, i).AutoGuide();
            }
        }



        
        public void Debugroutine()
        {
            if (routineslist.Count != 0)
            {
                if (executions.Count != 0)
                { consumer = executions.Peek(); executions.Peek().Debug(); }
                else { consumer = new Instructions_Consumer(routineslist[0], this, 0); executions.Push(consumer); executions.Peek().Debug(); }
            }
        }
        

      
        public override string color
        {
            get { return color1; }
          
           
        }

        public override string shape
        {
            get{return "robot";}

           
        }

        public override string size
        {
            get{return "large";}

           
        }
               
        public override int number
        {
            get{return number_;}

        }
        public void CallRoutine()
        {
            int a = pila.Pop();
            if (a != consumer.GetIndexRoutine)
                isCall = true;
            if(a<0 || a>=routineslist.Count)
                throw new Exception("Subroutine's Index Out of range");
            executions.Push(new Instructions_Consumer( routineslist[a],this,a));
            consumer = executions.Peek();
        }
        public void ReturnRoutine()
        {
            executions.Pop();
            if (executions.Count == 0)
            { executions.Push(new Instructions_Consumer(routineslist[0], this, 0)); finished = true; timer++; }
            else executions.Peek().Debug();

        }
        public void Forward()
        {
            timer++;
            finished = true;
            int a = position.Item1 + direction.Item1;
            int b = position.Item2 + direction.Item2;
            int c = a + direction.Item1;
            int d = b + direction.Item2;
            if (a >= 0 && a < map.GetLength(0) && b >= 0 && b < map.GetLength(1))
            {
                if (map[a, b] != null)
                {
                    if (map[a, b].Takeable() && inside == null)
                    {
                        inside = map[a, b]; MoveAt(position.Item1, position.Item2, a, b, this);
                        return;   
                    }
                    else if (c >= 0 && c < map.GetLength(0) && d >= 0 && d < map.GetLength(1) && map[c, d] == null)
                    {
                        if ((map[a, b] is Box || map[a, b] is Sphere) && map[a, b].Mobile())
                        { MoveAt(a, b, c, d, map[a, b]); MoveAt(position.Item1, position.Item2, a, b, this);return; }

                    }
                    while (c >= 0 && c < map.GetLength(0) && d >= 0 && d < map.GetLength(1))
                    {
                        if (map[c, d] != null && map[c, d] is Sphere && map[c, d].size != "large")
                        {
                            c += direction.Item1;
                            d += direction.Item2;
                        }

                        else if (map[c, d] == null)
                        {

                            while (c != position.Item1 - direction.Item1 || b != position.Item2 - direction.Item2)
                            {
                                MoveAt(c - direction.Item1, d - direction.Item2, c, d, map[c - direction.Item1, d - direction.Item2]);
                                c -= direction.Item1;
                                d -= direction.Item2;
                            }
                            break;

                        }
                        else break;

                    }
                }
                else MoveAt(position.Item1, position.Item2, a, b, this);

            }
        }
        public void MoveAt(int f1,int c1,int f2,int c2,GameObject o)
        {
            map[f2,c2] = o;
            map[f1, c1] = null;
            if (o.Equals(this))
            { position.ChangePosition(f2, c2); }
           
        } 

        public void Backward()
        {
            timer++;
            finished = true;
            int a = position.Item1 - direction.Item1;
            int b = position.Item1 - direction.Item2;

            if (a >= 0 && a < map.GetLength(0) && b >= 0 && b < map.GetLength(1) && map[a, b] == null)
                { MoveAt(position.Item1, position.Item2, a, b, this); }
        }
        public void Drop()
        {
            timer++;
            finished = true;
            int a = position.Item1 + direction.Item1;
            int b = position.Item2 + direction.Item2;
            if(inside!=null)
            {
                if (a >= 0 && a < map.GetLength(0) && b >= 0 && b < map.GetLength(1) && map[a, b] == null)
                { map[a, b] = inside; inside = null; }
                    
            }
        }
        public void Left()
        {
            finished = true;
            timer++;
            if (direction.Item1 == 1)
            { direction.ChangeDirection(0, 1); GetDirection = "east"; }
            else if (direction.Item1 == -1)
            { direction.ChangeDirection(0, -1);GetDirection = "west"; }
            else if (direction.Item2 == 1)
            { direction.ChangeDirection(-1,0);GetDirection = "north"; }
            else { direction.ChangeDirection(1, 0); GetDirection="south"; }

        }
        public void Right()
        {
            finished = true;
            timer++;
          if(direction.Item1==1)
            { direction.ChangeDirection(0, -1);GetDirection = "west"; }
          else if(direction.Item1==-1)
            { direction.ChangeDirection(0, 1); GetDirection = "east"; }
          else if(direction.Item2==1)
            { direction.ChangeDirection(1, 0); GetDirection = "south"; }
            else { direction.ChangeDirection(-1,0); GetDirection = "north"; }

        }

        public void WebCam()
        {
            int a = position.Item1 + direction.Item1;
            int b = position.Item2 + direction.Item2;
            if (a >= 0 && a < map.GetLength(0) && b >= 0 && b < map.GetLength(1))
            {
                if (map[a, b] != null)
                    pila.Push(map[a, b].color_());
                else pila.Push(0);
            }
            else pila.Push(0);

        }
        public void Kinect()
        {
            int a = position.Item1 + direction.Item1;
            int b = position.Item2 + direction.Item2;
            if (a >= 0 && a < map.GetLength(0) && b >= 0 && b < map.GetLength(1))
            {
                if (map[a, b] != null)
                    pila.Push(map[a, b].shape_());
                else pila.Push(0);
            }
            else pila.Push(0);

        }
        public void BarbacodeScanner()
        {
            int a = position.Item1 + direction.Item1;
            int b = position.Item2 + direction.Item2;
            if (a >= 0 && a < map.GetLength(0) && b >= 0 && b < map.GetLength(1))
            {
                if (map[a, b] != null)
                    pila.Push(map[a, b].number);
                else pila.Push(0);
            }
            else pila.Push(0);
        }
        public void Compass()
        {
            pila.Push(Array.IndexOf(directions, direction_));
        }
        public void Weight()
        {
            if (inside == null) pila.Push(0);
            else pila.Push(1);
        }
        public void Ultrasonic()
        {
            int d1 = direction.Item1;
            int d2 = direction.Item2;
            int a = 0;
            if (direction.Item1 == 0)
            {
                for (int i = position.Item2+d2;i>=0 &&i < map.GetLength(1); i+=d2)
                    if (map[0, i] == null)
                           a++;
                pila.Push(a);
            }
            else
            {
                for (int i = position.Item1+d1; i>=0 &&i < map.GetLength(0); i+=direction.Item1)
                    if (map[i, 0] == null)
                        a++;
                pila.Push(a);
            }

        }
        
        public void Chronometer()
        {
            Push(timer);
        }

        public override bool Takeable()
        {
            return false;
        }

        public override bool Mobile()
        {
            return false;
        }
    }
}
