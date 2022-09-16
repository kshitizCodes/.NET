using System;

namespace QN8 {
    class Qn8 {
        public static double Area(double length, double width) {
            return length * width;
        }
    }

    class Qn8Demo {
        public static void Main(String[] args) {
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area is {Qn8.Area(length, width)}.");
        }
    }
}