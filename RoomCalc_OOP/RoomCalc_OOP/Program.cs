using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc_OOP
{

    class Program
    {
        static void Main(string[] args)
        {   
            // cont is initialized to y in order to make sure that the while loop runs
            // doubles are declared for width and length
            // an instance of Room class is declared
            string cont = "y";
            double width;
            double length;
            Room newRoom;

            while (cont == "y")
            {
                // ensures that the user enters a valid number for both width and length

                Console.WriteLine("Please enter the width of the room");
                while (!double.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Please enter the width in numerical format");
             
                }

                Console.WriteLine("Please enter the length of the room");
                while (!double.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Please enter the length in numerical format");
                }

                // newRoom is initialized with the width and length

                newRoom = new Room(width, length);
                
                // newRoom PrintInfo method is called to print the area and perimeter of the room
                // info is printed to the console
                
                string info = newRoom.PrintInfo();

                Console.WriteLine(info);

                //user is prompted to continue or quit

                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();

                // user input for cont is checked

                while (cont != "y" && cont != "n")
                {
                    Console.WriteLine("Please enter y to continue or n to quit.");
                    cont = Console.ReadLine();
                }
            }
        }
    }
}
