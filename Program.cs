using System;

//System 为命名空间，类似Java包名的概念。 using 功能类似Java import导入包功能。

namespace csharp //csharp 为命名空间，类似Java包名的概念。名字相同，则为同一个命名空间。
{
    class Program
    {
        static void Main(string[] args)
        {



            testOperatorOverload();//运算符重载
            #region
            //testInterface();//多态
            //testClass();//类
            //testStruct();//结构体
            //testNullable();// nullable 可空类型
            //testFunction();//方法
            //testModifier();//访问修饰符
            //testDataType();//数据类型
            #endregion
        }

        private static void testOperatorOverload()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = p1 + p2;
            Console.WriteLine("point.x = {0}\npoint.y = {1}", p3.x, p3.y);
        }


        //多态 接口多继承
        private static void testInterface()
        {
            Rectangle rect = new Rectangle(new RecProperty());
        }


        //类
        private static void testClass()
        {
            Time time = new Time("11:11");
            Time.index = 12;
            Console.WriteLine("currentTime = {0}\nindex = {1}", time.currentTime, Time.index);
            Time.index = 0;

        }




        //结构体
        private static void testStruct()
        {
            Line p = new Line(12, 66);
            p.printXY();
        }

        struct Line
        {
            private float x;
            private float y;
            public Line(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public void printXY()
            {
                Console.WriteLine("x = {0}\ny = {1}", x, y);
            }

        }

        // nullable 可空类型
        private static void testNullable()
        {
            int? a = null;
            int? b = new int?();
            double? d1 = new double?();
            double? d2 = null;
            bool? bo = new bool?();

            Console.WriteLine("a = {0}\nb = {1}\nd1 = {2}\nd2 = {3}\nbo = {4}", a, b, d1, d2, bo);

            //合并运算符？？ 如果第一个操作数的值为 null，则运算符返回第二个操作数的值，否则返回第一个操作数的值
            int? c = new int?();
            c = null;
            int d = c ?? 12;
            Console.WriteLine("d = {0}", d);

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
                "info4 = {3};\n" +
                "info5 = {4};\n"
                ,
                modifier.pInfo,
                modifier.getPrivateInfo(),
                modifier.iInfo,
                modifier.getProtectInfo(),
                modifier.getProtectIntenalInfo()
                );
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


