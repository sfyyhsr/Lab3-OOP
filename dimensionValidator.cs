using System;

public class DimensionValidator
{
    public bool validateMatrix(Matrix a, Matrix b)
    {
        return a.Rows() == b.Rows() && a.Cols() == b.Cols();
    }

    public bool validateVector(Vector a, Vector b)
    {
        return a.Length()==b.Length();
    }
}