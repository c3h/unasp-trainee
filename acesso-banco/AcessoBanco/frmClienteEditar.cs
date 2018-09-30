using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoBanco
{
    public partial class frmClienteEditar : Form
    {
        private bool edicao = false;
        public frmClienteEditar()
        {
            InitializeComponent();
        }
        public void CarregarCliente(Customer c)
        {
            //informcando que é uma edição
            edicao = true;
            txCustomerID.ReadOnly = true;
            txCustomerID.Text = c.CustomerID;
            txCompanyName.Text = c.CompanyName;
            txContactName.Text = c.ContactName;
            txContactTitle.Text = c.ContactTitle;
            txAddress.Text = c.Address;
            txCity.Text = c.City;
            txRegion.Text = c.Region;
            txPostalCode.Text = c.PostalCode;
            txCountry.Text = c.Country;
            txPhone.Text = c.Phone;
            txFax.Text = c.Fax;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var customer = new Customer()
            {
                CustomerID = txCustomerID.Text,
                CompanyName = txCompanyName.Text,
                ContactName = txContactName.Text,
                ContactTitle = txContactTitle.Text,
                Address = txAddress.Text,
                City = txCity.Text,
                Region = txRegion.Text,
                PostalCode = txPostalCode.Text,
                Country = txCountry.Text,
                Phone = txPhone.Text,
                Fax = txFax.Text,
            };
            
            try
            {
                if (edicao)
                {
                    db.Customers.Attach(customer);
                    db.Entry(customer).State = EntityState.Modified;
                }
                else
                {
                    //incluir na memoria
                    db.Customers.Add(customer);
                }
                //salvando no banco
                db.SaveChanges();
                MessageBox.Show("Salvo com sucesso!");
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var i in ex.EntityValidationErrors)
                {
                    foreach (var j in i.ValidationErrors)
                    {
                        MessageBox.Show(j.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "";
                if (ex.InnerException == null)
                    message = ex.Message;
                else if (ex.InnerException.InnerException == null)
                    message = ex.InnerException.Message;
                else if (ex.InnerException.InnerException.InnerException == null)
                    message = ex.InnerException.InnerException.Message;
                MessageBox.Show(message);
            }                  
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //para excluir, traga o registro do bando de dados
            //e depois exclua da memoria
            var db = new NorthwindEntities();
            var customer = (from c in db.Customers
                            where c.CustomerID == txCustomerID.Text
                            select c).FirstOrDefault();
            if (customer != null)
            {
                db.Customers.Remove(customer);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Excluido com Sucesso!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cliente não pode ser excluido");
                }
            }
            else
            {
                MessageBox.Show("Registro não excluido!");
            }
        }
    }
}
