using System;

public class Matrix
{
    private int rows;
    private int cols;
    private Row [] rowList;

    public Matrix(int r, int c)
    {
        rows=r;
        cols=c;
        rowList = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            rowList[i] = new Row(cols);
        }
    }
    public int Rows()
    {
        return rows;
    }
    
    public int Cols()
    {
        return cols;
    }

    public int getValue(int i, int j)
    {
        return rowList[i].getValue(j);
    }

    public void setValue(int i, int j, int value)
    {
        rowList[i].setValue(j, value);
    }

    public void Display()
    {
        for (int i = 0; i<rows; i++)
        {
            for(int j=0; j<cols; j++)
            {
                Console.Write(getValue(i,j)+ " ");
            }
            Console.WriteLine();
        }
    }
}

