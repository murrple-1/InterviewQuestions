using System;
using System.Collections.Generic;

namespace Roadrunner.Interview.LispesqueParser
{
    public class LispesqueParser
    {
        public static int Parse(string input)
        {
            Stack<string> parseStack = new Stack<string>();
            string[] parts = input.Split(' ');
            for (int i = parts.Length - 1; i >= 0; i--)
            {
                parseStack.Push(parts[i]);
            }

            return HandleTop(parseStack);
        }

        private static int HandleTop(Stack<string> stack)
        {
            string top = stack.Pop();
            switch (top)
            {
                case "+":
                    {
                        int o1 = HandleTop(stack);
                        int o2 = HandleTop(stack);
                        return o1 + o2;
                    }
                case "-":
                    {
                        int o1 = HandleTop(stack);
                        int o2 = HandleTop(stack);
                        return o1 - o2;
                    }
                case "*":
                    {
                        int o1 = HandleTop(stack);
                        int o2 = HandleTop(stack);
                        return o1 * o2;
                    }
                case "/":
                    {
                        int o1 = HandleTop(stack);
                        int o2 = HandleTop(stack);
                        return o1 / o2;
                    }
                default:
                    {
                        return Int32.Parse(top);
                    }
            }
        }
    }
}
