using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Pow_x__n_
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n >  0)
            {
                return __Pow(x, n);
            }
            return 1.0/(__Pow(x, -1L*Convert.ToInt64(n) ));
        }
        public double __Pow(double x, long n)
        {
            if (n >= 1)
            {
                double tmp= __Pow(x, n / 2);
                if (n % 2 == 1)
                {
                    return tmp * tmp * x;
                }
                else
                {
                    return tmp * tmp;
                }
            }
            return 1.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Solution()).MyPow(34.00515,-3));
            Console.ReadKey();
        }
    }
}
