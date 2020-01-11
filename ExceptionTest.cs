using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class ExceptionTest
    {
        /// <summary>
        /// 异常处理
        /// </summary>
        public static void test()
        {
            try
            {
                int a = 0;
                int b = 1 / a;
            }
            catch (Exception e)
            {
                //throw e;//抛出异常
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("==============finally================");
            }
        }


        public static int dd(int a, int b)
        {
            return a / b;
        }


    }
}
