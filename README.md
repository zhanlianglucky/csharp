# C#语言学习

## C# 结构


    程序的第一行 using System; - using 关键字用于在程序中包含 System 命名空间。 一个程序一般有多个 using 语句。
    下一行是 namespace 声明。一个 namespace 里包含了一系列的类。HelloWorldApplication 命名空间包含了类 HelloWorld。
    下一行是 class 声明。类 HelloWorld 包含了程序使用的数据和方法声明。类一般包含多个方法。方法定义了类的行为。在这里，HelloWorld 类只有一个 Main 方法。
    下一行定义了 Main 方法，是所有 C# 程序的 入口点。Main 方法说明当执行时 类将做什么动作。
    下一行 /*...*/ 将会被编译器忽略，且它会在程序中添加额外的 注释。
    Main 方法通过语句 Console.WriteLine("Hello World"); 指定了它的行为。

    WriteLine 是一个定义在 System 命名空间中的 Console 类的一个方法。该语句会在屏幕上显示消息 "Hello, World!"。
    最后一行 Console.ReadKey(); 是针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。

以下几点值得注意：

    C# 是大小写敏感的。
    所有的语句和表达式必须以分号（;）结尾。
    程序的执行从 Main 方法开始。
    与 Java 不同的是，文件名可以不同于类的名称。



## 数据类型


在 C# 中，变量分为以下几种类型：

    值类型（Value types）
    引用类型（Reference types）
    指针类型（Pointer types）
  
  
## 封装

### 访问修饰符

    public：所有对象都可以访问；
    private：对象本身在对象内部可以访问；
    protected：只有该类对象及其子类对象可以访问
    internal：同一个程序集的对象可以访问；
    protected internal：访问限于当前程序集或派生自包含类的类型。

### 方法定义 跟Java很相近

    当定义一个方法时，从根本上说是在声明它的结构的元素。在 C# 中，定义方法的语法如下：

<Access Specifier> <Return Type> <Method Name>(Parameter List)
{
   Method Body
}

下面是方法的各个元素：

    Access Specifier：访问修饰符，这个决定了变量或方法对于另一个类的可见性。
    Return type：返回类型，一个方法可以返回一个值。返回类型是方法返回的值的数据类型。如果方法不返回任何值，则返回类型为 void。
    Method name：方法名称，是一个唯一的标识符，且是大小写敏感的。它不能与类中声明的其他标识符相同。
    Parameter list：参数列表，使用圆括号括起来，该参数是用来传递和接收方法的数据。参数列表是指方法的参数类型、顺序和数量。参数是可选的，也就是说，一个方法可能不包含参数。
    Method body：方法主体，包含了完成任务所需的指令集。

    
### C# 可空类型（Nullable）

C# 提供了一个特殊的数据类型，nullable 类型（可空类型），可空类型可以表示其基础值类型正常范围内的值，再加上一个 null 值。

例如，Nullable< Int32 >，读作"可空的 Int32"，可以被赋值为 -2,147,483,648 到 2,147,483,647 之间的任意值，也可以被赋值为 null 值。类似的，Nullable< bool > 变量可以被赋值为 true 或 false 或 null。

在处理数据库和其他包含可能未赋值的元素的数据类型时，将 null 赋值给数值类型或布尔型的功能特别有用。例如，数据库中的布尔型字段可以存储值 true 或 false，或者，该字段也可以未定义。 

声明一个 nullable 类型（可空类型）的语法如下：

    < data_type> ? <variable_name> = null; 


## 数组 

  声明和操作形式跟Java很类似，细微差别为： 
  
    1.支持foreach循环遍历：
        foreach (int value in array ){} 

    2.多维数组声明形式： 
        int[,] arr = new int[3,4]; //声明一个3行4列的二维数组 

    3.参数数组 
        在使用数组作为形参时，C# 提供了 params 关键字，使调用数组为形参的方法时，既可以传递数组实参，也可以传递一组数组元素。params 的使用格式为：

            public 返回类型 方法名称( params 类型名称[] 数组名称 ) 

    4.Array 类 
        Array 类是 C# 中所有数组的基类，它是在 System 命名空间中定义。Array 类提供了各种用于数组的属性和方法。 


## 字符串 string
    
    声明和操作形式跟Java很类似。 


