using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem79 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 79; }
        }

        private static List<int> _passcode = new List<int>();

        private static void AddValToPasscode(int val)
        {
            var index = _passcode.SingleOrDefault(q => q == val);
            if (index != 0)
            {

            }
            else
            {
                _passcode.Add(val);   
            }
            
        }

        public override string DoProblem()
        {
            var lines = File.ReadAllLines("keylog.txt");
            var list = new List<short>();
            //foreach (var line in lines)
            //{
            //    foreach (var ch in line)
            //    {
            //        var val = Convert.ToInt16(ch) - 48;
            //        AddValToPasscode(val);
            //    }
            //}
            return string.Empty;
        }
    }
}
