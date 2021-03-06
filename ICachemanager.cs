using System;
using System.Collections.Generic;
using System.Text;

namespace core.Crosscuttingconcern.Caching
{
    interface ICachemanager
    {
        T get<t>(stringkey );
        object get(string key);
        void Add(string key, object value, int duration);
        bool Issadd(string key);
        void remove(string key);
        void removebypattern(string pattern);
    }
}
