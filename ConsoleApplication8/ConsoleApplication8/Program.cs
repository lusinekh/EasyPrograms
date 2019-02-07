using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        public static void DrowMatrix(ConsoleColor[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)

            {
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    Console.BackgroundColor = a[i, j];

                    Console.Write("  ");

                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.ResetColor();
        }



        public static void FilColorMatrx(ConsoleColor[,] a)
        {
            Random rd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)

            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ConsoleColor.Green;

                }
            }
        }


        public static void Drowface(ConsoleColor[,] a)
        {
            var size = a.GetLength(0);
            var divsize = a.GetLength(0) / 2;
            Random rd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)

            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(((j>1 && j< a.GetLength(0)-2)&&((i==0)  ||(i==9) ))    || ((j==1 || j == (size-2))  &&(( i==1) ||(i==8)   )) ||
                       ((j==0 ||j== (divsize - 2)  || j==(divsize+1)  || j==(size-1) || j==(divsize + 2)    )   && i==2) ||
                        
                        ((j==0 || j==(size-1))&& (((i==3) ) || (i==4) ||(i==6) ||(i==7)  )) || (((j==0) || (j==size-1) || (j==divsize-1) 
                        ||(j==divsize)) && (i == 5)) ||((j==0 || j== (size - 1) || j==divsize+1) &&(i==3)   )

                        ) 
                        
                        {
                        a[i, j] = ConsoleColor.Red;
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
        }





        static void Main(string[] args)
        {
            ConsoleColor[,] color = new ConsoleColor[10, 10];
            FilColorMatrx(color);
            DrowMatrix(color);
            Drowface(color);

            //int a = 10000;
            //int b = 1000000;
            //int resant = checked(a * b);
            //Console.WriteLine(resant);

            ////checked
            ////{

            ////    int sum = a + b;
            ////    Console.WriteLine(sum);
            ////    int result = a * b;
            ////    Console.WriteLine(resant);
            ////}



            //int sum = a + b;
            //Console.WriteLine(sum);
            //int result = a * b;
            //Console.WriteLine(resant);



        }
    }
    }
