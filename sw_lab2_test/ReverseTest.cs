using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class ReverseTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('4');    
        test.Append('3');    
        test.Append('2');    
        test.Append('1');    

        
        var correctList = new List<char>
        {
            '1', '2', '3', '4'
        };
        test.Reverse();
        Assert.Equal(correctList, test);
        Assert.Equal(4, test.Length());
    }
    
    [Fact]
    public void Test2()
    {
        var test = new MyLinkedList<char>();

        var correctList = new List<char>
        {
            
        };
        test.Reverse();

        Assert.Equal(correctList, test);
        Assert.Equal(0, test.Length());
    }
    
    [Fact]
    public void Test3()
    {
        var test = new MyLinkedList<char>();
        test.Append('3');
        test.Append('2');
        test.Append('3');

        var correctList = new List<char>
        {
            '3', '2', '3',
        };
        test.Reverse();
        Assert.Equal(correctList, test);
        Assert.Equal(3, test.Length());
    }
}