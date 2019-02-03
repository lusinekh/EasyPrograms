using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //string color = Console.ReadLine();
            string input = Console.ReadLine();
            bool isDigitPresent = input.All(char.IsDigit);
            Console.WriteLine(isDigitPresent);

            bool isLetterPresent = input.All(char.IsLetter);
            Console.WriteLine(isLetterPresent);

            if (!isDigitPresent)

            {

                bool b = Enum.IsDefined(typeof(ConsoleColor), input);

                Console.WriteLine(b);

                if (!b)
                {
                    Console.WriteLine("The Color do`nt found  in   ConsoleColor Enum  or wrong input");
                }
                else
                {
                    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), input);
                    Console.BackgroundColor = color;
                    Console.Clear();
                  
                }



            }

            else if(!isLetterPresent)
           {

                int inputparse = int.Parse(input);

                bool difindeColor = Enum.IsDefined(typeof(ConsoleColor), inputparse);
                Console.WriteLine(difindeColor);

                if (!difindeColor)
                {
                    Console.WriteLine("The Color do`nt found  in   ConsoleColor Enum   or wrong input");



                }

                else
                {
                    string gateName = Enum.GetName(typeof(ConsoleColor), inputparse);

                    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), gateName);
                    Console.BackgroundColor = color;
                    Console.Clear();

                }

            }

            else
            {

                Console.WriteLine("The input dont valid");


            }
            

        }
    }
}
