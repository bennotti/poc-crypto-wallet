using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint.Wallets.Dogecoin
{
    public interface IUTxOFetcher
    {
        Task<IUTxO[]> FetchUTxOAsync(string UTxOURL, string address);
    }
}
