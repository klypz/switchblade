using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Cryptography
{
    public static class CryptoHelper
    {
        public static string ToMD5(this string self)
        {
            return new HashString(self).GetHashString(HashStringType.MD5);
        }
        public static string ToSHA1(this string self)
        {
            return new HashString(self).GetHashString(HashStringType.SHA1);
        }
        public static string ToSHA256(this string self)
        {
            return new HashString(self).GetHashString(HashStringType.SHA256);
        }
        public static string ToSHA384(this string self)
        {
            return new HashString(self).GetHashString(HashStringType.SHA384);
        }
        public static string ToSHA512(this string self)
        {
            return new HashString(self).GetHashString(HashStringType.SHA512);
        }
        public static string ToSymmetricEncrypt(this string self, string secret)
        {
            return new SymmetricEncrypt(secret).Encrypt(self);
        }
        public static string ToSymmetricDecrypt(this string self, string secret)
        {
            return new SymmetricEncrypt(secret).Decrypt(self);
        }
    }
}
