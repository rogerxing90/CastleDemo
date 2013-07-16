using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using CastleDemo;

namespace CastleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("现在是Castle的代理在运行");
            ProxyGenerator generator = new ProxyGenerator();
            object proxy = generator.CreateClassProxy(typeof(RealA), new ProxyInterceptor());
            (proxy as RealA).DoSomething();
            System.Console.ReadLine();
        }
    }
}
