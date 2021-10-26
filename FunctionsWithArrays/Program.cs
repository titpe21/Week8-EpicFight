using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string randomColor = PickRandomColor(colors);
            Console.WriteLine($"Arvuti valis {randomColor}.");
            DisplayRandomColor(colors);
        }


        private static int GenerateRandomNumberforArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }

        private static string PickRandomColor(string[] someArray)
        {
            return someArray[GenerateRandomNumberforArray(someArray)];
        }

        private static void DisplayRandomColor(string[] someArray)
        {
            Console.WriteLine(someArray[GenerateRandomNumberforArray(someArray)]);
        }


    }
}
