using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Database weapons = new Database();
            weapons.AddWeapon(new Weapon("Vandal", 14, "Rifle", 2900));

            Console.WriteLine("What attribute would you like to see?");
            Console.WriteLine("A: Name, B: ID, C: Type, D: Cost, E: Everything");
            string requestName = Console.ReadLine();
            
            switch (requestName.ToLower())
            {
                case "a":
                    Console.WriteLine(weapons.GetWeapon().GetName());
                    break;
                case "b":
                    Console.WriteLine(weapons.GetWeapon().GetID());
                    break;
                case "c":
                    Console.WriteLine(weapons.GetWeapon().GetGunType());
                    break;
                case "d":
                    Console.WriteLine(weapons.GetWeapon().GetCost());
                    break;
                case "e":
                    Console.WriteLine(weapons.GetWeapon().GetAllAttributes());
                    break;
                default:
                    Console.WriteLine("INVALID!!!");
                    break;
            }
        }
    }
}
