using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int[] digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            bool isAriphmetick = false;
            int step = digitArray[1] - digitArray[0];

            for(int i = 0; i < digitArray.Length -1; i++)
            {
                if (digitArray[i+1]
               == (digitArray[i]
               + step ))
                {
                    isAriphmetick = true;
                }
                else
                {
                    isAriphmetick = false;
                    break;
                }
            }
           
            if(isAriphmetick)
            {
                Console.WriteLine("Арифметична прогрсс");
            }
            else
            {
                Console.WriteLine("Не Арифметична прогрсс");
            }
           
            Console.ReadKey();
        }
    }
}
