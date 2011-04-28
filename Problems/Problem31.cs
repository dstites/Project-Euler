using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem31 :BaseProblem
    {
        public override int ProblemId
        {
            get { return 31; }
        }

        public override string DoProblem()
        {
            var count = 0;
            for (int i = 0; i <= 200; i++ )
            {
                for (int j = 0; i + j <= 200; j+= 2)
                {
                    for (int k = 0; i + j + k<= 200; k+= 5)
                    {
                        for (int l = 0; i + j + k + l <= 200; l += 10)
                        {
                            for (int m = 0; i + j + k + l + m <= 200; m += 20)
                            {
                                for (int n = 0; i + j + k + l + m + n <= 200; n += 50)
                                {
                                    for (int o = 0; i + j + k + l + m + n + o <= 200; o += 100)
                                    {
                                        for (int p = 0; i + j + k + l + m + n + p <= 200; p += 200)
                                        {
                                            if (i + j + k + l + m + n + o + p == 200)
                                            {
                                                count++;
                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return count.ToString();
        }
    }
}
