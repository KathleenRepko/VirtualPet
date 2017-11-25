using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields
        private string name;
        private bool isHungry;
        private bool isThirsty;
        private bool isSick;
        private bool isBored;
        private int waste;

        //Properties
        public string Name
        { get; set; } 

        public bool IsHungry
        { get; set; }

        public bool IsThirsty
        { get; set; }

        public bool IsSick
        { get; set; }

        public bool IsBored
        { get; set; }

        public int Waste
        { get; set; }

        //Constructors
        public VirtualPet()
        {

        }

        public VirtualPet(string name, bool isHungry, bool isThirsty, bool isSick, bool isBored, int waste)
        {
            this.name = name;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isSick = isSick;
            this.isBored = isBored;
            this.waste = waste;
        }

        //Method:
        public void PetStats()
        {
            Console.WriteLine("Pet name: " + name);
            Console.WriteLine(name + " is hungry: " + isHungry);
            Console.WriteLine(name + " is thirsty: " + isThirsty);
            Console.WriteLine(name + " is sick: " + isSick);
            Console.WriteLine(name + " is bored: " + isBored);
            if (waste == 0)
            { Console.WriteLine(name + " does not need to go potty."); }
            else if (waste == 1)
            { Console.WriteLine(name + " needs to pee."); }
            else if (waste == 2)
            { Console.WriteLine(name + " needs to poo."); }
            else
            { Console.WriteLine(name + " is confused."); }

        }

    }


}
