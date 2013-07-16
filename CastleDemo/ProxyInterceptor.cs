using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace CastleDemo
{
    public class ProxyInterceptor :StandardInterceptor
    {
        protected override void PreProceed(IInvocation invocation)
        {
            Console.WriteLine("Now I'm starting " + invocation.Method.Name);
            base.PreProceed(invocation);
        }

        protected override void PostProceed(IInvocation invocation)
        {
            Console.WriteLine("Now I'm ending " + invocation.Method.Name);
            base.PostProceed(invocation);
        }
    }
}
