using System.Collections;

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
        var deleted = 0;
        try
        {
            var temp = _head;
            while (temp is not null)
            {
                temp = temp.Next;
                if (EqualityComparer<T>.Default.Equals(temp.Value, element)) 
                    continue;
                
                if (temp.Prev is not null)
                    temp.Prev.Next = temp.Next;
                temp.Next = temp.Prev;
                deleted++;
            }

            _lenght -= deleted;
        }
        catch (Exception e)
        {
            _lenght += deleted;
            throw new ArgumentOutOfRangeException();
        }
    }

    public T Get(int index)
    {
        try
        {
            int i = 0;
            var temp = _head;
            while (i <= index)
            {
                temp = temp.Next;
                i++;
            }

            return temp.Value;
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public IMyList<T> Clone()
    {
        try
        {
            var newList = new MyLinkedList<T>();
            foreach (var val in this)
            {
                newList.Append(val);
            }

            return newList;
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void Reverse()
    {
        var temp = _head; 
        while (temp is not null)
        {
            if (temp.Next is null)
            {
                _head = temp;
            }

            var n = temp.Next;
            var p = temp.Prev;
            temp.Next = p;
            temp.Prev = n;
            temp = temp.Prev;
        }
    }

    public int FindFirst(T element)
    {
        try
        {
            var i = 0;
            foreach (var val in this)
            {
                if (EqualityComparer<T>.Default.Equals(val, element))
                    return i;
                i++;
            }

            return -1;
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public int FindLast(T element)
    {
        try
        {
            var i = 0;
            var lastFind = -1;
            foreach (var val in this)
            {
                if (EqualityComparer<T>.Default.Equals(val, element))
                    lastFind = i;
                i++;
            }

            return lastFind;
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void Clear()
    {
        _head = null;
    }
    
    public void Extend(IEnumerable<T> list)
    {
        foreach (var val in list)
        {
            Append(val);
        }
    }

    
    // Implement Iterator pattern
    public IEnumerator<T> GetEnumerator()
    {
        var temp = _head;
        while (temp is not null)
        {
            yield  return temp.Value;
            temp = temp.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}