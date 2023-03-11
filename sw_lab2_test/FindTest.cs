using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class FindTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');

        Assert.Equal(0, test.FindFirst('1'));
    }
    
    [Fact]
    public void Test2()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');

        Assert.Equal(1, test.FindFirst('2'));
    }
    
    [Fact]
    public void Test3()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');

        Assert.Equal(3, test.FindFirst('4'));
    }
    
    [Fact]
    public void Test4()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');
        Assert.Equal(-1, test.FindFirst('5'));
    }

    [Fact]
    public void Test5()
    {
        var test = new MyLinkedList<char>();
        Assert.Equal(-1, test.FindFirst('5'));
    }
    
    
    [Fact]
    public void Test6()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');

        Assert.Equal(0, test.FindLast('1'));
    }
    
    [Fact]
    public void Test7()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');

        Assert.Equal(2, test.FindLast('2'));
    }
    
    [Fact]
    public void Test8()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');

        Assert.Equal(3, test.FindLast('4'));
    }
    
    [Fact]
    public void Test9()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('2');
        test.Append('4');
        Assert.Equal(-1, test.FindLast('5'));
    }

    [Fact]
    public void Test10()
    {
        var test = new MyLinkedList<char>();
        Assert.Equal(-1, test.FindLast('5'));
    }
}