using System;

namespace QN2 {
    class Qn2 {
        public static string FullName(string firstname, string lastname) {
            return $"{firstname} {lastname}";
        }

        public static void Main(string[] args) {
            Console.WriteLine(FullName("John", "Doe"));
        }
    }
}