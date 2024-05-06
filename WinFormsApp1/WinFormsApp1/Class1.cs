using System;
using System.Collections.Generic;
using System.Linq;

public static class SharedData
{
    public static string dis = "";
    public static string ssn = "";
    public static string cdata = "";
    public static int c = 1;
}

public static class DataStorage
{
    public static Stack<string> StringStack { get; } = new Stack<string>();
    public static Queue<string> StringQueue { get; } = new Queue<string>();
    public static LinkedList<string> StringLinkedList { get; } = new LinkedList<string>();
    public static PriorityQueue<string> StringPriorityQueue { get; } = new PriorityQueue<string>();
}

public class PriorityQueue<T>
{
    public static T item;
    private readonly List<(T, int)> _items = new List<(T, int)>();

    public void Enqueue(T item, int priority)
    {
        _items.Add((item, priority));
        _items.Sort((a, b) => b.Item2.CompareTo(a.Item2)); // Reversed the sorting order
    }

    public T Dequeue()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        item = _items[0].Item1;
        _items.RemoveAt(0);
        return item;
    }

    public bool Contains(T item)
    {
        return _items.Any(x => x.Item1.Equals(item));
    }

    public T Peek()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        return _items[0].Item1;
    }

    public int Count => _items.Count;

    public bool IsEmpty => _items.Count == 0;

    // Method to access the string part of the first tuple in _items
    public T PeekString()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        return _items[0].Item1;
    }
}
