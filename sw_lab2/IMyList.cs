namespace sw_lab2;

public interface IMyList<T>
{
    int Length();
    void Append(T element);
    void Insert(T element, int index);
    T Delete(int index);
    void DeleteAll(T element);
    T Get(int index);
    IMyList<T> Clone();
    int FindFirst(T element);
    int FindLast(T element);
    void Clear();
    void Extend(IMyList<T> list);
}