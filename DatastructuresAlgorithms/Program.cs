// See https://aka.ms/new-console-template for more information

using System;
namespace DatastructuresAlgorithms
{
    class program
    {
        static void Main(string[] args)
        {
            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            Anagram anagram = new Anagram();
            //Check if words are anagram  
            if (anagram.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");
            }
            Console.ReadLine();
        }
    }

}
