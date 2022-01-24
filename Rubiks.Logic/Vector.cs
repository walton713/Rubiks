namespace Rubiks.Logic;

public struct Vector
{
    private int[] _values;

    public Vector(params int[] values)
    {
        _values = values;
    }

    public int[,] GetVector()
    {
        var res = new int[_values.Length, 1];

        for (var i = 0; i < _values.Length; i++)
        {
            res[i, 0] = _values[i];
        }

        return res;
    }

    public void Add(int a)
    {
        _values = _values.Select(v => v + a).ToArray();
    }
}
