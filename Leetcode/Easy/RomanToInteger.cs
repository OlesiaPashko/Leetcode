namespace Leetcode.Easy
{
    using System.Collections.Generic;
    
    //TASK
    //Calculate int from string in Roman numeral

    //EXAMPLE

    //INPUT
    //"MCMXCIV"

    //OUTPUT
    //1994
    public class RomanToInteger
    {
         public static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int RomanToInt(string s)
        {
            string forwardString;
            int number = SumUpInverse(s, out forwardString);
            number += SumUpForward(forwardString);
            return number;
        }

        private static int SumUpInverse(string s, out string forwardString)
        {
            int number = 0;
            forwardString = "";
            int i = 0;
            for (; i < s.Length - 1; )
            {
                if(IsInverse(s, i))
                {
                    number += GetInverseNumber(s, i);
                    i += 2;
                }
                else
                {
                    forwardString += s[i];
                    i++;
                }
            }
            
            if (i == s.Length - 1)
            {
                forwardString += s[i];
            } 
            return number;
        }
        
        private static int SumUpForward(string s)
        {
            int number = 0;
            int i = 0;
            for (; i < s.Length - 1; i++)
            {
                if(!IsInverse(s, i))
                {
                    number += GetForwardNumber(s, i);
                }
            }
            
            if (i == s.Length - 1)
            {
                number += dict[s[i]];
            }

            return number;
        }

        private static bool IsInverse(string str, int index)
        {
            var ch = str[index];
            var nextCh = str[index + 1];
            var value = dict[ch];
            var nextValue = dict[nextCh];
            return nextValue > value;
        }
        
        private static int GetInverseNumber(string str, int index)
        {
            var ch = str[index];
            var nextCh = str[index + 1];
            var value = dict[ch];
            var nextValue = dict[nextCh];
            return nextValue - value;
        }
        
        private static int GetForwardNumber(string str, int index)
        {
            var ch = str[index];
            var value = dict[ch];
            return value;
        }
    }
}