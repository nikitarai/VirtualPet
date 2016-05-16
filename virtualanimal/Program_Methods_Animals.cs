using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Timers;

namespace virtualanimal
{
    partial class Program:Animal
    {
        static void OldAnimal()
        {


            Console.WriteLine("Play with Existing Pet");
            Spacer();
            Console.WriteLine("Enter your pet's name: ");
            string userAnimal = Console.ReadLine();
            Spacer();
            string userSpecies;
            int userLegs;
            int hunger;
            List<string> userFavFood = new List<string>();



            StreamReader reader = new StreamReader(userAnimal + ".txt");
            using (reader)
            {
                userAnimal = reader.ReadLine();
                userSpecies = reader.ReadLine();
                userLegs = int.Parse(reader.ReadLine());
                hunger = int.Parse(reader.ReadLine());

                userFavFood.Add(reader.ReadLine());
                userFavFood.Add(reader.ReadLine());
                userFavFood.Add(reader.ReadLine());

            }

            Animal userAni = new Animal(userSpecies, userLegs, userFavFood, hunger);
            Console.WriteLine("{0} is a {1} with {2} legs.", userAnimal, userSpecies, userLegs);

            userAni.ListFavoriteFood();
            Spacer();
            Console.WriteLine("Would you like to play with your animal? (\"Y\" or \"N\").");

            string play = Console.ReadLine().ToUpper();

            if (play == "Y")
            {

                Console.Clear();
                Console.WriteLine("What would you like to do with your animal?");
                Console.WriteLine("1 | Feed your Pet");
                Console.WriteLine("2 | Walk your Pet");
                Console.WriteLine("3 | Run your Pet");
                Console.WriteLine("4 | Make your Pet Speak");
                Console.WriteLine("5 | Make your Pet Poop");
                Console.WriteLine("6 | Check your Pet's Hunger Level");
                Console.WriteLine("7 | Save your Pet's progress");
                Console.WriteLine("8 | Go Back to Main Menu");

                string playAgain = "Y";
                do
                {
                    Spacer();
                    Console.Write("Pick from number options above: ");
                    int animalActivities = int.Parse(Console.ReadLine());

                    switch (animalActivities)
                    {
                        case 1:
                            Spacer();
                            userAni.Feed();

                            break;
                        case 2:
                            Spacer();
                            userAni.Walk();

                            break;
                        case 3:
                            Spacer();
                            userAni.Run();

                            break;
                        case 4:
                            Spacer();
                            userAni.Speak();
                            break;
                        case 5:
                            Spacer();
                            userAni.Poop();
                            break;
                        case 6:
                            Spacer();
                            userAni.HungerLevel();
                            break;
                        case 7:

                            StreamWriter write = new StreamWriter(userAnimal + ".txt");
                            using (write)
                            {
                                write.WriteLine(userAnimal);
                                write.WriteLine(userSpecies);
                                write.WriteLine(userLegs);
                                write.WriteLine(userAni.Hunger);

                                foreach (string food in userFavFood)
                                {
                                    write.WriteLine(food);
                                }


                            }

                            Console.WriteLine(userAnimal + "'s progress has been saved.");
                            Spacer();
                            StreamReader read = new StreamReader(userAnimal + ".txt");
                            using (read)
                            {
                                Console.WriteLine(read.ReadLine());
                                Console.WriteLine("Species: " + read.ReadLine());
                                Console.WriteLine("Legs: " + read.ReadLine());
                                Console.WriteLine("Hunger Level: " + read.ReadLine());
                                Console.WriteLine("Favorite Food: ");
                                foreach (string food in userFavFood)
                                {
                                    Console.WriteLine(read.ReadLine());
                                }
                            }
                            break;
                        case 8:
                            playAgain = "N";
                            Console.Clear();
                            Menu();
                            break;
                        default:
                            break;
                    }

                } while (playAgain == "Y");
            }
            else if (play == "N")
            {
                Console.Clear();
                Menu();
            }



        }
        static void NewAnimal()
        {
            Console.WriteLine("Create a New Pet");
            Spacer();
            Console.WriteLine("Enter your animal's name: ");
            string userAnimal = Console.ReadLine();
            Spacer();
            Console.WriteLine("Enter Species: ");
            string userSpecies = Console.ReadLine().ToLower();
            Spacer();
            Console.WriteLine("Enter Number of Legs: ");
            int userLegs = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter if your animal has a tail (\"true\" for Tail and \"false\" for No Tail): ");
            // bool userTail = bool.Parse(Console.ReadLine());
            Spacer();
            Console.WriteLine("Enter your animal's favorite food:");
            Console.Write("1. ");
            string fav1 = Console.ReadLine();
            Console.Write("2. ");
            string fav2 = Console.ReadLine();
            Console.Write("3. ");
            string fav3 = Console.ReadLine();

            Spacer();
            List<string> userFavFood = new List<string>();
            userFavFood.Add(fav1);
            userFavFood.Add(fav2);
            userFavFood.Add(fav3);
            Spacer2();



            //instantiate new object
            Animal userAni = new Animal(userSpecies, userLegs, userFavFood);
            Console.WriteLine("{0} is a {1} with {2} legs.", userAnimal, userSpecies, userLegs);



            userAni.ListFavoriteFood();
            Spacer();
            Console.WriteLine("Would you like to play with your animal? (\"Y\" or \"N\").");

            string play = Console.ReadLine().ToUpper();

            if (play == "Y")
            {

                Console.Clear();
                Console.WriteLine("What would you like to do with your animal?");
                Console.WriteLine("1 | Feed your Pet");
                Console.WriteLine("2 | Walk your Pet");
                Console.WriteLine("3 | Run your Pet");
                Console.WriteLine("4 | Make your Pet Speak");
                Console.WriteLine("5 | Make your Pet Poop");
                Console.WriteLine("6 | Check your Pet's Hunger Level");
                Console.WriteLine("7 | Save your Pet's progress");
                Console.WriteLine("8 | Go Back to Main Menu");

                string playAgain = "Y";
                do
                {
                    Spacer();
                    Console.Write("Pick from number options above: ");
                    int animalActivities = int.Parse(Console.ReadLine());

                    switch (animalActivities)
                    {
                        case 1:
                            Spacer();
                            userAni.Feed();

                            break;
                        case 2:
                            Spacer();
                            userAni.Walk();

                            break;
                        case 3:
                            Spacer();
                            userAni.Run();

                            break;
                        case 4:
                            userAni.Speak();
                            break;
                        case 5:
                            Spacer();
                            userAni.Poop();
                            break;
                        case 6:
                            Spacer();
                            userAni.HungerLevel();
                            break;
                        case 7:

                            StreamWriter write = new StreamWriter(userAnimal + ".txt");
                            using (write)
                            {
                                write.WriteLine(userAnimal);
                                write.WriteLine(userSpecies);
                                write.WriteLine(userLegs);
                                write.WriteLine(userAni.Hunger);

                                foreach (string food in userFavFood)
                                {
                                    write.WriteLine(food);
                                }


                            }
                            Console.WriteLine(userAnimal + "'s progress has been saved.");
                            Spacer();
                            StreamReader read = new StreamReader(userAnimal + ".txt");
                            using (read)
                            {
                                Console.WriteLine(read.ReadLine());
                                Console.WriteLine("Species: " + read.ReadLine());
                                Console.WriteLine("Legs: " + read.ReadLine());
                                Console.WriteLine("Hunger Level: " + read.ReadLine());
                                Console.WriteLine("Favorite Food: ");
                                foreach (string food in userFavFood)
                                {
                                    Console.WriteLine(read.ReadLine());
                                }
                            }
                            break;
                        case 8:
                            playAgain = "N";
                            Console.Clear();
                            Menu();
                            break;
                        default:
                            break;
                    }

                } while (playAgain == "Y");

            }
            else if (play == "N")
            {
                Console.Clear();
                Menu();
            }

            
    }
        
        //public void threadfunc()
        //{
        //    int hunglev = userani.Hunger;
        //    for (int c = hunglev; c >= 0; c--)
        //    {
        //        userani.Hunger = userani.Hunger - 1;
        //       Thread.Sleep(5000);
        //    }
        //}

    }

}
