using System;

namespace FibonacciNumbers
{
    class Program
    {
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