using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBD2
{
    public partial class frmClientes : Form
    {
        private bool validaCPF(string cpf)
        {
            bool resp = false;
            int dig1 = 0, dig2 = 0;
            dig1 += int.Parse(cpf.Substring(10, 1)) * 2;
            dig1 += int.Parse(cpf.Substring(9, 1)) * 3;
            dig1 += int.Parse(cpf.Substring(8, 1)) * 4;
            dig1 += int.Parse(cpf.Substring(6, 1)) * 5;
            dig1 += int.Parse(cpf.Substring(5, 1)) * 6;
            dig1 += int.Parse(cpf.Substring(4, 1)) * 7;
            dig1 += int.Parse(cpf.Substring(2, 1)) * 8;
            dig1 += int.Parse(cpf.Substring(1, 1)) * 9;
            dig1 += int.Parse(cpf.Substring(0, 1)) * 10;
            dig1 = dig1 % 11;
            dig1 = dig1 < 2 ? 0 : 11 - dig1;

            dig2 += int.Parse(cpf.Substring(12, 1)) * 2;
            dig2 += int.Parse(cpf.Substring(10, 1)) * 3;
            dig2 += int.Parse(cpf.Substring(9, 1)) * 4;
            dig2 += int.Parse(cpf.Substring(8, 1)) * 5;
            dig2 += int.Parse(cpf.Substring(6, 1)) * 6;
            dig2 += int.Parse(cpf.Substring(5, 1)) * 7;
            dig2 += int.Parse(cpf.Substring(4, 1)) * 8;
            dig2 += int.Parse(cpf.Substring(2, 1)) * 9;
            dig2 += int.Parse(cpf.Substring(1, 1)) * 10;
            dig2 += int.Parse(cpf.Substring(0, 1)) * 11;
            dig2 = dig1 % 11;
            dig2 = dig1 < 2 ? 0 : 11 - dig1;
            if (dig1== int.Parse(cpf.Substring(12, 1)) && dig2== int.Parse(cpf.Substring(13, 1)))
            {
                resp = true;
            }

            return resp;
        }
        private void Habilita()
        {
            cdclienteTextBox.Enabled = false;
            nmclienteTextBox.Enabled = true;
            nmenderecoTextBox.Enabled = true;
            cdnumeroTextBox.Enabled = true;
            nmbairroTextBox.Enabled = true;
            nmcidadeTextBox.Enabled = true;
            sgestadoTextBox.Enabled = true;
            cdcepMaskedTextBox.Enabled = true;
            cdtelefoneTextBox.Enabled = true;
            cdcpfMaskedTextBox.Enabled = true;
            cdrgTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void Desabilita()
        {
            cdclienteTextBox.Enabled = false;
            nmclienteTextBox.Enabled = false;
            nmenderecoTextBox.Enabled = false;
            cdnumeroTextBox.Enabled = false;
            nmbairroTextBox.Enabled = false;
            nmcidadeTextBox.Enabled = false;
            sgestadoTextBox.Enabled = false;
            cdcepMaskedTextBox.Enabled = false;
            cdtelefoneTextBox.Enabled = false;
            cdcpfMaskedTextBox.Enabled = false;
            cdrgTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmClientes()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);

        }

        private void cdclienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmclienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmenderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cdnumeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmbairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmcidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sgestadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cdcepTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cdtelefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod=0, reg=0;
            fmrPesquisaCliente fg = new fmrPesquisaCliente();
            fg.ShowDialog();
            cod = fg.getCodigo();
            if (cod > 0)
            {
                tbClienteBindingSource.Find("cdcliente", cod);
                tbClienteBindingSource.Position = reg;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCPF(cdcpfMaskedTextBox.Text))
            {
                Validate();
            }
            else
            {
                MessageBox.Show("CPF invalido ! ! !");
                cdcpfMaskedTextBox.Focus();
            }

            Validate();
            tbClienteBindingSource.EndEdit();
            tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
            Desabilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.RemoveCurrent();
            tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            Habilita();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }
    }
}
