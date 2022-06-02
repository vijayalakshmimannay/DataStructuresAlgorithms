// See https://aka.ms/new-console-template for more information

using System;
namespace DatastructuresAlgorithms
{
    class program
    {

        public static void Main(String[] args)
        {

            string[] names = { "vijaya lakshmi", "lakshmi vijaya", "lakshmi mannay", "mannnay lakshmi" };
            DatastructuresAlgorithms.Insertionsort value = new DatastructuresAlgorithms.Insertionsort();
            value.InsertionSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }



        }


    }
}