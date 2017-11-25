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
            VirtualPet pet1 = new VirtualPet ("Hairy", true, true, false, false, 0);

            Console.WriteLine("Here is information about your virtual pet:");
            pet1.PetStats();


        }
    }
}
