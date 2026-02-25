using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors;
    
    public VectorRepository()
    {
        vectors=new List<Vector>();
    }

    public void addVector(Vector v)
    {
        vectors.Add(v);
    }

    public Vector getVector(int index)
    {
        return vectors[index];
    }
}