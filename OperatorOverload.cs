using System;

//运算符重载

public class Point
{
    public int x;
    public int y;

    public Point()
    {

    }
    public Point(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public static Point operator +(Point b, Point c)
    {
        Point point = new Point();
        point.x = b.x + c.x;
        point.y = b.y + c.y;
        return point;
    }
}

