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

            weapons.Add("Classic",  1, "Sidearm", 0);
            weapons.Add("Shorty",   2, "Sidearm", 150);
            weapons.Add("Frenzy",   3, "Sidearm", 450);
            weapons.Add("Ghost",    4, "Sidearm", 500);
            weapons.Add("Sheriff",  5, "Sidearm", 800);

            weapons.Add("Stinger",  6, "SMG",     950);
            weapons.Add("Spectre",  7, "SMG",     1600);

            weapons.Add("Bucky",    8, "Shotgun", 850);
            weapons.Add("Judge",    9, "Shotgun", 1850);

            weapons.Add("Bulldog",  10, "Rifle",   2050);
            weapons.Add("Guardian", 11, "Rifle",   2250);
            weapons.Add("Phantom",  12, "Rifle",   2900);
            weapons.Add("Vandal",   13, "Rifle",   2900);

            weapons.Add("Marshall", 14, "Sniper",  950);
            weapons.Add("Operator", 15, "Sniper",  4700);

            weapons.Add("Ares",     16, "Heavy",   1600);
            weapons.Add("Odin",     17, "Heavy",   3200);

            weapons.FilterByType("Heavy");

            //while (true) {
            //weapons.UpdateDisplay();
            //    Thread.Sleep(1);
            //}


        }
    }
}
