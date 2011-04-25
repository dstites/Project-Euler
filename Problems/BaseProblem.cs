using System;

namespace Problems
{
    public abstract class BaseProblem
    {
        private static DateTime Start { get; set; }
        private static DateTime End { get; set; }
        public abstract int ProblemId { get; }

        public void Run()
        {
            Start = DateTime.Now;
            var result = DoProblem();
            End = DateTime.Now;
            
            Console.WriteLine("Problem {0}: {1}, ran in {2} seconds", ProblemId, result, End.Subtract(Start).TotalSeconds);
        }

        public abstract string DoProblem();
    }
}
