using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent2023
{
    public class Day1
    {
        string[] lines = File.ReadAllLines(@"D:\PersonalProjects\Advent\2023\AdventCalander2023\Advent2023\inputs\input-day1.txt");
        List<int> allNumbers = new List<int>();

        Dictionary<string, int> convert = new Dictionary<string, int>()
        {
            {"one", 1},
            {"two", 2 },
            {"three", 3},
            {"four", 4 },
            {"five", 5},
            {"six", 6 },
            {"seven", 7},
            {"eight", 8 },
            {"nine", 9}
        };

        public void Execute()
        {
            Console.WriteLine("Please select answer 1 or 2");
            int part = 0;
            if (int.TryParse(Console.ReadLine(), out part))
            {
                switch (part)
                {
                    case 1:
                        part1();
                        break;
                    case 2:
                        part2();
                        break;
                    default:
                        break;
                }
            }
            
        }

        void part1()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string allNumbersInString = "";
                for (int j = 0; j < lines[i].Length; j++)
                {
                    int temp = 0;
                    if (int.TryParse(lines[i][j].ToString(), out temp))
                    {
                        allNumbersInString += temp.ToString();
                    }
                }

                string tempNumber = allNumbersInString[0].ToString() + allNumbersInString[allNumbersInString.Length - 1].ToString();
                int outTemp = 0;
                if (int.TryParse(tempNumber, out outTemp))
                {
                    allNumbers.Add(outTemp);
                }
            }
            int result = 0;
            foreach (var number in allNumbers)
            {
                result += number;
            }
            Console.WriteLine(result);
        }

        void part2()
        {

            for (int i = 0; i < lines.Length; i++)
            {
                string tempFront = "";
                string first = "";
                string last = "";
                //Check from front
                for (int j = 0; j < lines[i].Length; j++)
                {
                    int tempNumberFront = 0;
                    if(int.TryParse(lines[i][j].ToString(), out tempNumberFront))
                    {
                        first = tempNumberFront.ToString();
                        break;
                    }
                    else
                    {
                        tempFront += lines[i][j];
                        if (convert.ContainsKey(tempFront))
                        {
                            first = tempFront;
                        }
                    }
                }


            }
        }
    }
}
