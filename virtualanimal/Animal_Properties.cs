using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualanimal
{
    partial class Animal
    {
        //properties
        public string Voice { get; set; }
        public int Legs
        {
            get { return this.legs; }
            set { this.legs = value; }
        }

        public string Species
        {
            get { return this.species; }
            set { this.species = value; }
        }

        public List<string> FavoriteFoods
        {
            get { return this.favoriteFoods; }
            set { this.favoriteFoods = value; }
        }

        public bool HasTail
        {
            get { return this.hasTail; }
            set { this.hasTail = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set
            {
                if (value >= maxFull)
                {
                    Console.WriteLine(this.Species + " is full.");
                }

                if (value == 0)
                {
                    Speak();
                    Console.WriteLine(this.species + " is hungry.");
                }


                else {
                    this.hunger = value;
                }
            }
        }

    }
}
