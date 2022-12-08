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

    public partial class frmFornecedores : Form
    {

        private void Habilita()
        {
            cdfornecedorTextBox.Enabled = false;
            nmfornecedorTextBox.Enabled = true;
            nmenderecoTextBox.Enabled = true;
            cdnumeroTextBox.Enabled = true;
            nmbairroTextBox.Enabled = true;
            nmcidadeTextBox.Enabled = true;
            sgestadoTextBox.Enabled = true;
            cdcepMaskedTextBox.Enabled = true;
            cdtelefoneTextBox.Enabled = true;
            cdcnpjMaskedTextBox.Enabled = true;
            cdieTextBox.Enabled = true;
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
            cdfornecedorTextBox.Enabled = false;
            nmfornecedorTextBox.Enabled = false;
            nmenderecoTextBox.Enabled = false;
            cdnumeroTextBox.Enabled = false;
            nmbairroTextBox.Enabled = false;
            nmcidadeTextBox.Enabled = false;
            sgestadoTextBox.Enabled = false;
            cdcepMaskedTextBox.Enabled = false;
            cdtelefoneTextBox.Enabled = false;
            cdcnpjMaskedTextBox.Enabled = false;
            cdieTextBox.Enabled = false;
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
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);

        }

        private void cdtelefoneTextBox_TextChanged(object sender, EventArgs e)
        {

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
            tbFornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbFornecedorBindingSource.EndEdit();
            tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
            Desabilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.RemoveCurrent();
            tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void cdcepMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
