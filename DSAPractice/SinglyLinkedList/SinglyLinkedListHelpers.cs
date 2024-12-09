using DSAPractice.SinglyLinkedList;

internal static class SinglyLinkedListHelpers
{

    public static void Push(SinglyNode? head, int value)
    {
        if (head == null)
        {
            head = new SinglyNode(value);
            return;
        }

        SinglyNode node = new SinglyNode(value);

        SinglyNode current = head;

        while (current.next != null)
        {
            current = current.next;
        }

        current.next = node;


    }
}