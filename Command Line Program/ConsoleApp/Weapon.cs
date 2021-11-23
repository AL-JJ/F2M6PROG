using System.Collections.Generic;

namespace ConsoleApp
{
    public class Weapon
    {
        private string name;
        private int    id;
        private string type;
        private int    cost;
        
        public Weapon(string weaponName, int weaponID, string weaponType, int weaponCost)
        {
            name = weaponName;
            id   = weaponID;
            type = weaponType;
            cost = weaponCost;
        }

        public string GetName()
        {
            return name;
        }

        public int GetID()
        {
            return id;
        }

        public string GetGunType()
        {
            return type;
        }

        public int GetCost()
        {
            return cost;
        }

        public string GetAllAttributes()
        {
            return $"Name: {name}, ID: {id}, Type: {type}, Cost: {cost}";
        }


        //public List<KeyValuePair<string, int>> damage;
        //public float firerate;
        //public float runspeed;
        //public float equiptime;
        //public float firstshotspread;
        //public float reloadspeed;

        //public string wallpen;
        //public string firemode;
        //public int magsize;
        //public string reservemags;

    }
}
