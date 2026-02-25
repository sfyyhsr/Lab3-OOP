using System;

class Program
{
    static void Main()
    {
        InputHandler input= new InputHandler();

        Console.WriteLine("MATRIX ADDITION");

        Console.WriteLine("Input Matrix A: ");
        Matrix A = input.createMatrix();

        Console.WriteLine("Input Matrix B: ");
        Matrix B = input.createMatrix();

        MatrixRepository matrixRep= new MatrixRepository();
        VectorRepository vectorRep= new VectorRepository();
        
        matrixRep.addMatrix(A);
        matrixRep.addMatrix(B);

        Calculator calc= new Calculator(matrixRep,vectorRep);

        Matrix C=calc.addMatrix(0,1);

        Console.WriteLine("Result Matrix: ");
        C.Display();

        Console.WriteLine("VECTOR ADDITION");

        Console.WriteLine("Input Vector A: ");
        Vector vecA = input.createVector();

        Console.WriteLine("Input Vector B: ");
        Vector vecB = input.createVector();

        vectorRep.addVector(vecA);
        vectorRep.addVector(vecB);

        Vector vecC = calc.addVector(0, 1);

        Console.WriteLine("Result Vector: ");
        vecC.Display();

    }
}
