using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Database weapons = new Database();

            weapons.Init();

            Console.WriteLine("VALORANT WEAPONS DATABASE BY @JALEXIS5");
            Console.WriteLine("\nPress the corresponding buttons to perform actions");
            Console.WriteLine("1: SHOWALL\n2: ADD\n3: FILTER");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    weapons.ShowAll();
                    break;
                case "2":
                    Console.WriteLine("What NAME does the weapon go by?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What TYPE of weapon is it?");
                    string type = Console.ReadLine();
                    Console.WriteLine("How much does the weapon COST?");
                    string cost = Console.ReadLine();

                    weapons.Add(name, weapons.newest, type, int.Parse(cost));
                    break;
                case "3":
                    Console.WriteLine("filter thing");
                    break;
            }
        }
    }
}