## 结构体（Struct） 注意：结构体存储在【栈】内存中，不适合较大内存的数据结构。 

    1.C#中结构体和类的用法基本一致，只是存储位置不同，类生成的对象数据存储在【堆】内存中。 
        
        类是引用类型，结构是值类型。
        结构不支持继承。
        结构不能声明默认的构造函数。
        int,double,bool...都属于结构数据类型。 
        
        结构可带有方法、字段、索引、属性、运算符方法和事件。
        结构可定义构造函数，但不能定义析构函数。但是，您不能为结构定义无参构造函数。无参构造函数(默认)是自动定义的，且不能被改变。
        与类不同，结构不能继承其他的结构或类。
        结构不能作为其他结构或类的基础结构。
        结构可实现一个或多个接口。
        结构成员不能指定为 abstract、virtual 或 protected。
        当您使用 New 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。
        如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。
        结构体中声明的字段无法赋予初值，类可以。  

    2.声明方式： 

        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        };  

## 枚举enum  
   
    跟Java枚举操作基本相同。 
    

## 类Class 

    基本定义和操作跟Java类似,稍有差异： 

        1.类的 析构函数 是类的一个特殊的成员函数，当类的对象超出范围时执行。

        析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
        
        析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。 

            
            ~destroy() //析构函数
            
            {
            
                Console.WriteLine("对象已删除");
            
            } 

        2.继承 跟java类似单继承,多接口实现，接口之间可以多继承，声明形式：  

            <访问修饰符符> class <基类>
            {
             ...
            } 

            class <派生类> : <基类>
            {
             ...
            } 


## 运算符重载

    通过关键字 operator 后跟运算符的符号来定义：

        public static Point operator+ (Point b, Point c)
        {
           Point point = new Point();
           point.x = b.x + c.x;
           point.y = b.y + c.y;
           return point;
        }


## 预处理器指令  

    预处理器指令指导编译器在实际编译开始之前对信息进行预处理。
    
    所有的预处理器指令都是以 # 开始。且在一行上，只有空白字符可以出现在预处理器指令之前。预处理器指令不是语句，所以它们不以分号（;）结束。
    
    C# 编译器没有一个单独的预处理器，但是，指令被处理时就像是有一个单独的预处理器一样。在 C# 中，预处理器指令用于在条件编译中起作用。与 C 和 C++ 不同的是，
    
    它们不是用来创建宏。一个预处理器指令必须是该行上的唯一指令。 

    参考：https://www.runoob.com/csharp/csharp-preprocessor-directives.html 



## 异常处理 

    try：一个 try 块标识了一个将被激活的特定的异常的代码块。后跟一个或多个 catch 块。
    catch：程序通过异常处理程序捕获异常。catch 关键字表示异常的捕获。
    finally：finally 块用于执行给定的语句，不管异常是否被抛出都会执行。例如，如果您打开一个文件，不管是否出现异常文件都要被关闭。
    throw：当问题出现时，程序抛出一个异常。使用 throw 关键字来完成。 


            try
        {
           // 引起异常的语句
        }
        catch( ExceptionName e1 )
        {
           // 错误处理代码
        }
        catch( ExceptionName e2 )
        {
           // 错误处理代码
        }
        catch( ExceptionName eN )
        {
           // 错误处理代码
        }
        finally
        {
           // 要执行的语句
        }



##  文件读写 

    System.IO 命名空间有各种不同的类，用于执行各种文件操作，如创建和删除文件、读取或写入文件，关闭文件等。 

    I/O 类	                  描述
    BinaryReader	从二进制流读取原始数据。
    BinaryWriter	以二进制格式写入原始数据。
    BufferedStream	字节流的临时存储。
    Directory	    有助于操作目录结构。
    DirectoryInfo	用于对目录执行操作。
    DriveInfo	    提供驱动器的信息。
    File	        有助于处理文件。
    FileInfo	    用于对文件执行操作。
    FileStream	    用于文件中任何位置的读写。
    MemoryStream	用于随机访问存储在内存中的数据流。
    Path	        对路径信息执行操作。
    StreamReader	用于从字节流中读取字符。
    StreamWriter	用于向一个流中写入字符。
    StringReader	用于读取字符串缓冲区。
    StringWriter	用于写入字符串缓冲区。

        

