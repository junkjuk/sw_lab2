using sw_lab2;

var a = new MyLinkedList<int>();
a.Append(0);
a.Append(1);
a.Append(2);
a.Append(3);
a.Append(4);

foreach (var vvv in a)
{
    Console.WriteLine(vvv);
}
a.Reverse();
foreach (var vvv in a)
{
    Console.WriteLine(vvv);
}