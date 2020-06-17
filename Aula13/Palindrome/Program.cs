using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine($"{s} -> {Palindrome(s)}");
            }
        }

        private static bool Palindrome(string str)
        {
            if (str == null) throw new ArgumentException("String is null!");
            if (str.Length < 2) return true;
            return LocalPalindrome(0, str.Length - 1);

            bool LocalPalindrome(int low, int high)
            {
                if (low >= high)
                    return true;
                if (str.ToLower()[low] != str.ToLower()[high])
                    return false;

                return LocalPalindrome(low + 1, high - 1);
            }
        }
    }
}
