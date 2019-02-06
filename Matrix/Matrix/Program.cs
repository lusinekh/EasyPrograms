using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nermutsel int matrixsi erkarutyunn");
            Console.WriteLine("Nermutsel   togheri rkarutyunn");
            int introw = int.Parse(Console.ReadLine());
            Console.WriteLine("Nermutsel   syuneri rkarutyunn");
            int intCol = int.Parse(Console.ReadLine());




            Console.WriteLine("Nermutsel string matrixsi erkarutyunn");
            Console.WriteLine("Nermutsel   togheri rkarutyunn");
            int stringrow = int.Parse(Console.ReadLine());
            Console.WriteLine("Nermutsel   syuneri rkarutyunn");
            int strinColl = int.Parse(Console.ReadLine());

            Console.WriteLine("Nermutsel ConsoleCplor matrixsi erkarutyunn");
            Console.WriteLine("Nermutsel   togheri rkarutyunn");
            int consoleQolorrow = int.Parse(Console.ReadLine());
            Console.WriteLine("Nermutsel   syuneri rkarutyunn");
            int consoleQolorcol = int.Parse(Console.ReadLine());

            Random rd = new Random();


            ////////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            int[,] intArray = new int[introw, intCol];

            for (int i = 0; i < intArray.GetLength(0)
                               ; i++)
            {
                for (int j=0;j<intArray.GetLength(1); j++ )

                {
                    intArray[i, j] = rd.Next(-99, 99);
                    Console.Write($"{intArray[i,j]} ");

                }
                Console.WriteLine();

            }




            //////////////////////////////////////////////////
            ////////////////////////////////////////////////////
            string[] chars = { "Hasmik", "Narine", "Armine", "Ashot", " Lusine", "Hermine", "" };
            string[,] stringArray = new string[stringrow, strinColl];
            for (int i = 0; i < stringArray.GetLength(0); i++)
            {
                for (int j = 0; j < stringArray.GetLength(1); j++)

                {
                    stringArray[i, j]=chars[rd.Next(chars.Length)];
                     Console.Write($"{stringArray[i, j]} ");

                }
                Console.WriteLine();

            }


            /////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////


            ConsoleColor[,] ColorArray = new ConsoleColor[consoleQolorrow, consoleQolorcol];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)

                {
                    ColorArray[i, j] =(ConsoleColor )rd.Next(0, 16);
                   
                

                    Console.ForegroundColor = ColorArray[i,j];
                    Console.Write(ColorArray[i, j]);

                    Console.ResetColor();

                }
                Console.WriteLine();

            }






            Show<int>(intArray);

            /////////////////////
            ///////////////////


            ShowMatrixColors(intArray, ColorArray);



        }




        public  static void Show<T>(T[,] array)

        {
            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j=0;j<array.GetLength(1);j++)

                {

                    Console.Write(array[i, j]);

                }
                Console.WriteLine();
            }   

        }




        public static void ShowMatrixColors(int[,]mx,ConsoleColor[,] bx)
        {
            for(int i=0;i<mx.GetLength(0);i++)
            {
                for(int j=0;j<mx.GetLength(1);j++)

                {

                    Console.ForegroundColor = bx[i, j];
                    Console.Write(mx[i, j]);





                }
                Console.WriteLine();
                Console.ResetColor();
            }





        }




    }
}
