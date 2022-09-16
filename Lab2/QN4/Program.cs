using System;

namespace QN4 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num != 0) {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine($"The sum of each digit of entered number is {sum}");
        }
    }
}