namespace Crypto.Wallet.Windows.App.Telas
{
    partial class FrmAdicionarCarteira
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbDogecoin = new System.Windows.Forms.RadioButton();
            this.rbEthereum = new System.Windows.Forms.RadioButton();
            this.rbBitcoin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbDogecoin);
            this.groupBox1.Controls.Add(this.rbEthereum);
            this.groupBox1.Controls.Add(this.rbBitcoin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(170, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(251, 187);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "Solana";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbDogecoin
            // 
            this.rbDogecoin.AutoSize = true;
            this.rbDogecoin.Location = new System.Drawing.Point(6, 72);
            this.rbDogecoin.Name = "rbDogecoin";
            this.rbDogecoin.Size = new System.Drawing.Size(76, 19);
            this.rbDogecoin.TabIndex = 6;
            this.rbDogecoin.Text = "Dogecoin";
            this.rbDogecoin.UseVisualStyleBackColor = true;
            // 
            // rbEthereum
            // 
            this.rbEthereum.AutoSize = true;
            this.rbEthereum.Location = new System.Drawing.Point(6, 47);
            this.rbEthereum.Name = "rbEthereum";
            this.rbEthereum.Size = new System.Drawing.Size(76, 19);
            this.rbEthereum.TabIndex = 5;
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
            this.rbBitcoin.TabIndex = 4;
            this.rbBitcoin.TabStop = true;
            this.rbBitcoin.Text = "Bitcoin";
            this.rbBitcoin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 137);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(302, 23);
            this.txtEndereco.TabIndex = 9;
            // 
            // FrmAdicionarCarteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 222);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdicionarCarteira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar carteira";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbDogecoin;
        private System.Windows.Forms.RadioButton rbEthereum;
        private System.Windows.Forms.RadioButton rbBitcoin;
    }
}