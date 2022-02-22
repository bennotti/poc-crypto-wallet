using Crypto.Wallet.Windows.App.Dtos;
using Crypto.Wallet.Windows.App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crypto.Wallet.Windows.App.Telas
{
    public partial class FrmImportarWallet : Form
    {
        private readonly IDogecoinApiService _dogecoinService;
        private readonly FrmImportarDogecoinWallet _frmImportarDogecoinWallet;
        public CryptoWalletAddressDto EnderecoImportado;
        public FrmImportarWallet(
            FrmImportarDogecoinWallet frmImportarDogecoinWallet,
            IDogecoinApiService dogecoinService
        ) {
            InitializeComponent();
            _frmImportarDogecoinWallet = frmImportarDogecoinWallet;
            _dogecoinService = dogecoinService;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var result = _frmImportarDogecoinWallet.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.DialogResult = result;
                return;
            }

            var address = _frmImportarDogecoinWallet.Address;
            var saldo = _frmImportarDogecoinWallet.Balance;

            EnderecoImportado = new CryptoWalletAddressDto
            {
                Endereco = _frmImportarDogecoinWallet.Address,
                Tipo = Enum.WalletTypeEnum.Dogecoin,
                Saldo = saldo
            };

            this.DialogResult = result;
            this.Close();
        }
    }
}
