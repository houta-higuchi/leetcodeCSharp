///基本计算器
using System.Collections.Generic;
public class Solution224 {
    
    //存放符号的栈
    Stack<char> st1 = new Stack<char>();
    //存放操作数的栈
    Stack<int> st2 = new Stack<int>();
    //放原始数据的栈
    Stack<char> st3 = new Stack<char>();

    public int Calculate(string s) {

        s = s.Replace(" ", "");
        s = "(" + s + ")";
        foreach(char c in s) {
            if (c != ')') {
                st3.Push(c);
            }
            else {
                Cul();
            }
        }
        if (st3.Count != 0) {
            Cul();
        }
        
        return st2.Pop();

    }


    public void Cul(){
        
        int num = 0;
        int unit = 0;
        while(st3.Count != 0 && st3.Peek() != '(') {
            char d = st3.Pop();
            int cur = IsNum(d);
            if (cur > -1) {
                int num1 = 1;
                for(int i = 0; i < unit; i++) {
                    num1 *= 10;
                }
                num += num1*cur;
                unit ++ ;
            }
            else {
                st2.Push(num);
                st1.Push(d);

                num = 0;
                unit= 0;

                if (st2.Count == 2) {
                    char e = st1.Pop();
                    if (e == '-') {
                        st2.Push(-st2.Pop() + st2.Pop());
                    }
                    else {
                        st2.Push(st2.Pop() + st2.Pop());
                    }
                }
            }
        }

        if (num != 0) {
            st2.Push(num);
            num = 0;
            if (st2.Count == 2) {
                char e = st1.Pop();
                if (e == '-') {
                    st2.Push(st2.Pop() - st2.Pop());
                }
                else {
                    st2.Push(st2.Pop() + st2.Pop());
                }
            }
        }
    }

    public int IsNum(char c) {
        return c == '0'?0:
        c == '1' ?1:
        c == '2' ?2:
        c == '3' ?3:
        c == '4' ?4:
        c == '5' ?5:
        c == '6' ?6:
        c == '7' ?7:
        c == '8' ?8:
        c == '9' ?9:-1;
    }
}