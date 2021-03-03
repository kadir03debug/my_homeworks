using System;
using System.Collections.Generic;
using System.Text;

namespace core.Utilities.Security.JWT
{
    class Tokenoptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }




    }
}
