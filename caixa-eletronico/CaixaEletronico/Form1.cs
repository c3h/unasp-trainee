using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using International.Bank;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        ContaBancaria[] ContBancaria = new ContaBancaria[20];
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bntContaCorrente_Click(object sender, EventArgs e)
        {
            ContBancaria[contador] = new ContCorrente(NomeClienteCorrente.Text, double.Parse(vSaldoCorrente.Text));
            MostrarDadosConta(ContBancaria[contador]);
            contador++;
        }
        private void btnContaPoupanca_Click(object sender, EventArgs e)
        {
            ContBancaria[contador] = new ContPoupanca(NomeClienteCorrente.Text, double.Parse(vSaldoCorrente.Text));
            MostrarDadosConta(ContBancaria[contador]);
            contador++;
        }

        private void MostrarDadosConta(ContaBancaria cb)
        {
            Tela.Text += string.Format("\nConta: {0}", cb.NumeroConta);
            Tela.Text += string.Format("\nConta: {0}", cb.Nome);
            Tela.Text += string.Format("\nConta: {0}\n", cb.Saldo);
        }
    }
}
