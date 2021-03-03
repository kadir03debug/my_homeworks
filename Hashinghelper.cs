using System;
using System.Collections.Generic;
using System.Text;

namespace core.Utilities.Security.Hashing
{
   public class Hashinghelper
    {
        public void Createpasswordhash(string password,out byte[]passwordhash ,out byte[]salt)
        {
            using (var hmake=new System.Security.Cryptography.HMACSHA512() )
            {
                salt = hmake.Key;passwordhash = hmake.ComputeHash(Encoding.UTF8.GetBytes(password)); 
            }
        }
public static bool Verifypasswordhash(string pasword, byte[] passwordsalt, byte[] passwordhash) {
            using (var hmake=new System.Security.Cryptography.HMACSHA512(passwordsalt) )
            {
                var computedhash = hmake.ComputeHash(Encoding.UTF8.GetBytes(passwod));
                for (int i = 0; i < computedhash.Length; i++) { if (computedhash[i] !== passwordhash[i]) { return false; } else { return true; }  }
            }
            
                
            }

        }

    }
}
