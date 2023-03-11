using System;
using System.Collections.Generic;
using sw_lab2;
using Xunit;

namespace sw_lab2_test;

public class ExtendTest
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
            '1', '2', '3', '4', '5'
        };
        var addArray = new[] {'5'};
        test.Extend(addArray);
        Assert.Equal(correctList, test);
        Assert.Equal(5, test.Length());
    }
    
    [Fact]
    public void Test2()
    {
        var test = new MyLinkedList<char>();

        var correctList = new List<char>
        {
            '1'
        };
        var addArray = new[] {'1'};
        test.Extend(addArray);

        Assert.Equal(correctList, test);
        Assert.Equal(1, test.Length());
    }
    
    [Fact]
    public void Test3()
    {
        var test = new MyLinkedList<char>();
        test.Append('1');    
        test.Append('2');

        var correctList = new List<char>
        {
            '1', '2', '3', '4', '5'
        };
        
        var addArray = new[] {'3', '4', '5'};
        test.Extend(addArray);
        Assert.Equal(correctList, test);
        Assert.Equal(5, test.Length());
    }
}