using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //There is two ways to create an Array

            //1- Spesific length
            int[] exampleOne = new int[5];
            exampleOne[0] = 1;
            exampleOne[1] = 2;
            exampleOne[2] = 3;
            exampleOne[3] = 4;
            exampleOne[4] = 5;

            Console.WriteLine("Example One:");

            for (int i = 0; i < exampleOne.Length; i++)
            {
                Console.WriteLine(exampleOne[i]);
            }

            //2- Insert directly 'without length'

            int[] exampleTwo = new int[]{1, 2, 3};

            Console.WriteLine("Example Two:");

            for (int i = 0; i < exampleTwo.Length; i++)
            {
                Console.WriteLine(exampleTwo[i]);
            }

            Console.ReadKey();
        }
    }
}
