namespace Problems
{
    public class Problem2 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 2; }
        }

        public override string DoProblem()
        {
            var sum = 0;
            var x1 = 1;
            var y1 = 2;
            while (x1 < 4000000)
            {
                var x2 = y1;
                var y2 = x1 + y1;
                if (x1 % 2 == 0)
                {
                    sum += x1;
                }
                x1 = x2;
                y1 = y2;
            }
            return sum.ToString();
        }
    }
}
