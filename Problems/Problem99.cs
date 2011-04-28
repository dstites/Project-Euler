using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Problems
{
    class Problem99 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 99; }
        }

        public override string DoProblem()
        {
            //double greatest = 0;
            //var greatestIndex = 0;
            //var input = File.ReadAllLines("C:\\Users\\Daryl Stites\\Downloads\\base_exp.txt");
            //for (var i=0; i< input.Length; i++)
            //{
            //    var line = input[i];
            //    var numbers = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            //    if (numbers.Count() != 2) continue;
            //    var firstNumber = Convert.ToInt32(numbers[0]);
            //    var secondNumber = Convert.ToInt32(numbers[1]);
            //    //double result = 1;
            //    //for(var j=1; j<=secondNumber; j++)
            //    //{
            //    //    result *= firstNumber;
            //    //}
            //    var result = secondNumber * Math.Log(firstNumber);
            //    if (result <= greatest) continue;
            //    greatestIndex = i;
            //    greatest = result;
            //}
            //return (greatestIndex + 1).ToString();
            return string.Empty;
        }
    }
}
