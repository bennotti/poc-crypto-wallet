using System.Security.Cryptography;
using System.Text;

namespace Crypto.Wallet.Windows.App.Extensions
{
    internal static class SHA256Extensions
    {
        internal static byte[] GenerateHashBytes(this string passAndSalt)
        {
            // Convert the string to a byte array
            byte[] textBytes = Encoding.UTF8.GetBytes(passAndSalt);
            byte[] hashBytes = new SHA256Managed().ComputeHash(textBytes);

            //returns 32bytes == 256 bits
            return hashBytes;
        }
    }
}
