using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using core.Utilities.IOc;
using core.Utilities.Interceptor;
using Castle.DynamicProxy;

namespace core.Aspect.Autofac.transaction
{
    class Transactionaspect:MethodInterception
    {
        public override void intercept(IInvocation ınvocation)
        {
            using (TransactionScope scope = new TransactionScope()) {
                try
                {
                    ınvocation.Proceed();
scope.Complete()
            }
catch(System.Exception e)
                {
                    scope.Dispose();throw;
        }



    }
}
        