namespace CaixaEletronico
{
    partial class Form1
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
            this.bntContaCorrente = new System.Windows.Forms.Button();
            this.Tela = new System.Windows.Forms.RichTextBox();
            this.btnContaPoupanca = new System.Windows.Forms.Button();
            this.NomeClienteCorrente = new System.Windows.Forms.TextBox();
            this.vSaldoCorrente = new System.Windows.Forms.TextBox();
            this.nCliente = new System.Windows.Forms.Label();
            this.vConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntContaCorrente
            // 
            this.bntContaCorrente.Location = new System.Drawing.Point(12, 90);
            this.bntContaCorrente.Name = "bntContaCorrente";
            this.bntContaCorrente.Size = new System.Drawing.Size(104, 23);
            this.bntContaCorrente.TabIndex = 0;
            this.bntContaCorrente.Text = "Conta Corrente";
            this.bntContaCorrente.UseVisualStyleBackColor = true;
            this.bntContaCorrente.Click += new System.EventHandler(this.bntContaCorrente_Click);
            // 
            // Tela
            // 
            this.Tela.Location = new System.Drawing.Point(122, 9);
            this.Tela.Name = "Tela";
            this.Tela.ReadOnly = true;
            this.Tela.Size = new System.Drawing.Size(333, 234);
            this.Tela.TabIndex = 1;
            this.Tela.Text = "";
            // 
            // btnContaPoupanca
            // 
            this.btnContaPoupanca.Location = new System.Drawing.Point(12, 119);
            this.btnContaPoupanca.Name = "btnContaPoupanca";
            this.btnContaPoupanca.Size = new System.Drawing.Size(104, 23);
            this.btnContaPoupanca.TabIndex = 2;
            this.btnContaPoupanca.Text = "Conta Poupança";
            this.btnContaPoupanca.UseVisualStyleBackColor = true;
            this.btnContaPoupanca.Click += new System.EventHandler(this.btnContaPoupanca_Click);
            // 
            // NomeClienteCorrente
            // 
            this.NomeClienteCorrente.Location = new System.Drawing.Point(12, 25);
            this.NomeClienteCorrente.Name = "NomeClienteCorrente";
            this.NomeClienteCorrente.Size = new System.Drawing.Size(104, 20);
            this.NomeClienteCorrente.TabIndex = 3;
            // 
            // vSaldoCorrente
            // 
            this.vSaldoCorrente.Location = new System.Drawing.Point(12, 64);
            this.vSaldoCorrente.Name = "vSaldoCorrente";
            this.vSaldoCorrente.Size = new System.Drawing.Size(104, 20);
            this.vSaldoCorrente.TabIndex = 4;
            // 
            // nCliente
            // 
            this.nCliente.AutoSize = true;
            this.nCliente.Location = new System.Drawing.Point(41, 9);
            this.nCliente.Name = "nCliente";
            this.nCliente.Size = new System.Drawing.Size(35, 13);
            this.nCliente.TabIndex = 5;
            this.nCliente.Text = "Nome";
            // 
            // vConta
            // 
            this.vConta.AutoSize = true;
            this.vConta.Location = new System.Drawing.Point(31, 48);
            this.vConta.Name = "vConta";
            this.vConta.Size = new System.Drawing.Size(64, 13);
            this.vConta.TabIndex = 6;
            this.vConta.Text = "Saldo Inicial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 255);
            this.Controls.Add(this.vConta);
            this.Controls.Add(this.nCliente);
            this.Controls.Add(this.vSaldoCorrente);
            this.Controls.Add(this.NomeClienteCorrente);
            this.Controls.Add(this.btnContaPoupanca);
            this.Controls.Add(this.Tela);
            this.Controls.Add(this.bntContaCorrente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntContaCorrente;
        private System.Windows.Forms.RichTextBox Tela;
        private System.Windows.Forms.Button btnContaPoupanca;
        private System.Windows.Forms.TextBox NomeClienteCorrente;
        private System.Windows.Forms.TextBox vSaldoCorrente;
        private System.Windows.Forms.Label nCliente;
        private System.Windows.Forms.Label vConta;
    }
}

