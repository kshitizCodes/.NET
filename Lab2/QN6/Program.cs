using System;

namespace QN6 {
    class Program {
        public static void Main(string[] args) {
            int count = 0;
            Console.Write("Enter a string: ");
            String text = Console.ReadLine().ToLower();
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                    count += 1;
            }

            Console.WriteLine($"There are {count} vowels in entered string.");
        }
    }
}