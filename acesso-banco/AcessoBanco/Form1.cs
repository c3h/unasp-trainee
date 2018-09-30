using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            var db = new NorthwindEntities();
            var clientes =  (from c in db.Customers
                             orderby c.CompanyName select c).ToList();
            frm.CarregaClientes(clientes);
            frm.ShowDialog();
        }

        private void btnEmpregado_Click(object sender, EventArgs e)
        {
            frmEmpregados frm = new frmEmpregados();
            var db = new NorthwindEntities();
            var funcionarios = (from c in db.Employees
                                select c).ToList();
            frm.CarregaEmpregados(funcionarios);
            frm.ShowDialog();
        }
    }
}
