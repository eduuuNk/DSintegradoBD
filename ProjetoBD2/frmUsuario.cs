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
    public partial class frmUsuario : Form
    {
        bool tipoEdicao = false;
        int atual = 0;
        private void Habilita()
        {
            cdusuarioTextBox.Enabled = false;
            nmusuarioTextBox.Enabled = true;
            sgnivelTextBox.Enabled = true;
            nmloginTextBox.Enabled = true;
            cdsenhaTextBox.Enabled = true;
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
            cdusuarioTextBox.Enabled = false;
            nmusuarioTextBox.Enabled = false;
            sgnivelTextBox.Enabled = false;
            nmloginTextBox.Enabled = false;
            cdsenhaTextBox.Enabled = false;
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


        public frmUsuario()
        {
            InitializeComponent();
        }

        private void TbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);

        }

        private void CdusuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void CdsenhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NmusuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void NmusuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SgnivelLabel_Click(object sender, EventArgs e)
        {

        }

        private void SgnivelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NmloginLabel_Click(object sender, EventArgs e)
        {

        }

        private void NmloginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CdsenhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void CdusuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.AddNew();
            Habilita();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbUsuarioBindingSource.EndEdit();
            tbUsuarioTableAdapter.Update(cadastroDataSet.tbUsuario);
            Desabilita();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MovePrevious();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo = 0, reg = 0;
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            codigo = fpu.getCodigo();
            if (codigo > 0)
            {
                reg = tbUsuarioBindingSource.Find("cdusuario", codigo);
                tbUsuarioBindingSource.Position = reg;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.RemoveCurrent();
            tbUsuarioTableAdapter.Update(cadastroDataSet.tbUsuario);
        }
    }
}
