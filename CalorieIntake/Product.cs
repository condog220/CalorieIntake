using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieIntake
{
    internal class Product
    {
        string Name;
        int calories;
        string output;

        public Product(string name, int calories)
        {
            this.Name = name;
            this.calories = calories;
        }
        public string ConvString()
        {
            output = Name + " - " + calories;
            return output;
        }

        public string modifyName(string inpName)
        {
            Name = inpName;
            return Name;
        }

        public int modifyCalorie(int inpCalorie)
        {
            calories = inpCalorie;
            return calories;
        }
    }
}
