using System;
using System.Collections.Generic;
using System.Text;

//单继承
class Second : Time
{
    public void printTime()
    {
        Console.WriteLine("Second time = {0}", currentTime);
    }
}


class Time
{
    public Time()
    {
        Console.WriteLine("Time() 无参构造执行！");
    }
    public Time(string time)
    {
        this.currentTime = time;
        Console.WriteLine("Time(time) 有参数构造执行！");
    }

    public string currentTime;
    public static int index = 1;

    ~Time()//析构函数
    {
        Console.WriteLine("Time()对象销毁！");
    }
}
