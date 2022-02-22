using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Crypto.Wallet.Windows.App.Extensions
{
    public static class HttpStatusExtension
    {
        public static bool IsSuccessStatusCode(this HttpStatusCode statusCode)
        {
            return (int)statusCode >= 200 && (int)statusCode <= 299;
        }
    }
}
