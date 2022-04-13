using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Runtime.InteropServices;
using LinkedList;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
//using RingLinkedList;

namespace RingLinkedListTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddAfterTest()
    {
        var list = new RingLinkedList<int>();
        var item = new Item<int>(5);
        list.AddLast(1);
        list.Add(item);
        list.AddAfter(item, 6);
        
        Assert.AreEqual(6, list.Head.Next.Next.Data);
    }
    
    [Test]
    public void AddBeforeTest()
    {
        var list = new RingLinkedList<int>();
        var item = new Item<int>(5);
        list.AddLast(1);
        list.Add(item);
        list.AddBefore(item, 6);
        
        Assert.AreEqual(6, list.Head.Next.Data);
    }

    [Test]
    public void AddFirstTest()
    {
        var list = new RingLinkedList<int>();
        list.AddLast(5);
        list.AddFirst(777);
        
        Assert.AreEqual(777, list.Head.Data);
    }

    [Test]
    public void AddLastTest()
    {
        var list = new RingLinkedList<int>();
        list.AddFirst(5);
        list.AddLast(777);
        
        Assert.AreEqual(777, list.Head.Next.Data);
    }

    [Test]
    public void RemoveTest()
    {
        var list = new RingLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        
        list.Remove(2);

        Assert.AreEqual(3, list.Head.Next.Data);
    }

    [Test]
    public void RemoveFirstTest()
    {
        var list = new RingLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        
        list.RemoveFirst();
        
        Assert.AreEqual(2, list.Head.Data);
    }

    [Test]
    public void RemoveLastTest()
    {
        var list = new RingLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        
        list.RemoveLast();
        
        Assert.AreEqual(2, list.Tail.Data);
    }

    [Test]
    public void CleatTest()
    {
        var list = new RingLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        list.Clear();
        
        Assert.AreEqual(null, list.Head);
    }

    [Test]
    public void ContainsTest()
    {
        var list = new RingLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        Assert.AreEqual(true, list.Contains(2));
        Assert.AreEqual(false, list.Contains(4));
    }

    [Test]
    public void EqualsTest()
    {
        var list = new RingLinkedList<int>();
        var list1 = new RingLinkedList<int>();
        list.AddLast(5);
        list1.AddLast(5);

        var result = list.Equals(list1);

        Assert.AreEqual(true, result);
    }

    [Test]
    public void FindTest()
    {
        var list = new RingLinkedList<int>();
        var item1 = new Item<int>(5);
        var item2 = new Item<int>(5);
        list.AddLast(1);
        list.AddLast(2);
        list.Add(item1);
        list.AddLast(4);
        list.Add(item2);

        Assert.AreEqual(item1, list.Find(5));
    }

    [Test]
    public void FindLastTest()
    {
        var list = new RingLinkedList<int>();
        var item1 = new Item<int>(5);
        var item2 = new Item<int>(5);
        list.AddLast(1);
        list.AddLast(2);
        list.Add(item1);
        list.AddLast(4);
        list.Add(item2);

        Assert.AreEqual(item2, list.FindLast(5));
    }

}