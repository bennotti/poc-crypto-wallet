using Crypto.Wallet.Windows.App.Dtos;
using Crypto.Wallet.Windows.App.Telas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto.Wallet.Windows.App
{
    public partial class FrmPrincipal : Form
    {
        private CryptoWalletAddressFileDocumentDto _document;
        private string _arquivoJson = string.Empty;
        private readonly FrmImportarWallet _frmImportarWallet;
        private readonly FrmAdicionarCarteira _frmAdicionarCarteira;

        public FrmPrincipal(
            FrmImportarWallet frmImportarWallet,
            FrmAdicionarCarteira frmAdicionarCarteira
        ) {
            InitializeComponent();
            _frmImportarWallet = frmImportarWallet;
            _frmAdicionarCarteira = frmAdicionarCarteira;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Crypto wallet",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void btnNovaListaEnderecos_Click(object sender, EventArgs e)
        {
            _document = new CryptoWalletAddressFileDocumentDto();

            saveDialog.FileName = $"crypto-wallet-address-{DateTime.Now:ddMMyyyy}-{DateTime.Now:HHmmss}.json";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _arquivoJson = saveDialog.FileName;
            }
            else
            {
                return;
            }

            SalvarArquivo();

            btnCriarCarteira.Enabled = true;
            btnImportarCarteira.Enabled = true;
            txtAmbienteConectado.Enabled = true;
            gbEnderecos.Enabled = true;
            btnSalvarListaEndereco.Enabled = true;
            btnConfiguracoes.Enabled = true;
            btnAdicionarCarteira.Enabled = true;
        }

        private void btnAbrirListaEnderecos_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _arquivoJson = openDialog.FileName;
            }
            else
            {
                return;
            }

            if (string.IsNullOrEmpty(_arquivoJson)) return;

            var jsonString = File.ReadAllText(_arquivoJson);
            _document = JsonConvert.DeserializeObject<CryptoWalletAddressFileDocumentDto>(jsonString);

            btnCriarCarteira.Enabled = true;
            btnImportarCarteira.Enabled = true;
            txtAmbienteConectado.Enabled = true;
            gbEnderecos.Enabled = true;
            btnSalvarListaEndereco.Enabled = true;
            btnConfiguracoes.Enabled = true;
            btnAdicionarCarteira.Enabled = true;

            AtualizarListaEnderecos();
        }

        void SalvarArquivo()
        {
            using (FileStream fs = File.Create(_arquivoJson))
            {
                var stringJson = JsonConvert.SerializeObject(_document, Formatting.Indented);
                byte[] info = new UTF8Encoding(true).GetBytes(stringJson);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        void AtualizarListaEnderecos()
        {
            dgvCarteiras.DataSource = new BindingList<CryptoWalletAddressDto>(_document.Address);

            var totalDogecoin = _document.Address.Where(p => p.Tipo == Enum.WalletTypeEnum.Dogecoin).Sum(p => p.Saldo);

            txtTotalDogecoin.Text = totalDogecoin.ToString();
        }

        private void btnSalvarListaEndereco_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
            MessageBox.Show("Lista de endereço salva com sucesso!", "Crypto wallet");
        }

        private void btnCriarCarteira_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendente Implementação");
        }

        private void btnImportarCarteira_Click(object sender, EventArgs e)
        {
            /*var result = _frmImportarWallet.ShowDialog();
            if (result != DialogResult.OK) {
                return;
            }

            _document.Address.Add(_frmImportarWallet.EnderecoImportado);

            AtualizarListaEnderecos();*/
            MessageBox.Show("Pendente Implementação");
        }

        private void btnCopiarEndereco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendente Implementação");
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendente Implementação");
        }

        private void btnRemoverCarteira_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendente Implementação");
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendente Implementação");
        }

        private void btnAdicionarCarteira_Click(object sender, EventArgs e)
        {
            var result = _frmAdicionarCarteira.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _document.Address.Add(_frmAdicionarCarteira.DadosCarteira);

            AtualizarListaEnderecos();
        }
    }
}
