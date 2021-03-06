using System;
using System.Collections.Generic;
using System.Text;
using core.Utilities.Interceptor;
using Castle.DynamicProxy;
using core.Utilities.IOc;
using System.Diagnostics;
namespace core.Aspect.Autofac.Performance
{
    class Performanceaspect:MethodInterception
    {
        private int interval;
        private Stopwatch _stopwatch;
        public Performanceaspect(int intval )
        {
            interval = intval;
            _stopwatch = Servicetool.ServiceProvider.GetService<Stopwatch>(); 
                
        }
        protected override void Onbifore(IInvocation ınvocation)
        {
            _stopwatch.Start();
        }
        protected override void OnAfter(IInvocation invocation)
        {
            if(_stopwatch.Elapsed.TotalSeconds>interval)
            {
                Debug.WriteLine($"performanc:{invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}) 
            }
            _stopwatch.Reset();

        }






    }
}
