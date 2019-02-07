using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheManIsRun
{

    public class TheMan

    {
        private int nm;
        private int invokeCount;
        private int maxCount;


        public TheMan(int count)
        {
            invokeCount = 0;
            maxCount = count;
            nm = 10;

        }


        ConsoleColor[,] a = new ConsoleColor[10, 10];

        public void FillMatrix()
        {
            for (int i = 0; i < a.GetLength(0); i++)

            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ConsoleColor.Black;
                    Console.BackgroundColor = a[i, j];


                }



            }
        }



        public  void RotatateRight()
        {
            FillMatrix();
            var size = a.GetLength(0);
            var divsize = a.GetLength(0) / 2;
            for (int i = 0; i < a.GetLength(0); i++)

            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (((j > 1 && j < a.GetLength(0) - 2) && ((i == 0) || (i == 9))) || ((j == 1 || j == (size - 2)) && ((i == 1) || (i == 8))) ||
                       ((j == 0 || j == (divsize - 2) || j == (divsize + 1) || j == (size - 1) || j == (divsize + 2)) && i == 2) ||

                        ((j == 0 || j == (size - 1)) && (((i == 3)) || (i == 4) || (i == 6) || (i == 7))) || (((j == 0) || (j == size - 1) || (j == divsize - 1)
                        || (j == divsize)) && (i == 5)) || ((j == 0 || j == (size - 1) || j == divsize + 1) && (i == 3))

                        )

                    {
                        a[i, j] = ConsoleColor.Green;
                        Console.BackgroundColor = a[i, j];
                        Console.Write("  ");

                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.Write("  ");


                    }

                }


                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }



        public void DrowProtopyteMen()
        {
            FillMatrix();

           
            var size = a.GetLength(0);
            var divsize = a.GetLength(0) / 2;
            for (int i = 0; i < a.GetLength(0); i++)

            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (((j > 1 && j < a.GetLength(0) - 2) && ((i == 0) || (i == 9))) || ((j == 1 || j == (size - 2)) && ((i == 1) || (i == 8))) ||
                       ((j == 0 || j == (size - 1)) && i == 2) ||

                        ((j == 0 || j == (size - 1)) && (((i == 3)) || (i == 5) || (i == 6) || (i == 7))) || (((j == 0) || (j == size - 1) || (j == divsize - 1)
                        || (j == divsize)) && (i == 4)) || ((j == 0 || j == (size - 1)) && (i == 3)) || ((j == (divsize - 2) || (j == size - 3) || (j == size - 4)) && (i == 7))

                        || ((j == size - 4) && (i == 6))

                        )

                    {
                        a[i, j] = ConsoleColor.Green;
                        Console.BackgroundColor = a[i, j];
                        Console.Write("  ");

                    }

                    else
                    {
                        Console.BackgroundColor = a[i, j];

                        Console.Write("  ");


                    }

                }


                Console.WriteLine();
            }
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




        }




        public void DrowMen(object state)

        {
            ConsoleColor ForgraundColor = Console.BackgroundColor;

            AutoResetEvent autoEvent = (AutoResetEvent)state;


            Console.CursorTop = 30 + nm;
            //Console.SetCursorPosition(10, nm);
            RotatateRight();
            Console.CursorTop = nm+1;


            DrowProtopyteMen();

           ++invokeCount;

            if (invokeCount == maxCount)
            {
                // Reset the counter and signal the waiting thread.
                invokeCount = 0;
                autoEvent.Set();
            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            nm += 20;
        }

    }











    class Program
    {
        static void Main(string[] args)
        {
            // ConsoleColor defaultC = Console.ForegroundColor;
            var autoEvent = new AutoResetEvent(false);
            TheMan b = new TheMan(10);
            //b.FillMatrix();
            b.DrowProtopyteMen();
            b.RotatateRight();
            int n = 0;


            var stateTimer = new Timer(b.DrowMen,
                                           autoEvent, 1000, 1500);
            Console.ForegroundColor =
                      ConsoleColor.Yellow;
            autoEvent.WaitOne();
            stateTimer.Change(0, 500);
            n++;




          



















        }
    }

}