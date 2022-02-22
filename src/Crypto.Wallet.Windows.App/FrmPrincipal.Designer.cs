namespace Crypto.Wallet.Windows.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnImportarCarteira = new System.Windows.Forms.Button();
            this.btnCriarCarteira = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnRemoverCarteira = new System.Windows.Forms.Button();
            this.gbEnderecos = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnCopiarEndereco = new System.Windows.Forms.Button();
            this.txtTotalDogecoin = new System.Windows.Forms.TextBox();
            this.txtTotalEthereum = new System.Windows.Forms.TextBox();
            this.txtTotalBitcoin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCarteiras = new System.Windows.Forms.DataGridView();
            this.cryptoWalletAddressDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmbienteConectado = new System.Windows.Forms.TextBox();
            this.btnNovaListaEnderecos = new System.Windows.Forms.Button();
            this.btnAbrirListaEnderecos = new System.Windows.Forms.Button();
            this.btnSalvarListaEndereco = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnAdicionarCarteira = new System.Windows.Forms.Button();
            this.tipoCarteiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoWalletAddressDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportarCarteira
            // 
            this.btnImportarCarteira.Enabled = false;
            this.btnImportarCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarCarteira.Location = new System.Drawing.Point(148, 12);
            this.btnImportarCarteira.Name = "btnImportarCarteira";
            this.btnImportarCarteira.Size = new System.Drawing.Size(130, 40);
            this.btnImportarCarteira.TabIndex = 0;
            this.btnImportarCarteira.Text = "Importar carteira";
            this.btnImportarCarteira.UseVisualStyleBackColor = true;
            this.btnImportarCarteira.Click += new System.EventHandler(this.btnImportarCarteira_Click);
            // 
            // btnCriarCarteira
            // 
            this.btnCriarCarteira.Enabled = false;
            this.btnCriarCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarCarteira.Location = new System.Drawing.Point(12, 12);
            this.btnCriarCarteira.Name = "btnCriarCarteira";
            this.btnCriarCarteira.Size = new System.Drawing.Size(130, 40);
            this.btnCriarCarteira.TabIndex = 0;
            this.btnCriarCarteira.Text = "Criar carteira";
            this.btnCriarCarteira.UseVisualStyleBackColor = true;
            this.btnCriarCarteira.Click += new System.EventHandler(this.btnCriarCarteira_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(642, 509);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 40);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRemoverCarteira
            // 
            this.btnRemoverCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCarteira.Location = new System.Drawing.Point(624, 66);
            this.btnRemoverCarteira.Name = "btnRemoverCarteira";
            this.btnRemoverCarteira.Size = new System.Drawing.Size(130, 40);
            this.btnRemoverCarteira.TabIndex = 3;
            this.btnRemoverCarteira.Text = "Remover carteira";
            this.btnRemoverCarteira.UseVisualStyleBackColor = true;
            this.btnRemoverCarteira.Click += new System.EventHandler(this.btnRemoverCarteira_Click);
            // 
            // gbEnderecos
            // 
            this.gbEnderecos.Controls.Add(this.btnTransferir);
            this.gbEnderecos.Controls.Add(this.btnCopiarEndereco);
            this.gbEnderecos.Controls.Add(this.txtTotalDogecoin);
            this.gbEnderecos.Controls.Add(this.txtTotalEthereum);
            this.gbEnderecos.Controls.Add(this.txtTotalBitcoin);
            this.gbEnderecos.Controls.Add(this.label6);
            this.gbEnderecos.Controls.Add(this.label4);
            this.gbEnderecos.Controls.Add(this.label1);
            this.gbEnderecos.Controls.Add(this.btnRemoverCarteira);
            this.gbEnderecos.Controls.Add(this.dgvCarteiras);
            this.gbEnderecos.Enabled = false;
            this.gbEnderecos.Location = new System.Drawing.Point(12, 58);
            this.gbEnderecos.Name = "gbEnderecos";
            this.gbEnderecos.Size = new System.Drawing.Size(760, 445);
            this.gbEnderecos.TabIndex = 4;
            this.gbEnderecos.TabStop = false;
            this.gbEnderecos.Text = "Endereços";
            // 
            // btnTransferir
            // 
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Location = new System.Drawing.Point(142, 66);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(130, 40);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnCopiarEndereco
            // 
            this.btnCopiarEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarEndereco.Location = new System.Drawing.Point(6, 66);
            this.btnCopiarEndereco.Name = "btnCopiarEndereco";
            this.btnCopiarEndereco.Size = new System.Drawing.Size(130, 40);
            this.btnCopiarEndereco.TabIndex = 3;
            this.btnCopiarEndereco.Text = "Copiar endereço";
            this.btnCopiarEndereco.UseVisualStyleBackColor = true;
            this.btnCopiarEndereco.Click += new System.EventHandler(this.btnCopiarEndereco_Click);
            // 
            // txtTotalDogecoin
            // 
            this.txtTotalDogecoin.Location = new System.Drawing.Point(508, 37);
            this.txtTotalDogecoin.Name = "txtTotalDogecoin";
            this.txtTotalDogecoin.ReadOnly = true;
            this.txtTotalDogecoin.Size = new System.Drawing.Size(246, 23);
            this.txtTotalDogecoin.TabIndex = 2;
            this.txtTotalDogecoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalEthereum
            // 
            this.txtTotalEthereum.Location = new System.Drawing.Point(257, 37);
            this.txtTotalEthereum.Name = "txtTotalEthereum";
            this.txtTotalEthereum.ReadOnly = true;
            this.txtTotalEthereum.Size = new System.Drawing.Size(245, 23);
            this.txtTotalEthereum.TabIndex = 1;
            this.txtTotalEthereum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalBitcoin
            // 
            this.txtTotalBitcoin.Location = new System.Drawing.Point(6, 37);
            this.txtTotalBitcoin.Name = "txtTotalBitcoin";
            this.txtTotalBitcoin.ReadOnly = true;
            this.txtTotalBitcoin.Size = new System.Drawing.Size(245, 23);
            this.txtTotalBitcoin.TabIndex = 0;
            this.txtTotalBitcoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Dogecoin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Ethereum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Bitcoin";
            // 
            // dgvCarteiras
            // 
            this.dgvCarteiras.AllowUserToAddRows = false;
            this.dgvCarteiras.AllowUserToDeleteRows = false;
            this.dgvCarteiras.AutoGenerateColumns = false;
            this.dgvCarteiras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarteiras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarteiras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoCarteiraDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn});
            this.dgvCarteiras.DataSource = this.cryptoWalletAddressDtoBindingSource;
            this.dgvCarteiras.Location = new System.Drawing.Point(6, 112);
            this.dgvCarteiras.MultiSelect = false;
            this.dgvCarteiras.Name = "dgvCarteiras";
            this.dgvCarteiras.ReadOnly = true;
            this.dgvCarteiras.RowHeadersVisible = false;
            this.dgvCarteiras.RowTemplate.Height = 25;
            this.dgvCarteiras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarteiras.Size = new System.Drawing.Size(748, 327);
            this.dgvCarteiras.TabIndex = 4;
            // 
            // cryptoWalletAddressDtoBindingSource
            // 
            this.cryptoWalletAddressDtoBindingSource.DataSource = typeof(Crypto.Wallet.Windows.App.Dtos.CryptoWalletAddressDto);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Enabled = false;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Location = new System.Drawing.Point(420, 509);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(130, 40);
            this.btnConfiguracoes.TabIndex = 5;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ambiente conectada";
            // 
            // txtAmbienteConectado
            // 
            this.txtAmbienteConectado.Enabled = false;
            this.txtAmbienteConectado.Location = new System.Drawing.Point(420, 29);
            this.txtAmbienteConectado.Name = "txtAmbienteConectado";
            this.txtAmbienteConectado.ReadOnly = true;
            this.txtAmbienteConectado.Size = new System.Drawing.Size(352, 23);
            this.txtAmbienteConectado.TabIndex = 2;
            this.txtAmbienteConectado.Text = "Teste";
            // 
            // btnNovaListaEnderecos
            // 
            this.btnNovaListaEnderecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaListaEnderecos.Location = new System.Drawing.Point(12, 509);
            this.btnNovaListaEnderecos.Name = "btnNovaListaEnderecos";
            this.btnNovaListaEnderecos.Size = new System.Drawing.Size(130, 40);
            this.btnNovaListaEnderecos.TabIndex = 7;
            this.btnNovaListaEnderecos.Text = "Nova lista de endereço";
            this.btnNovaListaEnderecos.UseVisualStyleBackColor = true;
            this.btnNovaListaEnderecos.Click += new System.EventHandler(this.btnNovaListaEnderecos_Click);
            // 
            // btnAbrirListaEnderecos
            // 
            this.btnAbrirListaEnderecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirListaEnderecos.Location = new System.Drawing.Point(148, 509);
            this.btnAbrirListaEnderecos.Name = "btnAbrirListaEnderecos";
            this.btnAbrirListaEnderecos.Size = new System.Drawing.Size(130, 40);
            this.btnAbrirListaEnderecos.TabIndex = 8;
            this.btnAbrirListaEnderecos.Text = "Abrir lista de endereço";
            this.btnAbrirListaEnderecos.UseVisualStyleBackColor = true;
            this.btnAbrirListaEnderecos.Click += new System.EventHandler(this.btnAbrirListaEnderecos_Click);
            // 
            // btnSalvarListaEndereco
            // 
            this.btnSalvarListaEndereco.Enabled = false;
            this.btnSalvarListaEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarListaEndereco.Location = new System.Drawing.Point(284, 509);
            this.btnSalvarListaEndereco.Name = "btnSalvarListaEndereco";
            this.btnSalvarListaEndereco.Size = new System.Drawing.Size(130, 40);
            this.btnSalvarListaEndereco.TabIndex = 9;
            this.btnSalvarListaEndereco.Text = "Salvar lista de endereço";
            this.btnSalvarListaEndereco.UseVisualStyleBackColor = true;
            this.btnSalvarListaEndereco.Click += new System.EventHandler(this.btnSalvarListaEndereco_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "*.json";
            this.openDialog.Filter = "Json File | *.json|All files (*.*)|*.*";
            this.openDialog.Title = "Abrir lista endereço";
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "json";
            this.saveDialog.Filter = "Json File | *.json";
            this.saveDialog.Title = "Salvar lista endereço";
            // 
            // btnAdicionarCarteira
            // 
            this.btnAdicionarCarteira.Enabled = false;
            this.btnAdicionarCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCarteira.Location = new System.Drawing.Point(284, 12);
            this.btnAdicionarCarteira.Name = "btnAdicionarCarteira";
            this.btnAdicionarCarteira.Size = new System.Drawing.Size(130, 40);
            this.btnAdicionarCarteira.TabIndex = 10;
            this.btnAdicionarCarteira.Text = "Adicionar carteira";
            this.btnAdicionarCarteira.UseVisualStyleBackColor = true;
            this.btnAdicionarCarteira.Click += new System.EventHandler(this.btnAdicionarCarteira_Click);
            // 
            // tipoCarteiraDataGridViewTextBoxColumn
            // 
            this.tipoCarteiraDataGridViewTextBoxColumn.DataPropertyName = "TipoCarteira";
            this.tipoCarteiraDataGridViewTextBoxColumn.FillWeight = 20F;
            this.tipoCarteiraDataGridViewTextBoxColumn.HeaderText = "TipoCarteira";
            this.tipoCarteiraDataGridViewTextBoxColumn.Name = "tipoCarteiraDataGridViewTextBoxColumn";
            this.tipoCarteiraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.FillWeight = 30F;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdicionarCarteira);
            this.Controls.Add(this.btnSalvarListaEndereco);
            this.Controls.Add(this.btnAbrirListaEnderecos);
            this.Controls.Add(this.btnNovaListaEnderecos);
            this.Controls.Add(this.txtAmbienteConectado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.gbEnderecos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCriarCarteira);
            this.Controls.Add(this.btnImportarCarteira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.gbEnderecos.ResumeLayout(false);
            this.gbEnderecos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoWalletAddressDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportarCarteira;
        private System.Windows.Forms.Button btnCriarCarteira;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRemoverCarteira;
        private System.Windows.Forms.GroupBox gbEnderecos;
        private System.Windows.Forms.TextBox txtTotalDogecoin;
        private System.Windows.Forms.TextBox txtTotalEthereum;
        private System.Windows.Forms.TextBox txtTotalBitcoin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCarteiras;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmbienteConectado;
        private System.Windows.Forms.Button btnCopiarEndereco;
        private System.Windows.Forms.BindingSource cryptoWalletAddressDtoBindingSource;
        private System.Windows.Forms.Button btnNovaListaEnderecos;
        private System.Windows.Forms.Button btnAbrirListaEnderecos;
        private System.Windows.Forms.Button btnSalvarListaEndereco;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnAdicionarCarteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCarteiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
    }
}
