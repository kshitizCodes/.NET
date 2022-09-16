using System;

namespace QN4 {
    internal class Qn4 {
        public string FullName(string firstname, string lastname) {
            return $"{firstname} {lastname}";
        }

        public static void Main(string[] args) {
            Qn4 person = new Qn4();
            Console.WriteLine(person.FullName("John", "Doe"));
        }
    }
}