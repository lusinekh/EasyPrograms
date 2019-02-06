using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tnayinner_verjnakan
{
    class Program
    {


        public static void Show(int[] array)
        {

            for(int i=0;i<array.Length;i++)
            {

                Console.Write($"{array[i]} +\t" );

            }

            Console.WriteLine();

        }




        public static void BableSort(int[] array)
        {

            int temp;

            for(int i=0;i<array.Length;i++)
            {

                for(int j=i;j<array.Length;j++)
                {

                    if(array[i]>array[j])

                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }


                }


            }

        } 




        public static bool BinrSearch(int[] array,int key)
        {
            int frste = 0;
            int laste = array.Length - 1;
            int mid;

            while(frste<laste)
            {

                mid = (frste + laste) / 2;


                if(array[mid]>key)

                {
                    laste = mid - 1;
                }


                else if(array[mid]<key)
                 {

                    frste = mid + 1;


                }
                else

                {
                    return true;

                }

            }


            return false;



        }









        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            Random rd = new Random();

            int[] array = new int[size];

            for(int i=0;i<array.Length;i++)
            {

                array[i] = rd.Next(-100, 100);



            }




            Show(array);
            BableSort(array);
            Show(array);
         Console.WriteLine(BinrSearch(array, 64));

        }
    }
}
