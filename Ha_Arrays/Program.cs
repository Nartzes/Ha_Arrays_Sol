//using System;
//using System.Collections.Generic;

//namespace Ha_Arrays
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {   
//            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
//            sw.Start();

//            char[] list = new char[50];
//            char RanChar;
//            Random Char = new Random(DateTime.Now.Millisecond); // Move this out of the loop to avoid reseeding the generator
//            int Ran = 0;


//            List<char> generatedChars = new List<char>(); // Use a List to store generated characters

//            for (int i = 0; i < list.Length; i++)
//            {
//                do
//                {
//                    Ran = Char.Next('A', 'z' + 1);

//                    if (Ran > 'Z' && Ran < 'a')
//                    {
//                        Ran = Char.Next('a', 'z' + 1);
//                    }

//                    RanChar = (char)Ran;

//                } while (generatedChars.Contains(RanChar)); // Check for duplicates

//                generatedChars.Add(RanChar); // Add the character to the list of generated characters
//                list[i] = RanChar;
//                Console.WriteLine("> " + list[i]);
//            }

//            sw.Stop();
//            Console.WriteLine("Run time is: " + sw.Elapsed.ToString());
//        }
//    }
//}

// Old attempt above, where I did a for loop, with a do/while loop inside. This one is just a while loop with 2 arraps, a bool array, which is true or false.
// We specify it to have z-A and if it checks and sees it the first time it chances the array for that letter to true.

using System;

namespace Ha_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            char[] list = new char[50];
            char RanChar;
            Random Char = new Random(DateTime.Now.Millisecond); // A seed for extra randomness
            bool[] UsedChar = new bool['z' - 'A' + 1]; // Create a bool array to track used characters


            int i = 0;
            while (i < list.Length) // to list array of 50
            {
                int Ran = Char.Next('A', 'z' + 1); //generate vallue
                RanChar = (char)Ran;

                if ((Ran >= 'A' && Ran <= 'Z' || Ran >= 'a' && Ran <= 'z') && !UsedChar[Ran - 'A']) // Checking if generated vallue is duplicate
                {
                    UsedChar[Ran - 'A'] = true; // Mark the character as used
                    list[i] = RanChar;
                    Console.WriteLine("> " + list[i]);
                    i++;
                }
            }

            sw.Stop();
            Console.WriteLine("Run time is: " + sw.Elapsed.ToString());
        }
    }
}
