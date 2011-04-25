namespace Problems
{
    public class Problem3 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 3; }
        }

        public override string DoProblem()
        {
            var number = 600851475143;
            for (var i = 3; i != number; i += 2)
            {
                while (number % i == 0)
                {
                    number = number / i;
                }
            }
            return number.ToString();
        }
    }
}
