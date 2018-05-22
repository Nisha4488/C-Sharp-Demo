using System;
namespace showcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jeff";
            char myLetter = 'A';

            bool myBool = false;
            
            byte myByte = 231;
            short shortNum = 2341;
            int myInt = 52031;
            long unlimitedPower = 3421234;
            
            
            float myFloat = 342.1f;
            double twiceAsBig = 324134.3;

 
            var result = Add(myInt, 10);
            
            Console.WriteLine(result);

        }

        static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
    }
}
