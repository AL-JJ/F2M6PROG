using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Database
    {
        private List<Weapon> _weapons;
        private string[] _allowedTypes;
        private List<Weapon> _displayedWeapons;
        public int newest { get; private set; }

        public Database()
        {
            _weapons = new List<Weapon>();
            _allowedTypes = new string[] {"Sidearm", "SMG", "Shotgun", "Rifle", "Sniper", "Heavy"};
            _displayedWeapons = new List<Weapon>();
            newest = _weapons.Count + 1;
        }


        // General Functions
        public void Add(string name, int id, string type, int cost)
        {
            int allowance = 0;
            foreach (string allowedtype in _allowedTypes)
            {
                if (type == allowedtype)
                {
                    allowance++;
                }
            }
            if (allowance == 1)
            {
                _weapons.Add(new(name, newest, type, cost));
                _displayedWeapons.Add(new(name, newest, type, cost));
                UpdateDisplay();
            } else
            {
                Console.WriteLine("Type not allowed, please try again");
                Console.WriteLine("(Allowed Types: Sidearm, SMG, Shotgun, Rifle, Sniper, Heavy)");
            }


        }

        public void Init()
        {
            _weapons.Add(new("Classic", 1, "Sidearm", 0));
            _weapons.Add(new("Shorty", 2, "Sidearm", 150));
            _weapons.Add(new("Frenzy", 3, "Sidearm", 450));
            _weapons.Add(new("Ghost", 4, "Sidearm", 500));
            _weapons.Add(new("Sheriff", 5, "Sidearm", 800));

            _weapons.Add(new("Stinger", 6, "SMG", 950));
            _weapons.Add(new("Spectre", 7, "SMG", 1600));

            _weapons.Add(new("Bucky", 8, "Shotgun", 850));
            _weapons.Add(new("Judge", 9, "Shotgun", 1850));

            _weapons.Add(new("Bulldog", 10, "Rifle", 2050));
            _weapons.Add(new("Guardian", 11, "Rifle", 2250));
            _weapons.Add(new("Phantom", 12, "Rifle", 2900));
            _weapons.Add(new("Vandal", 13, "Rifle", 2900));

            _weapons.Add(new("Marshall", 14, "Sniper", 950));
            _weapons.Add(new("Operator", 15, "Sniper", 4700));

            _weapons.Add(new("Ares", 16, "Heavy", 1600));
            _weapons.Add(new("Odin", 17, "Heavy", 3200));
        }

        public void ShowAll()
        {
            foreach (Weapon weapon in _displayedWeapons)
            {
                Console.WriteLine($"{weapon.AllAtts()}");
            }
        }

        public void UpdateDisplay()
        {
            Console.Clear();
            foreach (Weapon weapon in _displayedWeapons)
            {
                Console.WriteLine(weapon.AllAtts());
            }
        }

        // Filtering Functions

        public void FilterByID(int id)
        {
            _displayedWeapons.Clear();
            _displayedWeapons.Add(_weapons[id - 1]);
        }

        public void FilterByType(string type)
        {
            _displayedWeapons.Clear();
            foreach (string str in _allowedTypes)
            {
                if (str == type)
                {
                    
                    foreach (Weapon weapon in _weapons)
                    {
                        
                        if (weapon._type == str)
                        {
                            _displayedWeapons.Add(weapon);
                        }
                    }
                    
                }

            }
            UpdateDisplay();
        }

        public void FilterByCost(int cost, bool underCost)
        {
            _displayedWeapons.Clear();
            foreach (Weapon weapon in _weapons)
            {
                if (underCost == true)
                {
                    if (weapon._cost <= cost)
                    {
                    
                        _displayedWeapons.Add(weapon);
                    }
                } else
                {
                    if (weapon._cost >= cost)
                    {

                        _displayedWeapons.Add(weapon);
                    }
                }

            }
            UpdateDisplay();
        }

        public void FilterByCost(int cost)
        {
            _displayedWeapons.Clear();
            foreach (Weapon weapon in _weapons)
            {
                if (weapon._cost <= cost)
                {
                    _displayedWeapons.Add(weapon);
                }
            }
            UpdateDisplay();
        }


        public void ResetFilter()
        {
            _displayedWeapons.Clear();
            foreach (Weapon weapon in _weapons)
            {
                _displayedWeapons.Add(weapon);
            }
            UpdateDisplay();
        }
        
    }
}