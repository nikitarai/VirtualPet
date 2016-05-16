using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualanimal
{
    partial class Animal
    {
        //fields
        private int legs = 0;
        private string species = "unknown";
        private List<string> favoriteFoods = new List<string>();
        private bool hasTail = true; //default to true
        private int hunger = 10;
        private const int maxFull = 10;

        
    }
}
