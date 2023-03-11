using System.Collections;

namespace sw_lab2;

public class MyLinkedList<T> : IMyList<T>
{
    private List<T> _list = new();
    public int Length()
        => _list.Count;
    
    public void Append(T element)
    {
        _list.Add(element);
    }

    public void Insert(T element, int index)
    {
        
        try
        {
            _list.Insert(index, element);
        }
        catch
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public T Delete(int index)
    {
        try
        {
            var el = _list[index];
           _list.RemoveAt(index);
           return el;
        }
        catch
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void DeleteAll(T element)
    {
        try
        {
            _list.RemoveAll(i => EqualityComparer<T>.Default.Equals(i, element));
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public T Get(int index)
    {
        try
        {
            return _list[index];
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
        _list.Reverse();
    }

    public int FindFirst(T element)
    {
        try
        {
            return _list.FindIndex(i => EqualityComparer<T>.Default.Equals(i, element));
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
            return _list.FindLastIndex(i => EqualityComparer<T>.Default.Equals(i, element));
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void Clear()
    {
        _list.Clear();
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
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}