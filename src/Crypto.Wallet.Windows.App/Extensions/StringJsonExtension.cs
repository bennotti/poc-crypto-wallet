using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto.Wallet.Windows.App.Extensions
{
    public static class StringJsonExtension
    {
        public static T JsonFromObject<T>(this string json)
        {
            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return default;
        }


        public static string JsonFromString(this object obj)
        {
            if (obj != null)
            {
                try
                {
                    var data = JsonConvert.SerializeObject(obj);

                    return data;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return default;

        }

    }
}
