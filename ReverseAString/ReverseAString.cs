using System;

namespace Roadrunner.Interview.ReverseAString
{
    public class ReverseAString
    {
        public static char[] Reverse(char[] str)
        {
            char[] retVal = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                retVal[i] = str[str.Length - i - 1];
            }
            return retVal;
        }

        public static char[] ReverseRecursive(char[] str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                char[] retVal = new char[str.Length];
                char[] smallCopy = new char[str.Length - 1];
                for (int i = 0; i < str.Length - 1; i++)
                {
                    smallCopy[i] = str[i];
                }
                retVal[0] = str[str.Length - 1];
                char[] reversed = ReverseRecursive(smallCopy);
                for (int i = 0; i < reversed.Length; i++)
                {
                    retVal[i + 1] = reversed[i];
                }
                return retVal;
            }
        }
    }
}
