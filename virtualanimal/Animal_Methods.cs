using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualanimal
{
    partial class Animal
    {
        //methods
        public bool Feed()
        {
            //get random favorite food because nothing was specified
            Random random = new Random();
            int randomNum = random.Next(this.FavoriteFoods.Count);
            Console.WriteLine(this.Species + " just ate " + this.FavoriteFoods.ElementAt(randomNum) + ".");
            this.Hunger += CheckFoodValue(this.FavoriteFoods.ElementAt(randomNum));
            return true;
        }

        public int CheckFoodValue(string foodItem)
        {
            return 1;
        }

        internal void AddFavoriteFood(string foodItem)
        {
            this.FavoriteFoods.Add(foodItem);
        }

        public void ListFavoriteFood()
        {
            Console.WriteLine(this.Species + "'s favorite foods include: ");
            foreach (string food in this.FavoriteFoods)
            {
                Console.WriteLine(food);
            }
        }

        public void Run()
        {
            int calories = 200;
            int calConvert = calories / 100;

            //every 100 calories burn = -1 hunger level



            if (this.Hunger >= 2)
            {
                Console.WriteLine(this.Species + " just ran off {0} calories.", calories);
                this.Hunger = this.Hunger - calConvert;
            }

            if (this.Hunger < 2)
            {
                Console.WriteLine(this.Species + " is hungry.");
                Console.WriteLine(this.Species + " has no energy to run.");
            }


        }

        public void Walk()
        {
            int calories = 100;
            int calConvert = calories / 100;
            if (this.Hunger >= 1)
            {
                Console.WriteLine(this.Species + " just walked off {0} calories.", calories);
                this.Hunger = this.Hunger - calConvert;
            }

            if (this.Hunger < 1)
            {
                Console.WriteLine(this.Species + " is hungry.");
                Console.WriteLine(this.Species + " has no energy to walk.");
            }
        }

        public void Speak()
        {
            if (this.Species == "dog")
            {
                this.Voice = "Woof";
            }

            if (this.Species == "cat")
            {
                this.Voice = "Meow";
            }

            if (this.Species == "pig")
            {
                this.Voice = "Oink";
            }

            Console.WriteLine(this.Voice + "\a");



        }

        public void Poop()
        {

            if (this.Hunger >= 1)
            {
                this.Hunger = this.Hunger - 1;
                Console.WriteLine(this.Species + " just pooped.");
            }
            else if (this.Hunger <= 0)
            {
                Console.WriteLine(this.Species + "'s stomach is empty.");
            }

        }

        public void HungerLevel()
        {
            Console.WriteLine(this.Species + "'s Hunger Level: " + this.Hunger);

        }
    }
}
