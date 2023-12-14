using System;
using NUnit.Framework;
using FibonacciNumbers;
using NUnit.Framework.Legacy;

namespace FibonacciNumbers
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestFibonacciNumbers()
        {
            int n = 10;
            int[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] actual = Fib.GetFibonacciNumbers(n);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFibonacciNumberZero()
        {
            int n = 0; // Количество чисел Фибоначчи, которые мы хотим вычислить

            int a = 0;
            int b = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            });
        }

        [Test]
        public void TestFibonacciNumberNegative()
        {
            int n = -5; // Количество чисел Фибоначчи, которые мы хотим вычислить

            int a = 0;
            int b = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            });
        }
    }
}