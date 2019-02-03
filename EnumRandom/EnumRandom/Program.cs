using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumRandom
{
  public enum  Student
        {
            bad=0,
            good=5,
            verygood=6,
            verygoodd,

        }

class Program
    {
        static void Main(string[] args)
        {

            Array values = Enum.GetValues(typeof(Student));
            Random random = new Random();
          


            Student[] st = new Student[5];


            for (int i = 0; i < st.Length; i++)

            {

                st[i] = (Student)values.GetValue(random.Next(values.Length));
                Console.WriteLine($"{st[i]} \t {(int)st[i]}");


            }

        }
    }
}
