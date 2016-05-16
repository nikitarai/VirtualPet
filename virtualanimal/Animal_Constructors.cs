using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualanimal
{
    partial class Animal
    {
        //constructors
        public Animal()
        {

        }

        public Animal(int tmpLegs)
        {
            this.legs = tmpLegs;
        }

        public Animal(string tmpSpecies, int tmpLegs)
        {
            this.species = tmpSpecies;
            this.legs = tmpLegs;
        }

        public Animal(string tmpSpecies, int tmpLegs, List<string> tmpFoods)
        {
            this.Species = tmpSpecies;
            this.Legs = tmpLegs;
            this.FavoriteFoods = tmpFoods;
        }

        public Animal(string tmpSpecies, int tmpLegs, List<string> tmpFoods, int tmpHunger)
        {
            this.species = tmpSpecies;
            this.Legs = tmpLegs;
            this.FavoriteFoods = tmpFoods;
            this.Hunger = tmpHunger;
        }

        public Animal(string tmpSpecies, int tmpLegs, List<string> tmpFoods, bool tmpTail, int tmpHunger)
        {
            this.Species = tmpSpecies;
            this.Legs = tmpLegs;
            this.FavoriteFoods = tmpFoods;
            this.HasTail = tmpTail;
            this.Hunger = tmpHunger;

        }
    }
}
