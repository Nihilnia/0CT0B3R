using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Methods_Ex
{
    class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Menu()
        {
            var choice = " ";

            do
            {
                Console.WriteLine("### MENU ###\n" +
                "1) Start\n" +
                "2) Stop\n" +
                "3) Increase speed\n" +
                "4) Decrease speed\n" +
                "5) Exit.." +
                "Choice: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Start();
                        break;

                    case "2":
                        Stop();
                        break;

                    case "3":
                        Increase();
                        break;

                    case "4":
                        Decrease();
                        break;

                    default:
                        Console.WriteLine("Nihil gonna do somethings special/deep.");
                        break;
                }
            } while (choice.ToLower() != "ç");

        }


        public void Start()
        {
            Console.WriteLine($"{this.Name} Started..");
        }

        public void Stop()
        {
            Console.WriteLine($"{this.Name} Stopped..");
        }

        public void Increase()
        {
            Console.WriteLine($"{this.Name} Speed Increased..");
        }

        public void Decrease()
        {
            Console.WriteLine($"{this.Name} Speed Decreased..");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car01 = new Car() { ID = 0, Name = "NCar" };

            car01.Menu();
            Console.Read();
        }
    }
}
