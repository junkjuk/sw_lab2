using sw_lab2;

var test = new MyLinkedList<char>();
test.Append('1');
test.Append('2');
test.Append('3');
foreach (var vvv in test)
{
    Console.WriteLine(vvv);
}
test.Get(-1);


foreach (var vvv in test)
{
    Console.WriteLine(vvv);
}
