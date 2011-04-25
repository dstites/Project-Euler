namespace Problems
{
    public class Problem1 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 1; }
        }

        public override string DoProblem()
        {
            var sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum.ToString();
        }
    }
}
