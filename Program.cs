using System.Collections.Generic;
using System;
using System.IO;
using System.Text;

namespace PassGen {
    
    class Program {
    
        static void Main(string[] args) {
            int length = 0;
            Console.WriteLine("Please enter the length of your password: ");
            string filename = "/home/kali/Рабочий стол/key.txt";
            try {
                length = int.Parse(Console.ReadLine());
                string pass = PasswordGen(length);
                Console.WriteLine(pass);
                using (StreamWriter stream = new StreamWriter(filename)) {
                    stream.WriteLine(pass);
                    stream.Close();
                }
            } catch (FormatException) {
                Console.WriteLine("Incorrect input. Please try again.");
            }
        }

        public static string PasswordGen(int length) {
            Random rand = new Random();
            char a = ' ';
            string Password = "";
            while (Password.Length < length) {
                a = (char)(rand.Next(48, 126));
                Password += a;
                }
            return Password;
        }
    }
}