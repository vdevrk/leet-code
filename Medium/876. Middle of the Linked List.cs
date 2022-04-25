/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int NodeCount = 0,middleNode = 0;
        ListNode newNode = head;
        while(head != null) {
            head = head.next;
            NodeCount++;
        }
        middleNode = NodeCount / 2;
        
        
        
       for(int i = 0; i<middleNode; i++) {
           newNode = newNode.next;
       }
        
        return newNode;
    }
}