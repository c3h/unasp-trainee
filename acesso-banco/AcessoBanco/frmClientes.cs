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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            //preencher os paises
            var db = new NorthwindEntities();
            var paises = (from c in db.Customers
                          orderby c.Country
                          select c.Country).Distinct().ToList();
            cbPaíses.DataSource = paises;
        }
        public void CarregaClientes(List<Customer> Clientes)
        {
            this.dgvClientes.DataSource = Clientes;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmClienteEditar frm = new frmClienteEditar();
            frm.ShowDialog();
        }
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tabela = (List<Customer>)dgvClientes.DataSource;
            var frm = new frmClienteEditar();
            frm.CarregarCliente(tabela[e.RowIndex]);
            frm.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var pais = (from i in db.Customers
                            where i.Country == cbPaíses.Text
                            orderby i.Country
                            select i).ToList();
            CarregaClientes(pais);
        }
    }
}
