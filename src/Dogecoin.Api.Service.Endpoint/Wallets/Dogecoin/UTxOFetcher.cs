using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Dogecoin.Api.Service.Endpoint.Wallets.Dogecoin
{
    public abstract class UTxOFetcher
    {
        protected HttpClient HttpClient { get; set; }
        public UTxOFetcher()
        {
            this.HttpClient = new HttpClient();
        }

    }
}
