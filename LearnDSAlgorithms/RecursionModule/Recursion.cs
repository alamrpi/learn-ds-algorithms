using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    public class Recursion
    {
        public void TailRecursion(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                TailRecursion(n - 1);
            }
        }

        public void HeadRecursion(int n)
        {
            if (n > 0)
            {
                HeadRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        public void TreeRecursion(int n)
        {
            if (n > 0)
            {
                TreeRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                TreeRecursion(n - 1);
            }
        }
    }
}
