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
            var tempPrev = new Node<T>();
            var i = 0;
            while (i < index)
            {
                tempPrev = temp;
                temp = temp.Next;
                i++;
            }
            
            var newNode = new Node<T>(temp, tempPrev, element);
            if (tempPrev is not null)
                tempPrev.Next = newNode;

            if (temp is not null)
                temp.Prev = newNode;

            if (index == 0)
                _head = newNode;
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
            
            if (index == 0)
            {
                _head = temp.Next;
                return temp.Value;
            }
            
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
                if (temp is null || !EqualityComparer<T>.Default.Equals(temp.Value, element))
                {
                    temp = temp.Next;
                    continue;
                }

                if (temp == _head)
                {
                    _head = temp.Next;
                    temp = _head;
                    if (_head is not null) 
                        _head.Prev = null;
                    deleted++;
                    continue;
                }
                if (temp.Prev is not null)
                    temp.Prev.Next = temp.Next;
                temp.Next.Prev = temp.Prev;
                temp = temp.Next;
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
            if (index < 0)
                throw new ArgumentOutOfRangeException();

            int i = 0;
            var temp = _head;
            while (i < index)
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
        _lenght = 0;
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