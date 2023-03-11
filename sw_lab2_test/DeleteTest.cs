using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class DeleteTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');

        Assert.Equal('2', test.Delete(1));

        var correctList = new List<char>
        {
            '1', '3'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(2, test.Length());
    }

    [Fact]
    public void Test2()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        
        Assert.Equal('1', test.Delete(0));
        
        var correctList = new List<char>
        {
            '2', '3'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(2, test.Length());
    }
    
    [Fact]
    public void Test3()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        
        Assert.Equal('3', test.Delete(2));

        
        var correctList = new List<char>
        {
            '1', '2'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(2, test.Length());
    }

    [Fact]
    public void Test6()
    {

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var test = new MyLinkedList<char>();
            test.Delete(-1);
        });
    }
    
    [Fact]
    public void Test7()
    {

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var test = new MyLinkedList<char>();
            test.Delete(12);
        });
    }
    
    [Fact]
    public void Test8()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');

        
        Assert.Equal('1', test.Delete(0));
        var correctList = new List<char>
            { };
        Assert.Equal(correctList, test);
        Assert.Equal(0, test.Length());
    }
    
    [Fact]
    public void Test9()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('3');

        test.DeleteAll('2');
        
        var correctList = new List<char>
        {
            '1', '3'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(2, test.Length());
    }
    
    [Fact]
    public void Test10()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('3');

        test.DeleteAll('9');
        
        var correctList = new List<char>
        {
            '1','2', '2', '3'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(4, test.Length());
    }
    
    [Fact]
    public void Test11()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');

        test.DeleteAll('1');
        
        var correctList = new List<char>
        {
        };
        Assert.Equal(correctList, test);
        Assert.Equal(0, test.Length());
    }
    
    [Fact]
    public void Test12()
    {
        var test = new MyLinkedList<char>();

        test.DeleteAll('1');
        
        var correctList = new List<char>
        {
        };
        Assert.Equal(correctList, test);
        Assert.Equal(0, test.Length());
    }
}