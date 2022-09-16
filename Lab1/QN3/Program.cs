using System;

namespace QN3 {
    class Qn3 {
        public static String FullName(String firstname, String lastname) {
            return $"{firstname} {lastname}";
        }
    }

    class Qn3Demo {
        public static void Main(String[] args) {
            Console.WriteLine(Qn3.FullName("John", "Doe"));
        }
    }
}