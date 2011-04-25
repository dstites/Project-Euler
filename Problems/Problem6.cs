namespace Problems
{
    public class Problem6 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 6; }
        }

        public override string DoProblem()
        {
            var sum = 0;
            var squares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                squares += i*i;
            }
            return ((sum * sum) - squares).ToString();
        }
    }
}
