using System;

namespace QN5 {
    class Qn5 {
        public String FullName(String firstname, String lastname) {
            return $"{firstname} {lastname}";
        }
    }

    class Qn5Demo {
        public static void Main(String[] args) {
            Qn5 person = new Qn5();
            Console.WriteLine(person.FullName("John", "Doe"));
        }
    }
}