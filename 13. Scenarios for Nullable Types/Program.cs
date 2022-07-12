﻿class Program
{
    public static void Main(string[] args)
    {
        
    }
}

// Maps to a Customer table in a database

public class Customer
{
    /*...*/
    public decimal? AccountBalance;	// Works well with SQL's nullable column
}

public class Color
{
    
}

// Color is an ambient property:
public class Row
{
    /*...*/
    Grid parent;
    Color? color;

    public Color Color
    {
        get { return color ?? parent.Color; }
        set { color = Color == parent.Color ? (Color?)null : value; }
    }
}

class Grid
{
    /*...*/
    public Color Color { get; set; }
}