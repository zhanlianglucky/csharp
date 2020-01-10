

#define PI
#define TI


using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 预处理命令
/// </summary>



class PretreatmentTest
{

    public void test()
    {
#if(PI)
        Console.WriteLine("PI is define!");
#else
        Console.WriteLine("PI isn't define!");
#endif

#if (PI && TI)
        Console.WriteLine("PI and TI are define!");
#elif (PI || TI)
        Console.WriteLine("PI or TI is undefine!");
#else
        Console.WriteLine("PI add TI are undefine!");

#endif
        Console.WriteLine("finish!");
    }

}

