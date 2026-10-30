using System.Numerics;
using UnityEngine;

public struct VectorTwo
{

    float _x;

    float _y;

    public VectorTwo(float xx, float yy)
    {
        _x = xx; 
        _y = yy;
    }

    public float X() 
    {
        return _x;
    }

    public float Y()
    {
        return _y;
    }

    public float Magnitude()
    {
        return Mathf.Sqrt(_x*_x + _y * _y);
    }

    public float sqrMagnitude()
    {
        return _x * _x + _y * _y;
    }

    public void Normalize()
    {
        var m = Magnitude();

         _x = _x / m;

        _y = _y / m;
    }

    public static VectorTwo operator +(VectorTwo a, VectorTwo b)
    {
        return new VectorTwo(a._x + b._x, a._y + b._y);
    }
}


