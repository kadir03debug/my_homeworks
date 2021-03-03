using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;
namespace core.Utilities.Security.Encription
{
    class Signingcredentialhelper
    {
        public static SigningCredentials createsigningcredential(SecurityKey seckey{ return new SigningCredentials(seckey, SecurityAlgorithms.HmacSha512Signature); } 


    }
}
