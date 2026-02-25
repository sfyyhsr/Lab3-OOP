public class Row
{
    private int[] values;
    private int size;

    public Row(int size)
    {
        this.size = size;
        values = new int[size];
    }

    public int getValue(int index)
    {
        return values[index];
    }

    public void setValue(int index, int value)
    {
        values[index] = value;
    }

    public int Size()
    {
        return size;
    }
}