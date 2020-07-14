using System;
using System.Collections.Generic;

///有效的括号
public class Solution20: RunExample {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();

        foreach(char c in s) {
            if (st.Count != 0 ) {
                char top = st.Peek();
                if ((c == ')' && top == '(') || 
                (top=='{' && c=='}') ||
                (top == '[' && c == ']')){
                    st.Pop();
                }
                else 
                    st.Push(c);
            }
            else
                st.Push(c);
        }
        return st.Count == 0;
    }

    public override void Run()
    {
        string s = "((({})))";
        Console.WriteLine(IsValid(s));
    }
}