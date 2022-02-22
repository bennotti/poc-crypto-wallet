using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Crypto.Wallet.Windows.App.Dtos
{
    public class DogecoinBalanceAddressDataResponseDto
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("saldo")]
        public double Saldo { get; set; }
    }
}
