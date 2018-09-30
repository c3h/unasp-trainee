namespace AcessoBanco
{
    partial class frmClienteEditar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txCustomerID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.txCompanyName = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.Label();
            this.txContactName = new System.Windows.Forms.TextBox();
            this.ContactTitle = new System.Windows.Forms.Label();
            this.txContactTitle = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.txCountry = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.txPostalCode = new System.Windows.Forms.TextBox();
            this.PostalCode = new System.Windows.Forms.Label();
            this.txRegion = new System.Windows.Forms.TextBox();
            this.Region = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.txCity = new System.Windows.Forms.TextBox();
            this.txFax = new System.Windows.Forms.TextBox();
            this.Fax = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(327, 183);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txCustomerID
            // 
            this.txCustomerID.Location = new System.Drawing.Point(12, 25);
            this.txCustomerID.MaxLength = 5;
            this.txCustomerID.Name = "txCustomerID";
            this.txCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txCustomerID.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(12, 9);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(62, 13);
            this.CustomerID.TabIndex = 2;
            this.CustomerID.Text = "CustomerID";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(12, 48);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(79, 13);
            this.CompanyName.TabIndex = 3;
            this.CompanyName.Text = "CompanyName";
            // 
            // txCompanyName
            // 
            this.txCompanyName.Location = new System.Drawing.Point(12, 64);
            this.txCompanyName.MaxLength = 40;
            this.txCompanyName.Name = "txCompanyName";
            this.txCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txCompanyName.TabIndex = 4;
            // 
            // ContactName
            // 
            this.ContactName.AutoSize = true;
            this.ContactName.Location = new System.Drawing.Point(12, 87);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(72, 13);
            this.ContactName.TabIndex = 5;
            this.ContactName.Text = "ContactName";
            // 
            // txContactName
            // 
            this.txContactName.Location = new System.Drawing.Point(12, 103);
            this.txContactName.MaxLength = 30;
            this.txContactName.Name = "txContactName";
            this.txContactName.Size = new System.Drawing.Size(100, 20);
            this.txContactName.TabIndex = 6;
            // 
            // ContactTitle
            // 
            this.ContactTitle.AutoSize = true;
            this.ContactTitle.Location = new System.Drawing.Point(12, 126);
            this.ContactTitle.Name = "ContactTitle";
            this.ContactTitle.Size = new System.Drawing.Size(64, 13);
            this.ContactTitle.TabIndex = 7;
            this.ContactTitle.Text = "ContactTitle";
            // 
            // txContactTitle
            // 
            this.txContactTitle.Location = new System.Drawing.Point(12, 142);
            this.txContactTitle.MaxLength = 30;
            this.txContactTitle.Name = "txContactTitle";
            this.txContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txContactTitle.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(12, 165);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(12, 181);
            this.txAddress.MaxLength = 60;
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(100, 20);
            this.txAddress.TabIndex = 10;
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(118, 181);
            this.txPhone.MaxLength = 24;
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(100, 20);
            this.txPhone.TabIndex = 20;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(118, 165);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 19;
            this.Phone.Text = "Phone";
            // 
            // txCountry
            // 
            this.txCountry.Location = new System.Drawing.Point(118, 142);
            this.txCountry.MaxLength = 15;
            this.txCountry.Name = "txCountry";
            this.txCountry.Size = new System.Drawing.Size(100, 20);
            this.txCountry.TabIndex = 18;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(118, 126);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(43, 13);
            this.Country.TabIndex = 17;
            this.Country.Text = "Country";
            // 
            // txPostalCode
            // 
            this.txPostalCode.Location = new System.Drawing.Point(118, 103);
            this.txPostalCode.MaxLength = 10;
            this.txPostalCode.Name = "txPostalCode";
            this.txPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txPostalCode.TabIndex = 16;
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSize = true;
            this.PostalCode.Location = new System.Drawing.Point(118, 87);
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(61, 13);
            this.PostalCode.TabIndex = 15;
            this.PostalCode.Text = "PostalCode";
            // 
            // txRegion
            // 
            this.txRegion.Location = new System.Drawing.Point(118, 64);
            this.txRegion.MaxLength = 15;
            this.txRegion.Name = "txRegion";
            this.txRegion.Size = new System.Drawing.Size(100, 20);
            this.txRegion.TabIndex = 14;
            // 
            // Region
            // 
            this.Region.AutoSize = true;
            this.Region.Location = new System.Drawing.Point(118, 48);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(41, 13);
            this.Region.TabIndex = 13;
            this.Region.Text = "Region";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(118, 9);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 12;
            this.City.Text = "City";
            // 
            // txCity
            // 
            this.txCity.Location = new System.Drawing.Point(118, 25);
            this.txCity.MaxLength = 15;
            this.txCity.Name = "txCity";
            this.txCity.Size = new System.Drawing.Size(100, 20);
            this.txCity.TabIndex = 11;
            // 
            // txFax
            // 
            this.txFax.Location = new System.Drawing.Point(224, 25);
            this.txFax.MaxLength = 24;
            this.txFax.Name = "txFax";
            this.txFax.Size = new System.Drawing.Size(100, 20);
            this.txFax.TabIndex = 22;
            // 
            // Fax
            // 
            this.Fax.AutoSize = true;
            this.Fax.Location = new System.Drawing.Point(224, 9);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(24, 13);
            this.Fax.TabIndex = 21;
            this.Fax.Text = "Fax";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(246, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmClienteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 218);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txFax);
            this.Controls.Add(this.Fax);
            this.Controls.Add(this.txPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.txCountry);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.txPostalCode);
            this.Controls.Add(this.PostalCode);
            this.Controls.Add(this.txRegion);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.City);
            this.Controls.Add(this.txCity);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.txContactTitle);
            this.Controls.Add(this.ContactTitle);
            this.Controls.Add(this.txContactName);
            this.Controls.Add(this.ContactName);
            this.Controls.Add(this.txCompanyName);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.txCustomerID);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 257);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 257);
            this.Name = "frmClienteEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienteEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txCustomerID;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.TextBox txCompanyName;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.TextBox txContactName;
        private System.Windows.Forms.Label ContactTitle;
        private System.Windows.Forms.TextBox txContactTitle;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.TextBox txPhone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txCountry;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox txPostalCode;
        private System.Windows.Forms.Label PostalCode;
        private System.Windows.Forms.TextBox txRegion;
        private System.Windows.Forms.Label Region;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox txCity;
        private System.Windows.Forms.TextBox txFax;
        private System.Windows.Forms.Label Fax;
        private System.Windows.Forms.Button btnExcluir;
    }
}