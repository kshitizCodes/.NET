using System;

namespace QN5 {
    class Qn5 {
        public void PrintPrime() {
            for (int i = 1; i <= 100; i++) {
                bool flag = true;
                if (i == 1) Console.WriteLine($"{i} is neither prime nor composite.");
                for (int j = 2; j <= i / 2; j++) {
                    if (i % j == 0) {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    Console.WriteLine($"{i} is prime.");
                else {
                    Console.WriteLine($"{i} is composite.");
                }
            }
        }
    }

    class Program {
        public static void Main(string[] args) {
            new Qn5().PrintPrime();
        }
    }
}