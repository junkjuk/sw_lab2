using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class GetTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        test.Append('4');

        Assert.Equal('1', test.Get(0));
    }
    
    [Fact]
    public void Test2()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        test.Append('4');

        Assert.Equal('2', test.Get(1));

    }
    
    [Fact]
    public void Test3()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        test.Append('4');

        Assert.Equal('3', test.Get(2));

    }
    
    [Fact]
    public void Test4()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        test.Append('4');
        Assert.Equal('4', test.Get(3));
    }

    [Fact]
    public void Test5()
    {

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var test = new MyLinkedList<char>();
            test.Get(0);
        });
    }
    
    [Fact]
    public void Test6()
    {

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var test = new MyLinkedList<char>();
            test.Append('1');
            test.Append('2');
            test.Append('3');
            test.Append('4');
            test.Get(-1);
        });
    }
    
    [Fact]
    public void Test7()
    {

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var test = new MyLinkedList<char>();
            test.Append('1');
            test.Append('2');
            test.Append('3');
            test.Append('4');
            test.Get(10);
        });
    }
}