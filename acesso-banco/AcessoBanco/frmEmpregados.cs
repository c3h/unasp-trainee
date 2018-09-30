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
    public partial class frmEmpregados : Form
    {
        public frmEmpregados()
        {
            InitializeComponent();
        }
        public void CarregaEmpregados(List<Employee> Funcionarios)
        {
            this.dvgEmpregados.DataSource = Funcionarios;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEmpregadoEditar frm = new frmEmpregadoEditar();
            frm.ShowDialog();
        }

        private void dvgEmpregados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tabela = (List<Employee>)dvgEmpregados.DataSource;
            var frm = new frmEmpregadoEditar();
            frm.CarregarCliente(tabela[e.RowIndex]);
            frm.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var atualizar = (from i in db.Employees
                        select i).ToList();
            CarregaEmpregados(atualizar);
        }
    }
}
