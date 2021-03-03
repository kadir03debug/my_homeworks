using System;
using System.Collections.Generic;
using System.Text;
using core.Entities.Concrete;
namespace core.Utilities.Security.JWT
{
    interface Itokenhelper
    {
        Accestoken createtoken(Useruser, List<Useroperationclaim>claims );
    }
}
