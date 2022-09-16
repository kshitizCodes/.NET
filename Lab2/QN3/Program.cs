using System;

namespace QN3 {
    class Qn3 {
        public void Fibonacci(int n) {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++) {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
        }
    }
    class Program {
        public static void Main(string[] args) {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            new Qn3().Fibonacci(num);
        }
    }
}