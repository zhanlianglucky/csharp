using System;
using System.Collections.Generic;
using System.Text;

//访问修饰符
class Modifier
{
    private string info = "private info";
    internal string iInfo = "internal info";
    protected internal string piInfo = "protected internal info";
    public string pInfo = "public info";
    protected string proInfo = "protect info";
    
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

