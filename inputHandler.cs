using System;

public class InputHandler
{
    public Matrix createMatrix()
    {
        Console.Write("Enter number of rows: ");
        int rows=int.Parse(Console.ReadLine());
        
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        Matrix matrix= new Matrix(rows,cols);

        for(int i=0; i<rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($"Value [{i},{j}]: ");
                int value= int.Parse(Console.ReadLine());
                matrix.setValue(i,j,value);
            }
        }
        return matrix;
    }
    public Vector createVector()
    {
        Console.Write("Enter vector length: ");
        int len = int.Parse(Console.ReadLine());

        Vector v = new Vector(len);
        for (int i = 0; i < len; i++)
        {
        Console.Write($"Value [{i}]: ");
        int value = int.Parse(Console.ReadLine());
        v.setValue(i, value);
        }
    return v;
    }
    
}