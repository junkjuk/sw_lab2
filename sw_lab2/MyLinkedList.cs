namespace sw_lab2;

public class MyLinkedList<T> : IMyList<T>
{
    private Node<T> _head;
    private int _lenght = 0;

    public int Length()
        => _lenght;

    public IEnumerable<T> GetAll()
    {
        var list = new List<T>();
        var temp = _head;
        while (temp is not null)
        {
            list.Add(temp.Value);
            temp = temp.Next;
        }

        return list;
    }
    
    public void Append(T element)
    {
        _lenght++;
        var temp = _head; 
        while (temp is not null && temp.Next is not null)
        {
            temp = temp.Next;
        }
        var newNode = new Node<T>(null, temp, element);
        if (temp is not null)
            temp.Next = newNode;
        else
            _head = newNode;
    }

    public void Insert(T element, int index)
    {
        _lenght++;
        try
        {
            var temp = _head;
            var i = 0;
            while (i < index)
            {
                temp = temp.Next;
                i++;
            }
            var newNode = new Node<T>(temp, temp.Prev, element);
            temp.Prev.Next = newNode;
            temp.Prev = newNode;
        }
        catch
        {
            _lenght--;
            throw new ArgumentOutOfRangeException();
        }
    }

    public T Delete(int index)
    {
        _lenght--;
        try
        {
            var temp = _head;
            var i = 0;
            while (i < index)
            {
                temp = temp.Next;
                i++;
            }

            if (temp.Prev is not null)
                temp.Prev.Next = temp.Next;
            temp.Next = temp.Prev;
            return temp.Value;
        }
        catch
        {
            _lenght++;
            throw new ArgumentOutOfRangeException();
        }
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