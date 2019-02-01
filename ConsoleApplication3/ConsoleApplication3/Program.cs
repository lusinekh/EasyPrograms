using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int grup =0 ;
            int namstudent;
            int mark;

           
            do
            {
                try
                {

                    Console.WriteLine();
                    Console.WriteLine("nermutseq usanoghi hamarn");
                    Console.WriteLine("usanoghi hamarn max @ndunum e 25 arzheq");
                    Console.WriteLine("---------------------------");

                    namstudent = int.Parse(Console.ReadLine());
                    Console.WriteLine("nermutseq usanoghi gnahatakan@");
                    Console.WriteLine("usanoghn karogh e stanal miayn 0 kam 1 tvanshan");
                    mark = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------");


                    if (namstudent < 26 && (mark == 0 || mark == 1))

                    {


                        if (mark == 0)
                        {
                            grup = (grup & ~(1 << namstudent));

                        }

                        if (mark == 1)
                        {
                            grup = (grup | (1 << namstudent));


                        }

                    }

                    else
                    {
                        Console.WriteLine("usanoghi hamarn kam,tvanshann sfal eq nermutsel");


                    }

                    Console.WriteLine("ete cheq uzum @ndatel tsragirn apa esc ic baci cankacats kochak sexmeq");

                }

                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }


            while (Console.ReadKey().Key != ConsoleKey.Escape);

            for (int i = 0; i < 26; i++)

            {
                //Console.WriteLine(i);

                if (((grup & (1 << i)) == 0))
                    Console.WriteLine($"{i} stacel e 0");

                else

                    Console.WriteLine($"{i} stacel e 1");


            }


        }
    }
}
