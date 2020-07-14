

using System.Collections.Generic;
/**
将下标入栈，下标差就是结果
*/
public class Solution739 {
    public int[] DailyTemperatures(int[] T) {

        Stack<int> st = new Stack<int>();

        for(int i = 0; i < T.Length; i++) {
            if (st.Count == 0) {
                st.Push(i);
            }
            else {
                int j = st.Peek();
                //T[i] < T[st.Peek()],入栈
                if (T[i] > T[j]){
                    st.Pop();
                    T[j] = i - j;
                    i--;
                }
                else {
                    st.Push(i);
                }
            }
        }

        while (st.Count > 0) {
            T[st.Pop()] = 0;
        }

        return T;
    }
}