using System;
using System.Text;

namespace Kata_EncryptDecrypt
{
    public static class Kata
    {
        public static string Decrypt(string encryptedText, int n = 0)
        {
            if (encryptedText == null)
            {
                string.IsNullOrEmpty("sd");
                throw new Exception("STRING CANNOT BE NULL");
            }
            else
            {
            if (n >= 1)
            {
                Console.WriteLine("String to decrypt: {0}", encryptedText);
                var sb = new StringBuilder(encryptedText);
                var halfLength = sb.Length / 2;
                var halfLengthIndex = halfLength - 1;
                for (var j = 0; j < n; j++)
                {
                for (var i = halfLengthIndex; i >= 0; i--)
                {
                    var moveChar = sb[i];
                    var goesToIndex = (i * 2) + 2;
                    sb.Insert(goesToIndex, moveChar.ToString(), 1);
                    sb.Remove(i,1);

                }
                }
                Console.WriteLine("Decrypted string is {0}",sb);
                return sb.ToString();
            }
            else 
            {
                return encryptedText;
            }
            }
        }

        public static string Encrypt(string text, int n = 0)
        {
            if (text == null)
            {
                throw new Exception("STRING CANNOT BE NULL");
            }
            else
            {
            if (n >= 1)
            {
                Console.WriteLine("String to encrypt: {0}", text);
                var sb = new StringBuilder(text);
                for (var j = 0; j < n; j++)
                {
                    var startIndex = 0;
                    for (var i = 0; i < text.Length; i++)
                    {
                        if (i % 2 != 1) continue;
                        var insertChar = sb[i];
                        sb.Remove(i, 1);
                        sb.Insert(startIndex, insertChar.ToString(), 1);
                        startIndex++;
                    }
                }

                Console.WriteLine("Encrypted string is {0}", sb);
                return sb.ToString();
            }
            else
            {
                return text;
            }
            }

        }
    }
}