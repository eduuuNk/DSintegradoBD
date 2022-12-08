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
    public partial class frmProdutos : Form
    {
        private void Habilita()
        {
            cdprodutoTextBox.Enabled = false;
            nmprodutoTextBox.Enabled = true;
            sgunidadeTextBox.Enabled = true;
            vlcustoTextBox.Enabled = true;
            vlvendaTextBox.Enabled = true;
            qtdestoqueTextBox.Enabled = true;
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
            cdprodutoTextBox.Enabled = false;
            nmprodutoTextBox.Enabled = false;
            sgunidadeTextBox.Enabled = false;
            vlcustoTextBox.Enabled = false;
            vlvendaTextBox.Enabled = false;
            qtdestoqueTextBox.Enabled = false;
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
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void tbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);

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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbProdutoBindingSource.EndEdit();
            tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
            Desabilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.RemoveCurrent();
            tbProdutoTableAdapter.Update(cadastroDataSet.tbProduto);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.AddNew();
            Habilita();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MovePrevious();
        }

        private void qtdestoqueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cdprodutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmprodutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nmprodutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sgunidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void sgunidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vlcustoLabel_Click(object sender, EventArgs e)
        {

        }

        private void vlcustoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vlvendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void cdprodutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void qtdestoqueLabel_Click(object sender, EventArgs e)
        {

        }

        private void vlvendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
