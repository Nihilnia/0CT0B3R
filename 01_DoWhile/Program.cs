using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string userChoice;

            do
            {
                Console.WriteLine("What is your choice: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("1 is choosen.");
                        break;

                    case "2":
                        Console.WriteLine("2 is choosen.");
                        break;

                    case "3":
                        Console.WriteLine("3 is choosen.");
                        break;

                    default:
                        Console.WriteLine("Thanks for using our app. lol");
                        break;
                }

            } while (Convert.ToInt32(userChoice) <= 3);


            Console.Read();
        }
    }
}
