using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionRecursion
{
    class Program
    {

        public static int GetGreatestDivisor(int x,int y)
        {
            if (y == 0)

                return x;
            else

                return GetGreatestDivisor(y, x % y);


        }



        public static int SumNumber(int number)

        {
            if (number == 1)
                return 1;
            else

            {


                return SumNumber(number - 1) + number;


            }

        }



        public static void ShowNumber(int n)

        {
            Console.WriteLine(n);
            if (n<1)

            {

                return;
            }
            ShowNumber(n - 1);
           



        }



        public static void InversString(string value)

        {
            if(value.Length==0)

            {

                return;
            }
            else

            {

                InversString(value.Substring(0, value.Length - 1));
                Console.WriteLine(value[0]);


            }



        }


        public static void SHOWREVERS(string s)
        {

            if (s.Length == 0)

            { return; }


            Console.WriteLine(s[s.Length - 1]);
            SHOWREVERS(s.Substring(0, s.Length-1));
         



        }




        public static void SHOWstring(string s)
        {

            if (s.Length == 0)

            { return; }



            SHOWstring(s.Substring(0, s.Length - 1));
            Console.WriteLine(s[s.Length - 1]);



        }



        public static void SubFrstElementRev(string s)
        {
            int xb = 1;
            if (s.Length == 0)

            { return; }



            SubFrstElementRev(s.Substring(1, s.Length - 1));
            Console.WriteLine(s[0]);
           



        }





        public static void SubFrstElement(string s)
        {

            int xb = 1;
            if (s.Length == 0)

            { return; }


            Console.WriteLine(s[0]);
            SubFrstElement(s.Substring(1, s.Length - 1));
            




        }












        public static int GetNthFibonacci_Rec(int number)
        
            
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return GetNthFibonacci_Rec(number - 2) + GetNthFibonacci_Rec(number - 1);
            }
        }
    













        static void Main(string[] args)
        {


            //Console.WriteLine(GetGreatestDivisor(21, 7));

            //Console.WriteLine(GetNthFibonacci_Rec(45));
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(SumNumber(3));

            // ShowNumber(5);

            // InversString("lus");
            //string value = "us";
            //Console.WriteLine(value.Substring(1, value.Length - 1));
            //SHOWREVERS("lus");


            ShowNumber(5);


        }
    }
}
