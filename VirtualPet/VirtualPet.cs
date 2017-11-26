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

        //Methods:
        public void PetStats()
        {
            Console.WriteLine("Pet name: " + name);
            Console.WriteLine(name + " is hungry: " + isHungry);
            Console.WriteLine(name + " is thirsty: " + isThirsty);
            Console.WriteLine(name + " is sick: " + isSick);
            Console.WriteLine(name + " is bored: " + isBored);
            if (waste == 0)
            {
                Console.WriteLine(name + " does not need to go potty.");
            }
            else if (waste == 1)
            {
                Console.WriteLine(name + " needs to pee.");
            }
            else if (waste == 2)
            {
                Console.WriteLine(name + " needs to poo.");
            }
            else
            {
                Console.WriteLine(name + " is confused.");
            }
        }

        public void FeedPet()
        {
            if (isHungry == false)
            {
                Console.WriteLine(name + " was not hungry and has overeaten!");
            }
            else if (isHungry == true)
            {
                isHungry = false;
                Console.WriteLine(name + " is not hungry.");
            }
            waste = 2;
        }

        public void WaterPet()
        {
            isThirsty = false;
            Console.WriteLine(name + " is not thisty.");
            waste = 1;
        }

        public void CareForPet()
        {
            if (isSick == false)
            {
                Console.WriteLine(name + " is not sick, but loves the extra attention.");
            }
            else if (isSick == true)
            {
                Console.WriteLine(name + " feels much better.");
            }
            isSick = false;
            isBored = true;
        }

        public void PlayWithPet()
        {
            isBored = false;
            Console.WriteLine(name + " loves to play all the time!");
            isThirsty = true;
        }

        public void TakePetOutside()
        {
            if (waste == 0)
            {
                Console.WriteLine(name + " loves to be outside all the time!");
            }
            else if (waste == 1 || waste == 2)
            {
                Console.WriteLine(name + " feels better!");
            }
            waste = 0;
        }

    }


}
