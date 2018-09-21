using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    For building the encrypted string:
//    Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
//Do this n times!

//Examples:

//"This is a test!", 1 -> "hsi  etTi sats!"
//"This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"

namespace Kata_EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "0123456789012345678901234";
            int n = 4;
            Kata.Encrypt(null, 1);
            Kata.Decrypt(null, 1);
        }
    }
}
