using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        public string Fun1()
        {
            Class2 c2 = new Class2();
            string x=c2.Fun2();
            return x;
        }
    }
}
