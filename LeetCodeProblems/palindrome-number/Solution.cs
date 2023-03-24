namespace palindrome_number
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            int temp = x;
            int sum = 0;

            while (x > 0)
            {
                int r = x % 10;
                x /= 10;
                sum = sum * 10 + r;
            }

            if (temp == sum) return true;
            else return false;
        }

        public static bool IsValid(string s)
        {
            bool res = false;

            if(!(s.Length % 2 == 0)) return res;

            for (int i = 0; i < s.Length - 1; i = i + 2)
            {
                Console.WriteLine($"{s[i]} {s[i + 1]}");
                if (s[i] == s[i + 1])
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

                Console.WriteLine(res);
            };

            return res;
        }
    }
}
