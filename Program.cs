using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            testModifier();

            //testDataType();
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
                "info4 = {4};\n"
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


