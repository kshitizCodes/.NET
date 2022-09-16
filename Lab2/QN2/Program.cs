using System;

namespace QN2 {
    class Qn2 {
        int n;

        public Qn2(int n) {
            this.n = n;
        }

        public void CheckPrime() {
            bool flag = true;
            for (int i = 2; i <= n / 2; i++) {
                if (n % i == 0) {
                    flag = !flag;
                    break;
                }
            }

            if (flag)
                Console.WriteLine($"{n} is prime.");
            else
                Console.WriteLine($"{n} is composite.");
        }
    }

    class Program {
        public static void Main(string[] args) {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            new Qn2(n).CheckPrime();
        }
    }
}