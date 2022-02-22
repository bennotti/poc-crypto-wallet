namespace Crypto.Wallet.Windows.App.Telas
{
    partial class FrmImportarWallet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDogecoin = new System.Windows.Forms.RadioButton();
            this.rbEthereum = new System.Windows.Forms.RadioButton();
            this.rbBitcoin = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(98, 147);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(17, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbDogecoin);
            this.groupBox1.Controls.Add(this.rbEthereum);
            this.groupBox1.Controls.Add(this.rbBitcoin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carteira";
            // 
            // rbDogecoin
            // 
            this.rbDogecoin.AutoSize = true;
            this.rbDogecoin.Location = new System.Drawing.Point(6, 72);
            this.rbDogecoin.Name = "rbDogecoin";
            this.rbDogecoin.Size = new System.Drawing.Size(76, 19);
            this.rbDogecoin.TabIndex = 2;
            this.rbDogecoin.Text = "Dogecoin";
            this.rbDogecoin.UseVisualStyleBackColor = true;
            // 
            // rbEthereum
            // 
            this.rbEthereum.AutoSize = true;
            this.rbEthereum.Location = new System.Drawing.Point(6, 47);
            this.rbEthereum.Name = "rbEthereum";
            this.rbEthereum.Size = new System.Drawing.Size(76, 19);
            this.rbEthereum.TabIndex = 1;
            this.rbEthereum.Text = "Ethereum";
            this.rbEthereum.UseVisualStyleBackColor = true;
            // 
            // rbBitcoin
            // 
            this.rbBitcoin.AutoSize = true;
            this.rbBitcoin.Checked = true;
            this.rbBitcoin.Location = new System.Drawing.Point(6, 22);
            this.rbBitcoin.Name = "rbBitcoin";
            this.rbBitcoin.Size = new System.Drawing.Size(62, 19);
            this.rbBitcoin.TabIndex = 0;
            this.rbBitcoin.TabStop = true;
            this.rbBitcoin.Text = "Bitcoin";
            this.rbBitcoin.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Solana";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FrmImportarWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportarWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importar wallet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDogecoin;
        private System.Windows.Forms.RadioButton rbEthereum;
        private System.Windows.Forms.RadioButton rbBitcoin;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}