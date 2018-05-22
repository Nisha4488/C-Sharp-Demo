using System;
using System.Collections.Generic;
namespace showcase
{
    public class Cohort
    {
        private List<string> pets = new List<string>();

        public List<string> ListExample(string item)
        {
            this.pets.Add(item);
            return this.pets;
        }
    }
}