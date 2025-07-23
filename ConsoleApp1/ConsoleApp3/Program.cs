using System;

namespace MyApp
{
    internal class Program
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach(char c in s)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }

                else if(c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(') return false;
                }
                else if(c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[') return false;
                }
                else if(c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{') return false;
                }

            }

            return stack.Count == 0;
        }


        static void Main(string[] args)
        {
            IsValid("()");
        }
    }
}