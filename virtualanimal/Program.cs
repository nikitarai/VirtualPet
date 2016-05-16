using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;


namespace virtualanimal
{
    partial class Program
    {
        static void Main(string[] args)
        {
           
            Menu();         
        }

        static void Menu()
        {
            Console.WriteLine("Virtual Pet");
            Spacer();
            Console.WriteLine("1 | Create New Pet");
            Console.WriteLine("2 | Play with Existing Pet");
            Console.WriteLine("3 | Exit");
            Spacer();
            int menuOptions = int.Parse(Console.ReadLine());

            switch (menuOptions)
            {
                case 1:
                    Spacer();
                    NewAnimal();
                    break;
                case 2:
                    Spacer();
                    OldAnimal();
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing with your pet. See you Soon!");
                    break;
                default:
                    break;
            }
        }

           
    }     
}

         

