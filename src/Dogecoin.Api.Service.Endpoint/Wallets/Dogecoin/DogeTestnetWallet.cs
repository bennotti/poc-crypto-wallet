using System;
using System.Collections.Generic;
using System.Text;
using NBitcoin;
using NBitcoin.Altcoins;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint.Wallets.Dogecoin
{
    public class DogeTestnetWallet : Wallet
    {
        public DogeTestnetWallet() :
                                base()
        {
            this.Network = NBitcoin.Altcoins.Dogecoin.Instance.Testnet;
        }
        public DogeTestnetWallet(string passAndSalt, ScriptPubKeyType addrType) :
                                base(passAndSalt, addrType)
        {
            this.Network = NBitcoin.Altcoins.Dogecoin.Instance.Testnet;
        }

        public async Task<decimal> GetBalance(string address = "")
        {
            var dogeUTxOFetcher = new DogeUTxOFetcher();
            var allUtxos = await getUTxOs(dogeUTxOFetcher, "https://chain.so/api/v2/get_tx_unspent/DOGETEST/", address);

            return founds(allUtxos);
        }

        public override async Task<string> PushRawTxAsync(string toAddr, decimal amount, decimal fee, bool isDonationEnabled,
                                            string donationAddress, decimal donationAmount)
        {
            throw new NotImplementedException();
            //try
            //{
            //    var errorMsg = TxInputValidation(amount, fee, toAddr);
            //    if (errorMsg != null) return errorMsg;

            //    var dogeUTxOFetcher = new DogeUTxOFetcher();
            //    var allUtxos = await getUTxOs(dogeUTxOFetcher, DogeURLS.DogeTestnetUTxO);

            //    var txModel = FillTxModel(allUtxos, toAddr, donationAddress, amount, fee,
            //                              donationAmount, isDonationEnabled);
            //    if (!haveEnoughFunds(txModel)) return "Insufficient Funds";

            //    var rawTx = new RawTx();
            //    var txPusher = new DogeTxPusher();
            //    var txSignature = rawTx.SignRawTx(txModel);

            //    var txResult = await txPusher.BroadcastRawTx(DogeURLS.DogeTestnetBroadcast, txSignature);
            //    return txResult;
            //}
            //catch (Exception)
            //{
            //    return "Something Went Wrong.";
            //}
        }

    }
}
