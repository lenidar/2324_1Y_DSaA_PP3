using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_DSaA_PP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> numList = new List<int>();
            Stack<int> numStack = new Stack<int>();
            Queue<int> numQueue = new Queue<int>();
            int searchFor = 50;

            while(numList.Count != 100)
                numList.Add(rnd.Next(50,201));

            // display the content of the list
            Console.WriteLine("List Content before sorting:");
            for(int x = 0; x < numList.Count; x++)
            {
                if((x + 1) % 10 == 0)
                    Console.WriteLine(numList[x]);
                else
                    Console.Write(numList[x] + "\t");
            }

            while(numList.Count > 0)
            {
                while(numList.Contains(searchFor))
                {
                    numList.Remove(searchFor);
                    numStack.Push(searchFor);
                    numQueue.Enqueue(searchFor);
                }
                searchFor++;
            }

            Console.WriteLine("\nDescending order");
            for(int x = 0; x < 100; x++)
            {
                if ((x + 1) % 10 == 0)
                    Console.WriteLine(numStack.Pop());
                else
                    Console.Write(numStack.Pop() + "\t");
            }

            Console.WriteLine("\nAscending order");
            for (int x = 0; x < 100; x++)
            {
                if ((x + 1) % 10 == 0)
                    Console.WriteLine(numQueue.Dequeue());
                else
                    Console.Write(numQueue.Dequeue() + "\t");
            }

            Console.ReadKey();
        }
    }
}
