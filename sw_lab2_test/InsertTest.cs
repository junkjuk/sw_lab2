using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class InsertTest
{
    [Fact]
    public void Test1()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');
        test.Append('2');
        test.Append('3');
        
        test.Insert('0', 0 );
        
        var correctList = new List<char>
        {
            '0','1', '2', '3'
        };
        Assert.Equal(correctList, test);
        Assert.Equal(4, test.Length());
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
        Assert.Equal(correctList, test);
        Assert.Equal(4, test.Length());
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
        Assert.Equal(correctList, test);
        Assert.Equal(4, test.Length());
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
        Assert.Equal(correctList, test);
        Assert.Equal(4, test.Length());
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
        Assert.Equal(correctList, test);
        Assert.Equal(1, test.Length());
    }
    
    [Fact]
    public void Test6()
    {

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var test = new MyLinkedList<char>();
            test.Insert('0', 12);
        });
    }
}