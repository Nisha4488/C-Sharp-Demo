using System;
using System.Collections.Generic;
namespace showcase
{
    public class ReferenceTypes
    {
        public static void UseArr()
        {
            string[] names = new string[5] {"Jess", "Kevin", "Shae", "John", "Cheryl"};
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        
    }
}