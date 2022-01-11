using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;


namespace Proyecto_2018_2019_Wall_E
{
    public class Game
    {
        GameObject[,] map;
        List<Robot> robots;
        List<int> order;
        Robot On;
        public Position positionOn;
    
    
        public int GetRound { get; private set; }
        public bool Advance { get; private set; }
        public string LastValue { get { return On.value; } }
        public string GetRobotName { get { return On.Name; } }
        public int Count { get { return robots.Count; } }
      
        int indexrobot = -1;
        public int matrixOnHeight { get { return On.consumer.Height; } }
        public int matrixOnWidth { get { return On.consumer.Width; } }
            
        public Game(int files,int cols)
        {
            map = new GameObject[files, cols];
            GetRound = 1;
            this.files = files;
            this.cols = cols;
            robots = new List<Robot>();
            order = new List<int>();
            positionOn = null;
            On = null;
            Advance = false;
           
        }
        static Game()
        {
            Instructions_Dictionary.Agregate();
        } 
        public int files { get; private set; }
        public int cols { get; private set; }
        public bool WasCall()
        {
           if(On.isCall)
            { On.isCall = false; return true; }
            return false;
        }
        public GameObject inside()
        {
            return On.inside;
        }


        public void stop()
        {
            GetRound = 1;
            for (int i = 0; i < robots.Count; i++)
            {
                robots[i].BottonStop();
            }
        }
        public Position ActualMatrixPOsition()
        {
            return new Position(On.consumer.i, On.consumer.j);
        }
        public GameObject obj(int i,int j)
        {
            if (!(i >= 0 && i < map.GetLength(0) && j >= 0 && j < map.GetLength(1)))
                throw new Exception("Index out of range");
            return map[i, j];
        }
        public void AddRobot(int i, int j,string direction,string color,int number,string name)
        {
            if (map[i, j] == null)
            {
                
                Robot a = new Robot(map, number, direction, color, new Position(i, j),name);
               
                map[i, j] = a;
                order.Add(robots.Count);
                robots.Add(a);
                Random_(order);
                indexrobot = 0;
            }
         
        }
        public void AddObject(int i, int j,GameObject gameobject)
        {
        
             if(!(map[i,j] is Robot)) 
             map[i, j] =gameobject ;
        }
        public  Instructions  InstinConsum(int i,int j)
        {
            return On.InstPos(i, j, On.consumer.GetIndexRoutine); 
        }



        public void DebugBotton()
        {

            Advance = false;
            On = robots[order[indexrobot]];
            On.Debugroutine();

            if (On.finished)
            {
                indexrobot++;
                On.finished = false;
                if (indexrobot == order.Count)
                { Random_(order); indexrobot = 0; Advance = true; GetRound++; }
            }
        }

        private void Random_(List<int>posit)
        {
            Random random = new Random();
            int count = posit.Count ;
            int r;

            for (int k = count - 1;  k >= 1; k--)
            {
                r = random.Next(0, k + 1);
                int temp = posit[r];
                posit[r] = posit[k];
                posit[k] = temp;
            }
        }

        
    }
}
