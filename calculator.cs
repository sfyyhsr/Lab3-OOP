using System;

public class Calculator
{
    private MatrixRepository matrixRep;
    private VectorRepository vectorRep;
    private DimensionValidator validator;

    public Calculator(MatrixRepository MR, VectorRepository VR)
    {
        matrixRep = MR;
        vectorRep= VR;
        validator= new DimensionValidator();
    }

    public Matrix addMatrix(int A, int B)
    {
        Matrix a= matrixRep.getMatrix(A);
        Matrix b= matrixRep.getMatrix(B);

        if (!validator.validateMatrix(a, b))
        {
            throw new System.Exception("Matrix dimensions do not match.");
        }

        Matrix result = new Matrix(a.Rows(), a.Cols());
        for (int i=0; i < a.Rows(); i++)
        {
            for(int j=0;j<a.Cols();j++)
            {
                result.setValue(i,j, a.getValue(i,j)+ b.getValue(i,j));
            }
        }
        return result;
    }

    public Vector addVector(int A, int B)
    {
        Vector a = vectorRep.getVector(A);
        Vector b = vectorRep.getVector(B);

        if (!validator.validateVector(a, b))
        {
           throw new System.Exception("Vector dimensions do not match.");
        }

        Vector result = new Vector(a.Length());
        for (int i = 0; i < a.Length(); i++)
        {
            result.setValue(i, a.getValue(i) + b.getValue(i));
        }
        return result;

    }
}