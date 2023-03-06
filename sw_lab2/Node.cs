namespace sw_lab2;

internal class Node <T>
{
    private Node<T> _next;

    public Node(Node<T> next)
    {
        _next = next;
    }
}