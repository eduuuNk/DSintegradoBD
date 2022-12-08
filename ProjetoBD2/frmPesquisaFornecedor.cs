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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;

        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);

        }

        private void TbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbFornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);
            }
            else
            {
                this.tbFornecedorTableAdapter.FillByNmo(this.cadastroDataSet.tbFornecedor, "%" + txtNome.Text + "%");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }
    }
}
