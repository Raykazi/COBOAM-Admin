using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBOAM_Admin.Classes
{
    static class Functions
    {
        public static int GCD(int number, int[] divisors)
        {
            int[] nb = new int[divisors.Length];
            for (int i = (divisors.Length - 1); i >= 0; i--)
            {
                if (number == divisors[i]) continue;
                int gcd = number % divisors[i];
                if (gcd == 1) nb[i] = divisors[i];
                if (gcd != 0) continue;
                return divisors[i];
            }
            return nb.Max();
        }

        private static int GCD(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }
    }
}
