using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            testFunction();
            //testModifier();
            //testDataType();
        }


        //方法
        private static void testFunction()
        {
            Function function = new Function();
            function.printTestInfo();

            int a = 2; int b = 5;
            Console.WriteLine("{0} + {1} = {2}", a, b, function.add(a, b));

            function.changeData(ref a, b);
            Console.WriteLine("a = {0}", a);

            int c = 100, d = 88;
            function.outPrint(out c, out d);
            Console.WriteLine("new a = {0};\nnew b = {1}", c, d);
        }







        //访问修饰符
        private static void testModifier()
        {
            Modifier modifier = new Modifier();
            Console.WriteLine(
                "info1 = {0};\n" +
                "info2 = {1};\n" +
                "info3 = {2};\n" +
                "info4 = {3};\n"+
                "info5 = {4};\n"
                ,
                modifier.pInfo,
                modifier.getPrivateInfo(),
                modifier.iInfo,
                modifier.getProtectInfo(),
                modifier.getProtectIntenalInfo()
                ) ;
        }


        //数据类型
        private static void testDataType()
        {
            Person student = new Person("Tom", 13);
            Console.WriteLine("student's name = {0},age = {1}", student.getName(), student.getAage());
            student.printSizeOfDataType();
        }
    }



}


