using System;

namespace after
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetNumberInWords(25));
        }

        public static string GetNumberInWords(int value)
        {
            if (value < 0 || value > 9)
            {
                return "Unknown";
            }
            var numberInWords = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen",           "Nineteen", "Twenty", "TwentyOne", "TwentyTwo", "TwentyThree", "TwentyFour", "TwentyFive", "TwentySix"};

            return numberInWords[value];
        }
    }
}