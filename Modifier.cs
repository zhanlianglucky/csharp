using System;
using System.Collections.Generic;
using System.Text;

//访问修饰符
class Modifier
{
    private string info = "private info";//仅限本类访问
    internal string iInfo = "internal info";//程序内可以访问
    protected internal string piInfo = "protected internal info";//程序内和子类可以访问
    public string pInfo = "public info";//解决方案内可以访问
    protected string proInfo = "protect info";//子类可以访问
    
    public string getPrivateInfo()
    {
        return info;
    }

    public string getProtectInfo()
    {
        return proInfo;
    }

    public string getProtectIntenalInfo()
    {
        return proInfo;
    }




}

