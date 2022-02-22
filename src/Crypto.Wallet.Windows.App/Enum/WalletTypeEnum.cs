using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Crypto.Wallet.Windows.App.Enum
{
    public enum WalletTypeEnum
    {
        [Display(Name = "Bitcoin")]
        Bitcoin = 0,
        [Display(Name = "Ethereum")]
        Ethereum = 1,
        [Display(Name = "Dogecoin")]
        Dogecoin = 2,
        [Display(Name = "Solana")]
        Solana = 2
    }
}
