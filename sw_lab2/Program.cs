using sw_lab2;

var a = new MyLinkedList<int>();
a.Append(0);
a.Append(1);
a.Append(2);
a.Append(3);
a.Append(4);

a.Insert(5, 0);
foreach (var vvv in a.GetAll())
{
    Console.WriteLine(vvv);
}
