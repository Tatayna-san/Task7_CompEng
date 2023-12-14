using System;

namespace FibonacciNumbers
{
    class Fib
    {
        internal static int[] GetFibonacciNumbers(int n)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            int n = 10; // Количество чисел Фибоначчи, которые мы хотим вычислить

            int a = 0;
            int b = 1;

            Console.WriteLine("Первые " + n + " чисел Фибоначчи:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        
        }
    }
}