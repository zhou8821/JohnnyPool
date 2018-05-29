using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class Class1
    {
        public string Fun1()
        {
            return new Class2().Fun2();
        }
    }
}