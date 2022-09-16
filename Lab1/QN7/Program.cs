using System;

namespace QN7 {
    class Qn7 {
        public double InchToCm(double inches) {
            return inches * 2.54;
        }
    }

    class Qn7Demo {
        public static void Main(String[] args) {
            Qn7 converter = new Qn7();
            Console.Write("Enter length in inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{inches} inches is {converter.InchToCm(inches)} centimetres.");
        }
    }
}