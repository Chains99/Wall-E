using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2018_2019_Wall_E.Objects;
using Proyecto_2018_2019_Wall_E.Flow_Control;

namespace Proyecto_2018_2019_Wall_E
{
    public class Instructions_Consumer : IEnumerable<Instructions>
    {
        Instructions[,] matrix;
        public int i { get; private set; }
        public int j { get; private set; }
        public int GetIndexRoutine { get; private set; }
        Instructions inst;
        public Direction direction;
        Robot robot;
        IEnumerator<Instructions> enumerator;

        int[] registers;


        public Instructions_Consumer(Instructions[,] matrix, Robot robot, int indexroutine)
        {
            GetIndexRoutine = indexroutine;
            this.matrix = matrix;
            registers = new int[26];
            StartPosition();
            direction = new Direction(1, 0);
            this.robot = robot;
            enumerator = GetEnumerator();
            
        }
        public void StartPosition()
        {

            bool a = false;
            for (int k = 0; k < matrix.GetLength(0); k++)
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (matrix[k, l] is Start)
                    {

                        i = k; j = l;
                        a = !a;


                    }
                }
            if (!a)
                throw new Exception("start");//mas d un start o aunsencia del start
        }
        public void AutoGuide()
        {
            AutoGuide(i,j);
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                Instructions ins = matrix[0, x];

                if (ins is Autoguide && (ins as Autoguide).GetDirection == "northsouth")
                {
                    for (int y = 0; y < matrix.GetLength(1) - 1; y++)
                    {
                        matrix[y, x] = null;
                        if (!(matrix[y + 1, x] is Autoguide) && matrix[y + 1, x] != null)
                        {
                            matrix[y, x] = new Return(); break;
                        }
                    }
                }
            }
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                Instructions ins = matrix[matrix.GetLength(0) - 1, x];

                if (ins is Autoguide && (ins as Autoguide).GetDirection == "northsouth")
                {
                    for (int y = matrix.GetLength(0) - 1; y > 0; y--)
                    {
                        matrix[y, x] = null;
                        if (!(matrix[y - 1, x] is Autoguide) && matrix[y - 1, x] != null)
                        {
                            matrix[y, x] = new Return(); break;
                        }
                    }
                }
            }
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                Instructions ins = matrix[y, 0];

                if (ins is Autoguide && (ins as Autoguide).GetDirection == "westeast")
                {
                    for (int x = 0; x < matrix.GetLength(1) - 1; x--)
                    {
                        matrix[y, x] = null;
                        if (!(matrix[y, x + 1] is Autoguide) && matrix[y, x + 1] != null)
                        {
                            matrix[y, x] = new Return(); break;
                        }
                    }
                }
            }
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                Instructions ins = matrix[y, matrix.GetLength(1) - 1];

                if (ins is Autoguide && (ins as Autoguide).GetDirection == "westeast")
                {
                    for (int x = matrix.GetLength(1) - 1; x > 0; x--)
                    {
                        matrix[y, x] = null;
                        if (!(matrix[y, x - 1] is Autoguide) && matrix[y, x - 1] != null)
                        {
                            matrix[y, x] = new Return(); break;
                        }
                    }
                }
            }
        
    }
        private void AutoGuide(int l, int k)
        {
            for (; l >= 0 && l < matrix.GetLength(0) && k >= 0 && k < matrix.GetLength(1);
                l += direction.Item1, k += direction.Item2)
            {
                Instructions ins = matrix[l, k];
                if (ins is NorthEast || ins is NorthWest || ins is SouthEast || ins is SouthWest)
                    ins.Execute(robot, this);
                else if (ins is T_East)
                {
                    if (direction.Item2 == 0)
                        direction.ChangeDirection(0, 1);
                    else if (direction.Item2 == -1)
                    {
                        direction.ChangeDirection(1, 0); AutoGuide(l + 1, k);
                        direction.ChangeDirection(-1, 0); AutoGuide(l - 1, k);
                        return;
                    }
                }
                else if (ins is T_North)
                {
                    if (direction.Item1 == 0)
                        direction.ChangeDirection(-1, 0);
                    else if (direction.Item1 == 1)
                    {
                        direction.ChangeDirection(0, 1); AutoGuide(l, k + 1);
                        direction.ChangeDirection(0, -1); AutoGuide(l, k - 1);
                        return;
                    }
                }
                else if (ins is T_South)
                {
                    if (direction.Item1 == 0)
                        direction.ChangeDirection(1, 0);
                    else if (direction.Item1 == -1)
                    {
                        direction.ChangeDirection(0, 1); AutoGuide(l, k + 1);
                        direction.ChangeDirection(0, -1); AutoGuide(l, k - 1);
                        return;
                    }
                }
                else if (ins is T_West)
                {
                    if (direction.Item2 == 0)
                        direction.ChangeDirection(0, 1);
                    else
                    {
                        direction.ChangeDirection(1, 0); AutoGuide(l + 1, k);
                        direction.ChangeDirection(-1, 0); AutoGuide(l - 1, k);
                        return;
                    }
                }
                else if (ins is Conditionals)
                {
                    if (direction.Item1 == 0)
                    {
                        direction.ChangeDirection(1, 0); AutoGuide(l + 1, k);
                        direction.ChangeDirection(-1, 0); AutoGuide(l - 1, k);
                        return;
                    }

                    else
                    {
                        direction.ChangeDirection(0, 1); AutoGuide(l, k + 1);
                        direction.ChangeDirection(0, -1); AutoGuide(l, k - 1);
                        return;
                    }
                }
                else if (ins is Return)
                    return;
                else if (ins == null)
                {
                    if (direction.Item1 == 0)
                        matrix[l, k] = new Autoguide("westeast");
                    else
                        matrix[l, k] = new Autoguide("northsouth");

                }
                else if (ins is Autoguide)
                {
                    string dirct = (ins as Autoguide).GetDirection;
                    if ((direction.Item1 == 0 && dirct == "westeast") || (direction.Item2 == 0 && dirct == "northsouth"))
                        return;
                }



            }
        }
        
          





        
        public int Height { get { return matrix.GetLength(0); } }
        public int Width { get { return matrix.GetLength(1); } }


        public void Get(char letter)
        {
            robot.Push(registers[letter - 65]);
        }
        public void Set(char letter)
        {
            registers[letter - 65] = robot.Pop();
        }
        public void Execute()
        {
            while (GetEnumerator().MoveNext())
            {
                Instructions inst = GetEnumerator().Current;
                if (inst != null)
                    inst.Execute(robot, this);
            }
        }
        public void Debug()
        {

            if (enumerator.MoveNext())
            {

                if (inst != null)
                    inst.Execute(robot, this);
            }

        }

        public IEnumerator<Instructions> GetEnumerator()
        {

            for (; i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1); i += direction.Item1, j += direction.Item2)
            {
                inst = matrix[i, j];
                yield return matrix[i, j];
            }
            new Return().Execute(robot, this);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


