using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OverloadMethods
{
    class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int currentSpeed { get; set; }
        public int speedLimit { get; set; }
        public bool isAutomatic { get; set; }

        string userSpeed = "0";

        public void ShowInfos()
        {

            string x = "No";

            if (isAutomatic != false)
            {
                x = "Yes";
            }

            Console.WriteLine($"Welcome to the {this.Name}\n" +
                $"Car ID: {this.ID}\n" +
                $"Speed Limit: {this.speedLimit}\n" +
                $"Automatic? {x}\n");
        }

        public void Menu()
        {
            var userChoice = "";

            do
            {
                Console.WriteLine($"\n#### {this.Name} services: ####\n" +
                "1)Start\n" +
                "2)Stop\n" +
                "3)Show the speed limit\n" +
                "4)Increase the speed limit\n" +
                "5)Decrease the speed limit\n" +
                "6)Increase the speed\n" +
                "7)Decrease the speed\n" +
                "8)Show all infos!\n" +
                "9)Quit..\n" +
                "## What is your choice?: \n");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Start();
                        break;

                    case "2":
                        Stop();
                        break;

                    case "3":
                        ShowSpeedLimit();
                        break;

                    case "4":
                        Console.WriteLine("New speed limit: ");
                        userSpeed = Console.ReadLine();
                        IncreaseSpeedLimit(userSpeed);
                        break;

                    case "5":
                        Console.WriteLine("New speed limit: ");
                        userSpeed = Console.ReadLine();
                        DecreaseSpeedLimit(userSpeed);
                        break;

                    case "6":
                        Console.WriteLine("Increase to: ");
                        userSpeed = Console.ReadLine();
                        IncreaseSpeed(userSpeed);
                        break;

                    case "7":
                        Console.WriteLine("Decrease to: ");
                        userSpeed = Console.ReadLine();
                        DecreaseSpeed(userSpeed);
                        break;

                    case "8":
                        ShowInfos();
                        break;

                }
            } while (userChoice != "9");


        }

        public void Start()
        {
            currentSpeed = 10;
            Console.WriteLine($"{this.Name} Started..\nCurrent speed: {currentSpeed}\n");
        }

        public void Stop()
        {
            currentSpeed = 0;
            Console.WriteLine($"{this.Name} Stopped..\nCurrent speed: {currentSpeed}\n");
        }

        public void ShowSpeedLimit()
        {
            
            Console.WriteLine($"{this.Name}'s speed limit is: {this.speedLimit}..");
        }

        public void IncreaseSpeedLimit(string newLimit)
        {
            this.speedLimit = Convert.ToInt32(newLimit);
            Console.WriteLine($"{this.Name}'s speed limit Increased to: {this.speedLimit}..");
        }

        public void DecreaseSpeedLimit(string newLimit)
        {
            this.speedLimit = Convert.ToInt32(newLimit);
            Console.WriteLine($"{this.Name}'s speed limit Decreased to: {this.speedLimit}..");
        }

        public void IncreaseSpeed(string newSpeed)
        {
            if (this.speedLimit >= Convert.ToInt32(newSpeed))
            {
                currentSpeed = Convert.ToInt32(newSpeed);
                Console.WriteLine($"{this.Name}'s speed Increased to..{this.currentSpeed}\n");
            }
            else
            {
                Console.WriteLine($"You can't over the speed Limit: {this.speedLimit}\n");
            }
            
        }

        public void DecreaseSpeed(string newSpeed)
        {
            if (Convert.ToInt32(newSpeed) > 0)
            {
                currentSpeed = Convert.ToInt32(newSpeed);
                Console.WriteLine($"{this.Name}'s speed to..{this.currentSpeed}\n");
            }
            else if(Convert.ToInt32(newSpeed) == 0)
            {
                Stop();
            }
            else
            {
                Console.WriteLine("Speed must be bigger than zero!");
            }
            
        }




    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Tesla = new Car() {
                ID = 0,
                Name = "Tesla V0.1",
                speedLimit = 180,
                isAutomatic = true,
                currentSpeed = 0
            };

            Tesla.Menu();
        }
    }
}
