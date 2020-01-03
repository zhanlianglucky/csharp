using System;

/**
 * 数据类型
 */
public class Person
{

    private string name;//字符串
    private uint age;//32 位无符号整数类型

    public int i;//32 位有符号整数类型
    public byte b = 255;//无符号字节类型范围：0-255
    public sbyte sb = 127;//有符号字节范围：-128-127
    public bool isMale;//布尔值
    public decimal de = 123;//128 位精确的十进制值，28-29 有效位数
    public double d = 12.33333;//64 位双精度浮点型
    public float f = 12.33f;//32 位单精度浮点型
    public long l = -123455;//64 位有符号整数类型
    public short s = -123;//16 位有符号整数类型
    public ulong ul = 123;//64 位无符号整数类型
    public ushort us = 123;//16 位无符号整数类型



    //您可以存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的
    public dynamic gender = "male";


    /**
     * 打印数据类型的长度，单位：字节  1字节=8位
     */
    public void printSizeOfDataType()
    {
        Console.WriteLine("Size of uint: {0}", sizeof(uint));
        Console.WriteLine("Size of int: {0}", sizeof(int));
        Console.WriteLine("Size of byte: {0}", sizeof(byte));
        Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));
        Console.WriteLine("Size of bool: {0}", sizeof(bool));
        Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
        Console.WriteLine("Size of double: {0}", sizeof(double));
        Console.WriteLine("Size of float: {0}", sizeof(float));
        Console.WriteLine("Size of long: {0}", sizeof(long));
        Console.WriteLine("Size of short: {0}", sizeof(short));
        Console.WriteLine("Size of ulong: {0}", sizeof(ulong));
        Console.WriteLine("Size of ushort: {0}", sizeof(ushort));
    }


    public string getName()
    {
        return name;
    }

    public uint getAage()
    {
        return age;
    }

    public Person()
    {
    }

    public Person(string name, uint age)
    {
        this.name = name;
        this.age = age;
    }

}
