using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crypto.Wallet.Windows.App.Telas
{
    public partial class FrmImportarDogecoinWallet : Form
    {
        public decimal Balance { get; set; }
        public string Address { get; set; }
        public FrmImportarDogecoinWallet()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //var password = txtPassword.Text + txtPin.Text;
            //var dogeWallet = new DogeTestnetWallet(password, NBitcoin.ScriptPubKeyType.Legacy);

            //Address = dogeWallet.GetAddress();
            //Balance = dogeWallet.GetBalance().GetAwaiter().GetResult();

            this.DialogResult = DialogResult.OK;
        }
    }
}
