using System;

namespace QN1 {
    class Qn1 {
        public static void Main(string[] args) {
            Console.Write("Enter firstname: ");
            String firstname = Console.ReadLine();
            Console.Write("Enter lastname: ");
            String lastname = Console.ReadLine();
            Console.WriteLine($"Hello {firstname} {lastname}");
        }
    }
}