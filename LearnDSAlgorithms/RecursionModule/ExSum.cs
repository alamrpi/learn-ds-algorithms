namespace LearnDSAlgorithms.RecursionModule
{
    public class ExSum
    {
        public int SumOfNUsingFormula(int n)
        {
            return n * (n + 1) / 2;
        }

        public int SumOfNUsingItteration(int n)
        {
            int sum = 0;
            int i = 1;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            return sum;
        }

        public int SumOfNUsingRecursion(int n)
        {
            if (n == 1)
                return n;

            return SumOfNUsingRecursion(n - 1) + n;
        }
    }
}
