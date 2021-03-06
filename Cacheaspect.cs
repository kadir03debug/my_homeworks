using System;
using System.Collections.Generic;
using System.Text;
using core.Utilities.IOc;
using core.Utilities.Interceptor;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using core.Crosscuttingconcern.Caching;
using System.Linq;

namespace core.Aspect.Autofac.Caching
{
    class Cacheaspect:MethodInterception
    {
        int _duration;
        private ICachemanager _cachemanager;
        public Cacheaspect(int duration=10 )
        {
            _duration = duration;
            _cachemanager = Servicetool.ServiceProvider.GetService<ICachemanager>();
        }
        public override void intercept(IInvocation ınvocation)
        {
            var methodname = string.Format($"{ınvocation.Method.ReflectedType.FullName}.{ınvocation.Method.Name }");
            var arguments = ınvocation.Arguments.ToList() ;
           var  key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            if (_cachemanager.Issadd(key)) { ınvocation.ReturnValue = _cachemanager.get(key);return; }
            ınvocation.Proceed();_cachemanager.Add(key, ınvocation.ReturnValue, duration);
        }
        






    }
}
