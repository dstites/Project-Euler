using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem17 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 17; }
        }

        private static readonly Dictionary<int, string> _wordDictionary = new Dictionary<int, string>
                {
                    {0, "zero"},
                    {1, "one"},
                    {2, "two"},
                    {3, "three"},
                    {4, "four"},
                    {5, "five"},
                    {6, "six"},
                    {7, "seven"},
                    {8, "eight"},
                    {9, "nine"},
                    {10, "ten"},
                    {11, "eleven"},
                    {12, "twelve"},
                    {13, "thirteen"},
                    {14, "fourteen"},
                    {15, "fifteen"},
                    {16, "sixteen"},
                    {17, "seventeen"},
                    {18, "eighteen"},
                    {19, "nineteen"},
                    {20, "twenty"},
                    {30, "thirty"},
                    {40, "forty"},
                    {50, "fifty"},
                    {60, "sixty"},
                    {70, "seventy"},
                    {80, "eighty"},
                    {90, "ninety"},
                    {100, "hundred"},
                    {1000, "thousand"}
                };
   

        public string GetCountNumberString(int number)
        {

            // if between 1 and 19, convert to word
            if (0 <= number && number < 20)
            {
                return _wordDictionary[number];
            }

            // if between 20 and 99, convert tens to word then recurse for units
            if (20 <= number && number < 100)
            {
                return ProcessTens(number);
            }

            // if between 100 and 999, convert hundreds to word then recurse for tens
            if (100 <= number && number < 1000)
            {
                return ProcessHundreds(number);
            }

            return String.Empty;
        }

        private string ProcessHundreds(int number)
        {
            var hundreds = number / 100;
            var remainder = number % 100;
            string conversion = _wordDictionary[hundreds] + " " + _wordDictionary[100];
            conversion += remainder > 0 ? " and " + GetCountNumberString(remainder) : "";
            return conversion;
        }

        private string ProcessTens(int number)
        {
            // split the number into the number of tens and the number of units,
            // so that words for both can be looked up independantly
            var tens = (number / 10) * 10;
            var units = number % 10;
            string conversion = _wordDictionary[tens];
            conversion += units > 0 ? "-" + _wordDictionary[units] : "";
            return conversion;
        }

        public override string DoProblem()
        {
            var count = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i == 1000)
                {
                    count += 11;
                }else
                {
                    count += GetCountNumberString(i).ToCharArray().Count(q => Char.IsLetter(q));
                }
            }
            return count.ToString();
        }
    }
}
