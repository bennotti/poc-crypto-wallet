using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto.Wallet.Windows.App.Dtos
{
    public class CryptoWalletAddressFileDocumentDto
    {
        public IList<CryptoWalletAddressDto> Address { get; set; } = new List<CryptoWalletAddressDto>();
    }
}
