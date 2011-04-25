namespace Problems
{
    //    The prime factors of 13195 are 5, 7, 13 and 29.
    //What is the largest prime factor of the number 600851475143 ?
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
