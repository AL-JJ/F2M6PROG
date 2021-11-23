using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Database
    {
        private List<Weapon> _weapons;

        public Database()
        {
            _weapons = new List<Weapon>();
        }

        public void AddWeapon(Weapon newWeapon)
        {
            _weapons.Add(newWeapon);
        }

        public Weapon GetWeapon(/*int id*/)
        {
            //return _weapons[id - 1]; als alles in DB staat
            return _weapons[0];
        }
    }
}