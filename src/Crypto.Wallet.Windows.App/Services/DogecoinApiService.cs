using Crypto.Wallet.Windows.App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Crypto.Wallet.Windows.App.Extensions;
using Crypto.Wallet.Windows.App.Dtos;

namespace Crypto.Wallet.Windows.App.Services
{
    public class DogecoinApiService : IDogecoinApiService
    {
        private readonly HttpClient _httpClient;

        public DogecoinApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> GetBalance(string address)
        {
            //_httpClient.Timeout = TimeSpan.Zero;
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/address/{address}/balance");
            string content = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(content) && !response.StatusCode.IsSuccessStatusCode()) {
                throw new Exception("Não foi possivel recuperar o saldo do endereço!");
            }
            var responseApi = content.JsonFromObject<DogecoinBalanceAddressResponseDto>();

            if (!responseApi.Result) {
                throw new Exception("Não foi possivel recuperar o saldo do endereço!");
            }

            return Convert.ToDecimal(responseApi.Data.Saldo);
        }
    }
}
