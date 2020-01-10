using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 代理
/// </summary>


    public delegate int Calculate(int a,int b);
    public class AddSub
    {

        public int add(int a,int b)
        {
            return a + b;
        }

        public int sub(int a,int b)
        {
            return a - b;
        }
    }

    public class MulDiv
    {
        public int mul(int a,int b)
        {
            return a * b;
        }

        public int div(int a,int b)
        {
            return a / b;
        }

    }



