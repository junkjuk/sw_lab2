namespace sw_lab2;

internal class Node <T>
{
    public Node<T> Next;
    public Node<T> Prev;
    public T Value;

    public Node()
    {
        
    }

    public Node(Node<T> next, Node<T> prev, T value)
    {
        Next = next;
        Prev = prev;
        Value = value;
    }
}