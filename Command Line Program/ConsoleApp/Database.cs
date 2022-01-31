using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Database
    {
        private List<Weapon> _weapons;
        private string[] _allowedTypes;
        private List<Weapon> _displayedWeapons;

        public Database()
        {
            _weapons = new List<Weapon>();
            _allowedTypes = new string[] {"Sidearm", "SMG", "Shotgun", "Rifle", "Sniper", "Heavy"};
            _displayedWeapons = new List<Weapon>();
        }


        // General Functions
        public void Add(string name, int id, string type, int cost)
        {
            Weapon newWeapon = new Weapon(name, id, type, cost);
            _weapons.Add(newWeapon);
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

        public void ResetFilter()
        {
            _displayedWeapons.Clear();
            foreach (Weapon weapon in _weapons)
            {
                _displayedWeapons.Add(weapon);
            }
            UpdateDisplay();
        }

        // Sorting Functions

        public void Sort(int sortMethod)
        {
            switch (sortMethod)
            {
                case 1:
                    SortAlphabetical();
                    UpdateDisplay();
                    break;
                case 2:
                    SortID();
                    UpdateDisplay();
                    break;
                case 3:
                    Console.WriteLine("werkt opzich wel");
                    SortCost();
                    UpdateDisplay();
                    break;
            }
        }

        public void SortAlphabetical()
        {

        }

        public void SortID()
        {

        }

        public void SortCost()
        {
            List<Weapon> placeholder = new();
            _displayedWeapons.Sort((x, y) => x._cost.CompareTo(y._cost));
        }
        
    }
}