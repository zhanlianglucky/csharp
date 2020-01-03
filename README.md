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


