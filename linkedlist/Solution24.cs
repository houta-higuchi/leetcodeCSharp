
///两两交换链表中的节点
public class Solution24 {
    //迭代
    public ListNode SwapPairs(ListNode head) {
        //添加头节点
        ListNode thread = new ListNode(-1);
        thread.next = head;

        ListNode pre = thread; //指向head的前一位

        while(head != null && head.next != null) {
            
            ListNode a = head;
            ListNode b = head.next;

            pre.next = b;
            a.next = b.next;
            b.next = a;

            //交换后，a是当前的末尾节点
            pre = a;
            head = a.next;
        }
        return thread.next;
    }

    //递归
    //以head开始交换，返回当前的头节点
    public ListNode SwapPairsV2(ListNode head) {
        if (head == null || head.next == null) return head;

        ListNode a = head;
        ListNode b = head.next;

        a.next = SwapPairsV2(b.next);
        b.next = a;
        return b;

    }
}