using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCreditEric
{
    class Program
    {
        //MadLib
        //By Eric Ashford

        static void Main(string[] args)
        {
            //Creating variables
            #region Variables
            string noun1;
            string noun2;
            string noun3;
            string noun4;

            string verb1;
            string verb2;
            string verb3;
            string verb4;

            int num1=0;
            int num2=0;
            #endregion

            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("=========MadLib Extara Credit!==========".PadLeft(60));
            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("Press any key to continue".PadLeft(52));
            Console.ReadKey();

            Console.WriteLine("Enter a Name:");
            noun1 = Console.ReadLine();

            Console.WriteLine("Enter the name of a place:");
            noun2 = Console.ReadLine();

            Console.WriteLine("Enter a friends name:");
            noun3 = Console.ReadLine();

            Console.WriteLine("Enter a vehicle name:");
            noun4 = Console.ReadLine();

            Console.WriteLine("Enter a random number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another random number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you prefer to be Speeding or Cruising?");
            verb1 = Console.ReadLine();

            Console.WriteLine("Something you do while driving:");
            verb2 = Console.ReadLine();

            Console.WriteLine("Something you do while driving:");
            verb3 = Console.ReadLine();

            Console.WriteLine("Morning exercise ending in -ing:");
            verb4 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("And now we will compile your answers into a story!".PadLeft(60));
            Console.WriteLine("Press any key.".PadLeft(60));
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Wake up, "+noun1+" its time to get up out of the bed! Lazy bum. \nYour friend "+noun3+ " would like to go out and get a bite to eat at " +noun2+". \nYou have heard that this resturant was the best to open up around you and sold the best food and even was qualified to earn 5 stars. ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("This would also be a good time to show off your new "+noun4+ " to " +noun3+ " who has been dieing to see it. \nYou leave your house at a "+verb1+" rate and pick up " +noun3+ " to head over to " +noun2 + ". \nOnce you get there you both order the number " +num1+ ", you heard it was what "+noun2+ " was good at.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("As you and your friend eat this magnificent meal, you forgot that you didnt do your moring exercise "+verb4+" and that you may have taken in to many carbs. \nBut since the food is so good, you go back to order a number "+num2+", for the ride back. You begin to "+ verb3+" while also "+verb2+". \nLuckily, you made it home safe and sound!");
            Console.ReadLine();

            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("====================Fin=================".PadLeft(60));
            Console.WriteLine("========================================".PadLeft(60));
            Console.WriteLine("========================================".PadLeft(60));
            Console.ReadKey();


        }
    }
}
