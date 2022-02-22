using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Crypto.Wallet.Windows.App.Dtos
{
    public class DogecoinBalanceAddressResponseDto
    {
        [JsonPropertyName("result")]
        public bool Result { get; set; }

        [JsonPropertyName("data")]
        public DogecoinBalanceAddressDataResponseDto Data { get; set; }
    }
}
