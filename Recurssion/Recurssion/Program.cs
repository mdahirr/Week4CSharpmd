namespace Recurssion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SumLoop of 5: {SumLoop(5)}");
            Console.WriteLine($"SumRecursive of 5: {SumRecursive(5)}");
        }

        // recursive method

        public static int SumRecursive(int n)
        {
            if (n == 0) return 0;
            int prev = SumRecursive(n - 1);
            int sum = n + prev;
            return sum;
        }

        //iterative method

        public static int SumLoop(int n) 
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

       
    }
}