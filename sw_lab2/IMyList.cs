namespace sw_lab2;

public interface IMyList<T> : IEnumerable<T>
{
    int Length();
    void Append(T element);
    void Insert(T element, int index);
    T Delete(int index);
    void DeleteAll(T element);
    T Get(int index);
    IMyList<T> Clone();
    void Reverse();
    int FindFirst(T element);
    int FindLast(T element);
    void Clear();
    void Extend(IEnumerable<T> list);
}