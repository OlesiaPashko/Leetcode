namespace Leetcode.Easy
{
    //TASK
    //Figure out is some int is read from left to right same way as from right to left

    //EXAMPLE

    //INPUT
    //121

    //OUTPUT
    //true
    public class PalindromeTask
    {
        //naive way to solve using chars
        public static bool IsPalindrome(int x)
        {
            var str = x.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        //better way to solve without using chars
        public static bool IsPalindromeWithoutChars(int x)
        {
            int z = x;
            long y = 0;
            while (x > 0)
            {
                y += x % 10;
                x /= 10;
                y *= 10;
            }

            return z == y / 10;
        }
    }
}