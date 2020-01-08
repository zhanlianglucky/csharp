using System;
class Rectangle
{
    public Rectangle(Property p)
    {
        p.showProperty();
    }
}

class RecProperty : Property
{
    public float getDerection()
    {
        return 2.0f;
    }

    public float getSize()
    {
        return 1.0f;
    }

    public void showProperty()
    {
        Console.WriteLine("derection = {0}\nsize = {1}", getDerection(), getSize());
    }
}


interface Derection
{
    float getDerection();
}

interface Size
{
    float getSize();
}

interface Property : Derection, Size
{
    void showProperty();
}