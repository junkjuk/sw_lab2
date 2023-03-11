using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class CloneTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        test.Append('4');

        
        var correctList = new List<char>
        {
            '1', '2', '3', '4'
        };
        var cop = test.Clone();
        
        Assert.Equal(correctList, cop);
        Assert.Equal(4, cop.Length());
    }
    
    [Fact]
    public void Test2()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        
        test.Insert('0', 1 );
        
        var correctList = new List<char>
        {
            '1','0', '2', '3'
        };
        
        var cop = test.Clone();
        Assert.Equal(correctList, cop);
        Assert.Equal(4, cop.Length());
    }
    
    [Fact]
    public void Test3()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        
        test.Insert('0', 2 );
        
        var correctList = new List<char>
        {
            '1', '2', '0','3',
        };
        
        var cop = test.Clone();
        Assert.Equal(correctList, cop);
        Assert.Equal(4, cop.Length());
    }
    
    [Fact]
    public void Test4()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        
        test.Insert('0', 3 );
        
        var correctList = new List<char>
        {
            '1', '2', '3','0',
        };
        
        var cop = test.Clone();
        Assert.Equal(correctList, cop);
        Assert.Equal(4, cop.Length());
    }
    
    [Fact]
    public void Test5()
    {
        var test = new MyLinkedList<char>();
        test.Insert('0', 0 );
        
        var correctList = new List<char>
        {
            '0'
        };
        
        var cop = test.Clone();
        Assert.Equal(correctList, cop);
        Assert.Equal(1, cop.Length());
    }
}