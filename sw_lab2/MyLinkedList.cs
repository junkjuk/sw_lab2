namespace sw_lab2;

public class MyLinkedList<T> : IMyList<T>
{
    private Node<T> _head;
    private int _lenght = 0;

    public int Length()
        => _lenght;
    

    public void Append(T element)
    {
        _lenght++;
    }

    public void Insert(T element, int index)
    {
        _lenght++;
    }

    public T Delete(int index)
    {
        throw new NotImplementedException();
    }

    public void DeleteAll(T element)
    {
        throw new NotImplementedException();
    }

    public T Get(int index)
    {
        throw new NotImplementedException();
    }

    public IMyList<T> Clone()
    {
        throw new NotImplementedException();
    }

    public int FindFirst(T element)
    {
        throw new NotImplementedException();
    }

    public int FindLast(T element)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public void Extend(IMyList<T> list)
    {
        throw new NotImplementedException();
    }
}