using System;

public class Vector
{
    private int length;
    private int[] values;

    public Vector (int len)
    {
        length=len;
        values=new int [length];
    }

    public int Length()
    {
        return length;
    }

    public int getValue(int i)
    {
        return values[i];
    }

    public void setValue(int i, int value)
    {
        values[i]=value;
    }

    public void Display()
    {
        for(int i = 0; i < length; i++)
        {
            Console.Write(values[i]+" ");
        }
        Console.WriteLine();
    }
}