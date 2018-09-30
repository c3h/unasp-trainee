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
    public partial class frmEmpregadoEditar : Form
    {
        private bool edicao = false;
        public frmEmpregadoEditar()
        {
            Employee e = new Employee();
            InitializeComponent();
            var db = new NorthwindEntities();
            var title = (from c in db.Employees
                          orderby c.Title
                          select c.Title).Distinct().ToList();
            cbTitle.DataSource = title;
            var titlecourtesy = (from c in db.Employees
                                 orderby c.TitleOfCourtesy
                                 select c.TitleOfCourtesy).Distinct().ToList();
            cbTitleOfCourtesy.DataSource = titlecourtesy;
            txEmployeeID.ReadOnly = true;
        }
        public void CarregarCliente(Employee e)
        {
            edicao = true;
            txEmployeeID.ReadOnly = true;
            txEmployeeID.Text = e.EmployeeID.ToString();
            txFirstName.Text = e.FirstName;
            txLastName.Text = e.LastName;
            cbTitle.Text = e.Title;
            cbTitleOfCourtesy.Text = e.TitleOfCourtesy;
            txBirthDate.Text = e.BirthDate.ToString();
            txAddress.Text = e.Address;
            txCity.Text = e.City;
            txRegion.Text = e.Region;
            txPotalCode.Text  = e.PostalCode;
            txCountry.Text = e.Country;
            txHomePhone.Text = e.HomePhone;
            txExtension.Text = e.Extension;
            txNote.Text = e.Notes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var employee = new Employee()
            {
                FirstName = txFirstName.Text,
                LastName = txLastName.Text,
                Title = cbTitle.Text,
                TitleOfCourtesy = cbTitleOfCourtesy.Text,
                BirthDate = DateTime.Parse(txBirthDate.Text),
                Address = txAddress.Text,
                City = txCity.Text,
                Region = txRegion.Text,
                PostalCode = txPotalCode.Text,
                Country = txCountry.Text,
                HomePhone = txHomePhone.Text,
                Extension = txExtension.Text,
                Notes = txNote.Text,
            };

            try
            {
                if (edicao)
                {
                    employee.EmployeeID = int.Parse(txEmployeeID.Text);
                    db.Employees.Attach(employee);
                    db.Entry(employee).State = EntityState.Modified;
                }
                else
                {
                    //incluir na memoria
                    db.Employees.Add(employee);
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

        private void btnExluir_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            Employee ey = new Employee();
            var eID = int.Parse(txEmployeeID.Text);
            var employeer = (from c in db.Employees
                             where c.EmployeeID == eID
                             select c).FirstOrDefault();
            if (employeer != null)
            {
                db.Employees.Remove(employeer);
                try
                {
                    ey.EmployeeID = int.Parse(txEmployeeID.Text);
                    db.SaveChanges();
                    MessageBox.Show("Excluido com sucesso!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registro não excluido");
                }
            }
        }
    }
}
