using Microsoft.VisualBasic;
using NUnit.Framework;
using ShellSort;

namespace ShellSortTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReverseArrayTest()
    {
        var sort = new ShellSort<int>();
        var array = new int[] {5, 4, 7, 8, 13, 25};
        var result = new int[] {25, 13, 8, 7, 4, 5};

        array = sort.ReverseArray(array);
        
        Assert.AreEqual(result, array);
    }

    [Test]
    public void SwapTest()
    {
        var sort = new ShellSort<int>();
        var array = new int[] {5, 4, 7, 8, 13, 25};
        var result = new int[] {8, 4, 7, 5, 25, 13};

        array = sort.Swap(array, 0, 3);
        array = sort.Swap(array, 4, 5);
        
        Assert.AreEqual(result, array);
    }
    
    [Test]
    public void ShellSortCharTest()
    {
        var sort = new ShellSort<char>();
        var array = new char[] {'f', 'g', 'e', 'd', 'v', 'n'};
        var result = new char[] {'d', 'e', 'f', 'g', 'n', 'v'};

        array = sort.Sort(array);
        
        Assert.AreEqual(result, array);
    }
    
    [Test]
    public void ReverseShellSortCharTest()
    {
        var sort = new ShellSort<char>();
        var array = new char[] {'f', 'g', 'e', 'd', 'v', 'n'};
        var result = new char[] {'v', 'n', 'g', 'f', 'e', 'd'};

        array = sort.ReverseSort(array);
        
        Assert.AreEqual(result, array);
    }

    [Test]
    public void ShellSortIntTest()
    {
        var sort = new ShellSort<int>();
        var array = new int[] {4, 3, 7, 1, 8, 9, 2, 5, 6, 0};
        var result = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        array = sort.Sort(array);
        
        Assert.AreEqual(result, array);
    }
    
    [Test]
    public void ReverseShellSortIntTest()
    {
        var sort = new ShellSort<int>();
        var array = new int[] {4, 3, 7, 1, 8, 9, 2, 5, 6, 0};
        var result = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};

        array = sort.ReverseSort(array);
        
        Assert.AreEqual(result, array);
    }

    [Test]
    public void ShellSortDoubleTest()
    {
        var sort = new ShellSort<double>();
        var array = new double[] {5.6, 4.0, 4.1, 7.34, 8.36, 3.9, 5.456, 3.2, 5.455};
        var result = new double[] {3.2, 3.9, 4.0, 4.1, 5.455, 5.456, 5.6, 7.34, 8.36};

        array = sort.Sort(array);
        
        Assert.AreEqual(result, array);
    }
    
    [Test]
    public void ReverseShellSortDoubleTest()
    {
        var sort = new ShellSort<double>();
        var array = new double[] {5.6, 4.0, 4.1, 7.34, 8.36, 3.9, 5.456, 3.2, 5.455};
        var result = new double[] {8.36, 7.34, 5.6, 5.456, 5.455, 4.1, 4.0, 3.9, 3.2};

        array = sort.ReverseSort(array);
        
        Assert.AreEqual(result, array);
    }

    [Test]
    public void ShellSortStringTest()
    {
        var sort = new ShellSort<string>();
        var array = new string[] {"hello", "bye", "half", "look", "helo", "hell"};
        var result = new string[] {"bye", "half", "hell", "hello", "helo", "look"};

        array = sort.Sort(array);

        Assert.AreEqual(result, array);
    }
    
    [Test]
    public void ReverseShellSortStringTest()
    {
        var sort = new ShellSort<string>();
        var array = new string[] {"hello", "bye", "half", "look", "helo", "hell"};
        var result = new string[] {"look", "helo", "hello", "hell", "half", "bye"};

        array = sort.ReverseSort(array);

        Assert.AreEqual(result, array);
    }
}