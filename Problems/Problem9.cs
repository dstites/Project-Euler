namespace Problems
{
    class Problem9 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 9; }
        }

        public override string DoProblem()
        {
            for (var a = 1; a < 332; a++)
            {
                for (var b = a + 1; b > a && b < 1000; b++)
                {
                    var c = 1000 - b - a;
                    if ((c > b) && (a + b + c == 1000) && (a*a + b*b == c*c))
                    {
                        return (a*b*c).ToString();
                    }
                }
            }
            return string.Empty;
        }
    }
}
