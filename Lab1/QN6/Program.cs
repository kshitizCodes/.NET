using System;

namespace QN6 {
    class Qn6 {
        public static string Hello(String firstname, String lastname) {
            return $"Hello {firstname} {lastname}!";
        }

        public static void Main(string[] args) {
            Console.Write("Enter firstname: ");
            String firstname = Console.ReadLine();
            Console.Write("Enter lastname: ");
            String lastname = Console.ReadLine();
            Console.WriteLine(Hello(firstname, lastname));
        }
    }
}