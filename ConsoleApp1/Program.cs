﻿using System;
public class MyClass
{
    [Obsolete("Don't use NewMethod, use OldMethod instead", true)]
    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }
    public static void Main()
    {
        OldMethod();
    }
}