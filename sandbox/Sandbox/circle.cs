using System;

class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }
    public Circle(double radius)
    {
        // _radius = radius;
        setRadius(radius);
    }
    public void setRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

