    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public bool CheckParentheses(string val)
            {
                bool isCorrect = true;
                Stack<char> s = new Stack<char>();
     
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == '(')
                    s.Push(val[i]);
                else if (val[i] == ')')
                    if (s.Count > 0)
                        s.Pop();
                    else
                        isCorrect = false;
            }
     
            if(s.Count > 0)
                isCorrect = false;
            
            return isCorrect;
            }
        }
    }