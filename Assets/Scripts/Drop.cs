using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : IComparable
{
    public string name { get; }
    int price { get; }

    public Drop(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public int CompareTo(object other)
    {
            return other is Drop drop ? name.CompareTo(drop.name) : 0;
    }

    public int Compare(object x, object y)
    {
        return x is Drop drop1 && y is Drop drop2 ? drop1.name.CompareTo(drop2.name) : 0;
    }
}
