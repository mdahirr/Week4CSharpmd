using System.Security.Cryptography.X509Certificates;

namespace FactorialAndFibApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"factorial iterative: {FactorialIterative(5)}");
            Console.WriteLine($"factorial recurrsive: {FactorialRecursive(5)}");
            Console.WriteLine($"fib iterative: {FibonacciIterative(8)}");
            Console.WriteLine($"fib recurrsive: {FibonacciRecursive(8)}");
        }

        #region Factorial iterative
        public static int FactorialIterative(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region Factorial Recursive

        public static int FactorialRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FactorialRecursive( n - 1);
        }
        #endregion

        #region fib iterative

        public static int FibonacciIterative(int n)
        {
            int sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sum = i + (i + 1);
            }
            return sum;
        }
        #endregion

        #region fib Recursive
        public static int FibonacciRecursive(int n)
        {
            if ( n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }

        }
        #endregion
                
    }
}