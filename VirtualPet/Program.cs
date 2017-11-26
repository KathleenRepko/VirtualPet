using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the pet
            VirtualPet pet1 = new VirtualPet("Hairy", true, true, false, false, 0);

            //Instantiate variable for user choice.
            int userPick;

            //Print menu of user options. 
            do
            {
                Console.WriteLine("\nWhat would you like to do? Enter the number of the menu item, and then click \"Enter\".");

                List<string> userMenu = new List<string> { "1. Show me my pet's info.", "2. Feed pet.", "3. Water pet.", "4. Care for sick pet.", "5. Play with pet.", "6. Take pet outside.", "7. Exit." };

                foreach (string menuItem in userMenu)
                {
                    Console.WriteLine(menuItem);
                }

                //User input
                userPick = int.Parse(Console.ReadLine());

                //Conditionals, based on user choice.
                switch (userPick)
                {

                    case 1:
                        Console.WriteLine("Here is information about your virtual pet:");
                        pet1.PetStats();
                        break;

                    case 2:
                        Console.WriteLine("You are feeding your pet.");
                        pet1.FeedPet();
                        break;

                    case 3:
                        Console.WriteLine("You are watering your pet.");
                        pet1.WaterPet();
                        break;

                    case 4:
                        Console.WriteLine("You are caring for your sick pet.");
                        pet1.CareForPet();
                        break;

                    case 5:
                        Console.WriteLine("You are playing with your pet.");
                        pet1.PlayWithPet();
                        break;

                    case 6:
                        Console.WriteLine("You are taking your pet outside to go potty.");
                        pet1.TakePetOutside();
                        break;

                    case 7:
                        Console.WriteLine("Have a good day!");
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
            }
            while (userPick != 7);

        }
    }
}
