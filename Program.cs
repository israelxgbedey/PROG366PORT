using System;

namespace Assignment_I
{
    using System;

    class Program
    {
        // Method demonstrating O(1) time complexity
        static void ConstantTimeExample()
        {
            // This method performs a constant time operation
            // regardless of the size of input.
            Console.WriteLine("This is a constant time operation.");
        }

        // Method demonstrating O(n) time complexity
        static void LinearTimeExample(int n)
        {
            // This method performs an operation that scales linearly with the size of input n.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("This operation runs in linear time.");

            }

        }

        // Method demonstrating O(n^2) time complexity
        static void QuadraticTimeExample(int n)
        {
            // This method performs an operation that scales quadratically with the size of input n.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("This operation runs in quadratic time.");
                }
            }
        }

        static void Main(string[] args)
        {
            // Call methods to demonstrate their functionality
            ConstantTimeExample();
            LinearTimeExample(5);
            QuadraticTimeExample(6);
        }
    }

}
