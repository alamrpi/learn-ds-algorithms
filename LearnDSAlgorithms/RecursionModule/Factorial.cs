namespace LearnDSAlgorithms.RecursionModule
{
    public class Factorial
    {
        public int FactorialRecursion(int n)
        {
            if(n == 0) return 1;

            return FactorialRecursion(n - 1) * n;
        }

        public int FactorialItterative(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
