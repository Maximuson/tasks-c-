using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] graph = new int[] { 1, 2, 3,2,4,5 };
            int countIncrement = 0;
            int countDecrement = 0;
            bool isIncrementing = false;
            bool isDecrementing = false;

            for(int i =0; i<graph.Length-2; i++)
            {
                if(graph[i+1] > graph[i] && isIncrementing == false)
                {
                    isDecrementing = false;
                    isIncrementing = true;
                    countIncrement++;
                }
                else
                if(graph[i+1] < graph[i] && isDecrementing == false)
                {
                    isDecrementing = true;
                    isIncrementing = false;
                    countDecrement++;

                  
                   
                }
            }

            Console.WriteLine("Зроста " + countIncrement);
            Console.WriteLine("Cпада " + countDecrement);
            Console.ReadLine();
            
        }
    }
}
