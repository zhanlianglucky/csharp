using System;
using System.Collections.Generic;
using System.Text;


//
class Function
{

    public void printTestInfo()
    {
        Console.WriteLine("printTestInfo()");
    }

    public int add(int a,int b)
    {
        return a + b;
    }

    //使用 ref 关键字声明引用参数 : 引用参数是一个对变量的内存位置的引用
    public void changeData(ref int data,int value)
    {
        data = value;
    }

    //按输出传递参数
    public void outPrint(out int a,out int b)
    {
        a = 10;
        b = 12;
        Console.WriteLine("old a = {0};\nold b = {1}",a,b);
    }


}

