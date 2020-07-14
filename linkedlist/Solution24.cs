
///两两交换链表中的节点
public class Solution24 {
    //迭代
    public ListNode SwapPairs(ListNode head) {
        //添加头节点
        //有3个指针pre,a,b
        //pre指向不移动的节点，移动a和b的位置
        //交换ab后，pre.next指向b
        //因为ab已经交换，a作为新的结尾，并且a不会再移动，pre指向a，a指向pre.next
        //中止条件：pre为null或者a为null

        //pre的作用：1.用于返回，pre.next就是结果。2.指向不移动的节点，交换后两个节点
        ListNode thread = new ListNode(-1);
        thread.next = head;

        ListNode pre = thread; //指向head的前一位

        while(head != null && head.next != null) {
            
            ListNode a = head;
            ListNode b = head.next;

            a.next = b.next;
            b.next = a;
            pre.next = b;
            
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