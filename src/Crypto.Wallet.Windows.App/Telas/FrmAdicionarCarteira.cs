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
    public partial class FrmAdicionarCarteira : Form
    {
        private readonly IDogecoinApiService _dogecoinApiService;
        public CryptoWalletAddressDto DadosCarteira;
        public FrmAdicionarCarteira(
            IDogecoinApiService dogecoinApiService
        ) {
            InitializeComponent();
            _dogecoinApiService = dogecoinApiService;
        }

        private async void btnContinuar_Click(object sender, EventArgs e)
        {
            // validar tipo de endereço da carteira
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Informe o endereço da carteira");
                return;
            }
            var saldo = await _dogecoinApiService.GetBalance(txtEndereco.Text);

            DadosCarteira = new CryptoWalletAddressDto
            {
                Endereco = txtEndereco.Text,
                Tipo = Enum.WalletTypeEnum.Dogecoin,
                Saldo = saldo
            };
            LimparCampos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        void LimparCampos()
        {
            txtEndereco.Text = String.Empty;
        }
    }
}
