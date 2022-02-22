using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint.Wallets.Dogecoin
{
    public class DogeUTxOFetcher : UTxOFetcher, IUTxOFetcher
    {
        public DogeUTxOFetcher() : base()
        {
        }
        public async Task<IUTxO[]> FetchUTxOAsync(string UTxOURL, string address)
        {
            var apiCall = await HttpClient.GetAsync(UTxOURL + address);
            var asStr = await apiCall.Content.ReadAsStringAsync();
            var UTxOs = System.Text.Json.JsonSerializer.Deserialize<Data>(asStr);

            return UTxOs.data.txs;
        }
    }
}
