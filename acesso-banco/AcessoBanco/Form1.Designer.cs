namespace AcessoBanco
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
            this.cmdClientes = new System.Windows.Forms.Button();
            this.btnEmpregado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClientes
            // 
            this.cmdClientes.Location = new System.Drawing.Point(12, 12);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(75, 23);
            this.cmdClientes.TabIndex = 0;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.UseVisualStyleBackColor = true;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // btnEmpregado
            // 
            this.btnEmpregado.Location = new System.Drawing.Point(12, 41);
            this.btnEmpregado.Name = "btnEmpregado";
            this.btnEmpregado.Size = new System.Drawing.Size(75, 23);
            this.btnEmpregado.TabIndex = 1;
            this.btnEmpregado.Text = "Empregado";
            this.btnEmpregado.UseVisualStyleBackColor = true;
            this.btnEmpregado.Click += new System.EventHandler(this.btnEmpregado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 162);
            this.Controls.Add(this.btnEmpregado);
            this.Controls.Add(this.cmdClientes);
            this.MaximumSize = new System.Drawing.Size(298, 201);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 201);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button btnEmpregado;
    }
}

