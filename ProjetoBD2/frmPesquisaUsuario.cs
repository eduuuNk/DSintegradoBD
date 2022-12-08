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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);
            }
            else
            {
                this.tbUsuarioTableAdapter.FillByNome(this.cadastroDataSet.tbUsuario, "%"+txtNome.Text+"%");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void TbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbUsuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
