// See https://aka.ms/new-console-template for more information

using System;
namespace DatastructuresAlgorithms
{
    class program
    {
        public static void Main(String[] args)
        {
            String s;
            String answer = "";

            Console.Write("Enter the string: ");
            s = Console.ReadLine();

            Console.Write("\nAll possible strings are : ");
            Permutations value = new Permutations();
            value.Permute(s, answer);

        }
    }
}