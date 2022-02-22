using Crypto.Wallet.Windows.App.Enum;
using Crypto.Wallet.Windows.App.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto.Wallet.Windows.App.Dtos
{
    public class CryptoWalletAddressDto
    {
        public WalletTypeEnum Tipo { get; set; }
        public string TipoCarteira { get { return Tipo.GetDisplayValue(); } }
        public string Endereco { get; set; }
        public decimal Saldo { get; set; }
    }
}
