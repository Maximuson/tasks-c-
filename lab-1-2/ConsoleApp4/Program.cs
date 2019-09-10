using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х ");
            int x =  int.Parse( Console.ReadLine());

            double result = 2 * (Math.Pow(x, 4)) 
                - (3 * Math.Pow(x, 3))
                + (4* Math.Pow(x, 2))
                - (5*x)
                +6;

            Console.WriteLine(result);
            Console.ReadKey();

            //Task 2
            Console.Write("Введите nn ");
            int nn = int.Parse(Console.ReadLine());

            Console.Write("Введите nk ");
            int nk = int.Parse(Console.ReadLine());
            double sum = 1.0;
            if (nn < nk && nn < 0) {
                for (int i = nn; i <= nk; i++)
                {
                    double ak = (((Math.Pow(-1, nn) * nn + 8))
                        / 2 * Math.Pow(nn, 2) + nk + 7);
                    sum = sum * ak;
                }
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("nk больше nn");
            }
          
            Console.ReadKey();
        }
    }
}
