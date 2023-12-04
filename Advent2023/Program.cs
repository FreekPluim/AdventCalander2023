using System;

namespace Advent2023
{
    public class Program
    {
        public static Day1 day1 = new Day1();

        static void Main(string[] args)
        {
            Console.WriteLine("Please type what day you would like to get the answer of");

            int day = 0;
            if(int.TryParse(Console.ReadLine(), out day))
            {
                switch (day)
                {
                    case 1:
                        day1.Execute();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
