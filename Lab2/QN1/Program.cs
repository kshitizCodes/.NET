using System;

namespace QN1 {
    class Qn1 {
        int n;

        public Qn1(int n) {
            this.n = n;
        }

        public void OddEven() {
            String result = (n % 2 == 0) ? "even." : "odd.";
            Console.WriteLine($"{n} is {result}");
        }
    }

    class Program {
        public static void Main(string[] args) {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            new Qn1(n).OddEven();
        }
    }
}