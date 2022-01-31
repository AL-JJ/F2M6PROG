using System.Collections.Generic;

namespace ConsoleApp
{
    public class Weapon
    {
        public string _name { get; private set; }
        public int _id      { get; private set; }
        public string _type { get; private set; }
        public int _cost    { get; private set; }
        
        public Weapon(string weaponName, int weaponID, string weaponType, int weaponCost)
        {
            _name = weaponName;
            _id   = weaponID;
            _type = weaponType;
            _cost = weaponCost;
        }

        public string AllAtts()
        {
            return $"Name: {_name}, ID: {_id}, Type: {_type}, Cost: {_cost}";
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
