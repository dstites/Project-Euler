using System;
using System.Linq;

namespace Problems
{
    class Problem172 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 172; }
        }

        public override string DoProblem()
        {
            int i;
            long ans = 0;
            for (i = 0; i < 10; i++)
            {
                //number of digits used once					
                int j;
                for (j = 0; j < 10; j++)
                {
                    //number of digits used twice
                    int k;
                    for (k = 0; k < 10; k++)
                    {			//number of digits used three times
                        if (i + 2 * j + 3 * k != 18)		//Total digits must match the size of the number
                            continue;
                        if (i + j + k > 10)			//There are a maximum of 10 different digits
                            break;
                        long v = 1;
                        int n = 10 - i - j - k;
                        int a = 3628800;
                        int x;
                        for (x = 1; x <= 18; x++) v *= x;	// v = N!/{1!1!..1!2!2!..2!3!3!..3!}
                        for (x = 1; x <= j; x++) v /= 2;	//         |--i--| |--j--| |--k--|
                        for (x = 1; x <= k; x++) v /= 6;

                        for (x = 1; x <= i; x++) a /= x; // a = [10 i;j;k;n]
                        for (x = 1; x <= j; x++) a /= x;
                        for (x = 1; x <= k; x++) a /= x;
                        for (x = 1; x <= n; x++) a /= x;
                        ans += v * a;
                    }
                }
            }
            return (ans * 9 / 10).ToString();
        }
    }
}
