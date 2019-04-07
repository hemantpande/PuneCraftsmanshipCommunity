using System;

namespace before
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetNumberInWords(25));
        }

        public static string GetNumberInWords(int value)
        {
            if (value == 0) return "Zero";
            if (value == 1) return "One";
            if (value == 2) return "Two";
            if (value == 3) return "Three";
            if (value == 4) return "Four";
            if (value == 5) return "Five";
            if (value == 6) return "Six";
            if (value == 7) return "Seven";
            if (value == 8) return "Eight";
            if (value == 9) return "Nine";
            if (value == 10) return "Ten";
            if (value == 11) return "Eleven";
            if (value == 12) return "Twelve";
            if (value == 13) return "Thirteen";
            if (value == 14) return "Fourteen";
            if (value == 15) return "Fifteen";
            if (value == 16) return "Sixteen";
            if (value == 17) return "Seventeen";
            if (value == 18) return "Eightteen";
            if (value == 19) return "Nineteen";
            if (value == 20) return "Twenty";
            if (value == 21) return "TwentyOne";
            if (value == 22) return "TwentyTwo";
            if (value == 23) return "TwentyThree";
            if (value == 24) return "TwentyFour";
            if (value == 25) return "TwentyFive";
            if (value == 26) return "TwentySix";

            return "Unknown";
        }
    }
}