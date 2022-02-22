using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Wallet.Windows.App.Services.Interfaces
{
    public interface IDogecoinApiService
    {
        Task<decimal> GetBalance(string address);
    }
}
