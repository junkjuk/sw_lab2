using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class AppendTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        var correctList = new List<char>
        {
            '1', '2', '3'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(3, test.Length());
    }
}