namespace Leetcode.Easy
{
    //TASK
    //Figure out the longest common prefix

    //EXAMPLE

    //INPUT
    //["flower","flow","flight"]

    //OUTPUT
    //"fl"
    public class CommonPrefixTask
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";
            var firstWord = strs[0];
            for (int i = 0; i < firstWord.Length; i++)
            {
                foreach (var str in strs)
                {
                    if (i==str.Length || str[i] != firstWord[i])
                    {
                        return prefix;
                    }
                }

                prefix += firstWord[i];
            }

            return prefix;
        }
    }
}