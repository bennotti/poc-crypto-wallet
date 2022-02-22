using System;
using System.Collections.Generic;
using System.Text;

namespace Dogecoin.Api.Service.Endpoint.Wallets.Dogecoin
{
    public interface IUTxO
    {
        string GetTxId();
        uint GetOutputNo();
        string GetValue();
    }
}
