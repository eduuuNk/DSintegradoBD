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
    public partial class frmPesquisaProduto : Form
    {
        private int codigo;

        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void tbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);

        }

        private void TbProdutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbProdutoDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbProdutoTableAdapter.Fill(this.cadastroDataSet.tbProduto);
            }
            else
            {
                this.tbProdutoTableAdapter.FillByName(this.cadastroDataSet.tbProduto, "%" + txtNome.Text + "%");
            }
        }
    }
}
