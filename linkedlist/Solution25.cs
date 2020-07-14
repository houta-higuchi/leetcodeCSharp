
///K 个一组翻转链表
public class Solution25 {

    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null) return head;

        ListNode a = head;
        ListNode pre = null;
        int i = k;

        //判断是否够k个
        while(i-- > 0 && a != null){
            a = a.next;
        }
        if (i >= 0) return head;

        a = head;
        i = k;

        while(i-- > 0 && a != null) {
            ListNode next = a.next;
            a.next = pre;

            pre = a;
            a = next;
        }

        head.next = ReverseKGroup(a, k);
        return pre;
    }
}