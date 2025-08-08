
using System;
using System.Diagnostics;
using System.IO.Pipelines;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?`~";
            Console.WriteLine("Enter a password :");
            string password = Console.ReadLine();
            int score = 0;
            if (password.Length >= minLength) { score++; }
            if (Tools.Contains(password, uppercase)) { score++; }
            if (Tools.Contains(password, lowercase)) { score++; }
            if (Tools.Contains(password, digits)) { score++; }
            if (Tools.Contains(password, specialChars)) { score++; }
            Console.WriteLine("your password score "+score);
            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("the password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("the password is strong");
                    break;
                case 2:
                    Console.WriteLine("the password is medium");
                    break;
                case 1:
                    Console.WriteLine("the password is weak");
                    break;
                default:
                    Console.WriteLine("the password doesn’t meet any of the standards");
                    break;
            }
        }
    }
}
