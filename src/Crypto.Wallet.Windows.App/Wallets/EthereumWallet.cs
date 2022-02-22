using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Wallet.Windows.App.Wallets
{
    public class EthereumWallet
    {
        public static async Task CheckBalance(Web3 web3, string address) {
            var balance = await web3.Eth.GetBalance.SendRequestAsync(address);
            var etherAmount = Web3.Convert.FromWei(balance.Value);
            Console.WriteLine(address + ": " + etherAmount + " Ether");
        }
    }
}
