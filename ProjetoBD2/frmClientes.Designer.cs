
namespace ProjetoBD2
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cdclienteLabel;
            System.Windows.Forms.Label nmclienteLabel;
            System.Windows.Forms.Label nmenderecoLabel;
            System.Windows.Forms.Label cdnumeroLabel;
            System.Windows.Forms.Label nmbairroLabel;
            System.Windows.Forms.Label nmcidadeLabel;
            System.Windows.Forms.Label sgestadoLabel;
            System.Windows.Forms.Label cdcepLabel;
            System.Windows.Forms.Label cdtelefoneLabel;
            System.Windows.Forms.Label cdrgLabel;
            System.Windows.Forms.Label cdcepLabel1;
            System.Windows.Forms.Label cdcpfLabel1;
            this.cadastroDataSet = new ProjetoBD2.CadastroDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoBD2.CadastroDataSetTableAdapters.tbClienteTableAdapter();
            this.tableAdapterManager = new ProjetoBD2.CadastroDataSetTableAdapters.TableAdapterManager();
            this.cdclienteTextBox = new System.Windows.Forms.TextBox();
            this.nmclienteTextBox = new System.Windows.Forms.TextBox();
            this.nmenderecoTextBox = new System.Windows.Forms.TextBox();
            this.cdnumeroTextBox = new System.Windows.Forms.TextBox();
            this.nmbairroTextBox = new System.Windows.Forms.TextBox();
            this.nmcidadeTextBox = new System.Windows.Forms.TextBox();
            this.sgestadoTextBox = new System.Windows.Forms.TextBox();
            this.cdtelefoneTextBox = new System.Windows.Forms.TextBox();
            this.cdrgTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cdcepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cdcpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cdclienteLabel = new System.Windows.Forms.Label();
            nmclienteLabel = new System.Windows.Forms.Label();
            nmenderecoLabel = new System.Windows.Forms.Label();
            cdnumeroLabel = new System.Windows.Forms.Label();
            nmbairroLabel = new System.Windows.Forms.Label();
            nmcidadeLabel = new System.Windows.Forms.Label();
            sgestadoLabel = new System.Windows.Forms.Label();
            cdcepLabel = new System.Windows.Forms.Label();
            cdtelefoneLabel = new System.Windows.Forms.Label();
            cdrgLabel = new System.Windows.Forms.Label();
            cdcepLabel1 = new System.Windows.Forms.Label();
            cdcpfLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cdclienteLabel
            // 
            cdclienteLabel.AutoSize = true;
            cdclienteLabel.BackColor = System.Drawing.Color.Transparent;
            cdclienteLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdclienteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdclienteLabel.Location = new System.Drawing.Point(172, 20);
            cdclienteLabel.Name = "cdclienteLabel";
            cdclienteLabel.Size = new System.Drawing.Size(81, 24);
            cdclienteLabel.TabIndex = 1;
            cdclienteLabel.Text = "Código:";
            // 
            // nmclienteLabel
            // 
            nmclienteLabel.AutoSize = true;
            nmclienteLabel.BackColor = System.Drawing.Color.Transparent;
            nmclienteLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmclienteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nmclienteLabel.Location = new System.Drawing.Point(384, 20);
            nmclienteLabel.Name = "nmclienteLabel";
            nmclienteLabel.Size = new System.Drawing.Size(70, 24);
            nmclienteLabel.TabIndex = 3;
            nmclienteLabel.Text = "Nome:";
            // 
            // nmenderecoLabel
            // 
            nmenderecoLabel.AutoSize = true;
            nmenderecoLabel.BackColor = System.Drawing.Color.Transparent;
            nmenderecoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmenderecoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nmenderecoLabel.Location = new System.Drawing.Point(172, 59);
            nmenderecoLabel.Name = "nmenderecoLabel";
            nmenderecoLabel.Size = new System.Drawing.Size(102, 24);
            nmenderecoLabel.TabIndex = 5;
            nmenderecoLabel.Text = "Endereço:";
            // 
            // cdnumeroLabel
            // 
            cdnumeroLabel.AutoSize = true;
            cdnumeroLabel.BackColor = System.Drawing.Color.Transparent;
            cdnumeroLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdnumeroLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdnumeroLabel.Location = new System.Drawing.Point(172, 94);
            cdnumeroLabel.Name = "cdnumeroLabel";
            cdnumeroLabel.Size = new System.Drawing.Size(89, 24);
            cdnumeroLabel.TabIndex = 7;
            cdnumeroLabel.Text = "Número:";
            // 
            // nmbairroLabel
            // 
            nmbairroLabel.AutoSize = true;
            nmbairroLabel.BackColor = System.Drawing.Color.Transparent;
            nmbairroLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmbairroLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nmbairroLabel.Location = new System.Drawing.Point(360, 94);
            nmbairroLabel.Name = "nmbairroLabel";
            nmbairroLabel.Size = new System.Drawing.Size(75, 24);
            nmbairroLabel.TabIndex = 9;
            nmbairroLabel.Text = "Bairro:";
            // 
            // nmcidadeLabel
            // 
            nmcidadeLabel.AutoSize = true;
            nmcidadeLabel.BackColor = System.Drawing.Color.Transparent;
            nmcidadeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmcidadeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nmcidadeLabel.Location = new System.Drawing.Point(172, 131);
            nmcidadeLabel.Name = "nmcidadeLabel";
            nmcidadeLabel.Size = new System.Drawing.Size(80, 24);
            nmcidadeLabel.TabIndex = 11;
            nmcidadeLabel.Text = "Cidade:";
            // 
            // sgestadoLabel
            // 
            sgestadoLabel.AutoSize = true;
            sgestadoLabel.BackColor = System.Drawing.Color.Transparent;
            sgestadoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgestadoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            sgestadoLabel.Location = new System.Drawing.Point(172, 171);
            sgestadoLabel.Name = "sgestadoLabel";
            sgestadoLabel.Size = new System.Drawing.Size(79, 24);
            sgestadoLabel.TabIndex = 13;
            sgestadoLabel.Text = "Estado:";
            // 
            // cdcepLabel
            // 
            cdcepLabel.AutoSize = true;
            cdcepLabel.BackColor = System.Drawing.Color.Transparent;
            cdcepLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdcepLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdcepLabel.Location = new System.Drawing.Point(23, 252);
            cdcepLabel.Name = "cdcepLabel";
            cdcepLabel.Size = new System.Drawing.Size(0, 23);
            cdcepLabel.TabIndex = 15;
            // 
            // cdtelefoneLabel
            // 
            cdtelefoneLabel.AutoSize = true;
            cdtelefoneLabel.BackColor = System.Drawing.Color.Transparent;
            cdtelefoneLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdtelefoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdtelefoneLabel.Location = new System.Drawing.Point(172, 207);
            cdtelefoneLabel.Name = "cdtelefoneLabel";
            cdtelefoneLabel.Size = new System.Drawing.Size(92, 24);
            cdtelefoneLabel.TabIndex = 17;
            cdtelefoneLabel.Text = "Telefone:";
            // 
            // cdrgLabel
            // 
            cdrgLabel.AutoSize = true;
            cdrgLabel.BackColor = System.Drawing.Color.Transparent;
            cdrgLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdrgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdrgLabel.Location = new System.Drawing.Point(373, 239);
            cdrgLabel.Name = "cdrgLabel";
            cdrgLabel.Size = new System.Drawing.Size(48, 24);
            cdrgLabel.TabIndex = 21;
            cdrgLabel.Text = "RG:";
            // 
            // cdcepLabel1
            // 
            cdcepLabel1.AutoSize = true;
            cdcepLabel1.BackColor = System.Drawing.Color.Transparent;
            cdcepLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdcepLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdcepLabel1.Location = new System.Drawing.Point(491, 131);
            cdcepLabel1.Name = "cdcepLabel1";
            cdcepLabel1.Size = new System.Drawing.Size(60, 24);
            cdcepLabel1.TabIndex = 32;
            cdcepLabel1.Text = "CEP:";
            // 
            // cdcpfLabel1
            // 
            cdcpfLabel1.AutoSize = true;
            cdcpfLabel1.BackColor = System.Drawing.Color.Transparent;
            cdcpfLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdcpfLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdcpfLabel1.Location = new System.Drawing.Point(172, 239);
            cdcpfLabel1.Name = "cdcpfLabel1";
            cdcpfLabel1.Size = new System.Drawing.Size(60, 24);
            cdcpfLabel1.TabIndex = 33;
            cdcpfLabel1.Text = "CPF:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBD2.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cdclienteTextBox
            // 
            this.cdclienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdcliente", true));
            this.cdclienteTextBox.Location = new System.Drawing.Point(268, 20);
            this.cdclienteTextBox.Name = "cdclienteTextBox";
            this.cdclienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.cdclienteTextBox.TabIndex = 2;
            this.cdclienteTextBox.TextChanged += new System.EventHandler(this.cdclienteTextBox_TextChanged);
            // 
            // nmclienteTextBox
            // 
            this.nmclienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmcliente", true));
            this.nmclienteTextBox.Location = new System.Drawing.Point(451, 20);
            this.nmclienteTextBox.Name = "nmclienteTextBox";
            this.nmclienteTextBox.Size = new System.Drawing.Size(319, 20);
            this.nmclienteTextBox.TabIndex = 4;
            this.nmclienteTextBox.TextChanged += new System.EventHandler(this.nmclienteTextBox_TextChanged);
            // 
            // nmenderecoTextBox
            // 
            this.nmenderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmendereco", true));
            this.nmenderecoTextBox.Location = new System.Drawing.Point(296, 62);
            this.nmenderecoTextBox.Name = "nmenderecoTextBox";
            this.nmenderecoTextBox.Size = new System.Drawing.Size(334, 20);
            this.nmenderecoTextBox.TabIndex = 6;
            this.nmenderecoTextBox.TextChanged += new System.EventHandler(this.nmenderecoTextBox_TextChanged);
            // 
            // cdnumeroTextBox
            // 
            this.cdnumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdnumero", true));
            this.cdnumeroTextBox.Location = new System.Drawing.Point(268, 97);
            this.cdnumeroTextBox.Name = "cdnumeroTextBox";
            this.cdnumeroTextBox.Size = new System.Drawing.Size(86, 20);
            this.cdnumeroTextBox.TabIndex = 8;
            this.cdnumeroTextBox.TextChanged += new System.EventHandler(this.cdnumeroTextBox_TextChanged);
            // 
            // nmbairroTextBox
            // 
            this.nmbairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmbairro", true));
            this.nmbairroTextBox.Location = new System.Drawing.Point(460, 97);
            this.nmbairroTextBox.Name = "nmbairroTextBox";
            this.nmbairroTextBox.Size = new System.Drawing.Size(259, 20);
            this.nmbairroTextBox.TabIndex = 10;
            this.nmbairroTextBox.TextChanged += new System.EventHandler(this.nmbairroTextBox_TextChanged);
            // 
            // nmcidadeTextBox
            // 
            this.nmcidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nmcidade", true));
            this.nmcidadeTextBox.Location = new System.Drawing.Point(268, 134);
            this.nmcidadeTextBox.Name = "nmcidadeTextBox";
            this.nmcidadeTextBox.Size = new System.Drawing.Size(207, 20);
            this.nmcidadeTextBox.TabIndex = 12;
            this.nmcidadeTextBox.TextChanged += new System.EventHandler(this.nmcidadeTextBox_TextChanged);
            // 
            // sgestadoTextBox
            // 
            this.sgestadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "sgestado", true));
            this.sgestadoTextBox.Location = new System.Drawing.Point(279, 174);
            this.sgestadoTextBox.Name = "sgestadoTextBox";
            this.sgestadoTextBox.Size = new System.Drawing.Size(196, 20);
            this.sgestadoTextBox.TabIndex = 14;
            this.sgestadoTextBox.TextChanged += new System.EventHandler(this.sgestadoTextBox_TextChanged);
            // 
            // cdtelefoneTextBox
            // 
            this.cdtelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdtelefone", true));
            this.cdtelefoneTextBox.Location = new System.Drawing.Point(305, 210);
            this.cdtelefoneTextBox.Name = "cdtelefoneTextBox";
            this.cdtelefoneTextBox.Size = new System.Drawing.Size(204, 20);
            this.cdtelefoneTextBox.TabIndex = 18;
            this.cdtelefoneTextBox.TextChanged += new System.EventHandler(this.cdtelefoneTextBox_TextChanged);
            // 
            // cdrgTextBox
            // 
            this.cdrgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdrg", true));
            this.cdrgTextBox.Location = new System.Drawing.Point(428, 242);
            this.cdrgTextBox.Name = "cdrgTextBox";
            this.cdrgTextBox.Size = new System.Drawing.Size(207, 20);
            this.cdrgTextBox.TabIndex = 22;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(422, 456);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 34);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImprimir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(292, 456);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 34);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPesquisar.BackgroundImage = global::ProjetoBD2.Properties.Resources.kisspng_vaporwave_statue_aesthetics_internet_art_sculpture_vaporwave_5b1170d198bc42_7976662415278696496256;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(552, 378);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 111);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(162, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 34);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Location = new System.Drawing.Point(422, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 34);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(292, 417);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 34);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAlterar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterar.Location = new System.Drawing.Point(162, 417);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 34);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNovo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(422, 378);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 34);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnProximo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProximo.Location = new System.Drawing.Point(292, 378);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(124, 34);
            this.btnProximo.TabIndex = 24;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAnterior.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnterior.Location = new System.Drawing.Point(162, 378);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(124, 34);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cdcepMaskedTextBox
            // 
            this.cdcepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdcep", true));
            this.cdcepMaskedTextBox.Location = new System.Drawing.Point(552, 134);
            this.cdcepMaskedTextBox.Mask = "00000-00";
            this.cdcepMaskedTextBox.Name = "cdcepMaskedTextBox";
            this.cdcepMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.cdcepMaskedTextBox.TabIndex = 33;
            // 
            // cdcpfMaskedTextBox
            // 
            this.cdcpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdcpf", true));
            this.cdcpfMaskedTextBox.Location = new System.Drawing.Point(240, 242);
            this.cdcpfMaskedTextBox.Mask = "000,000,000-00";
            this.cdcpfMaskedTextBox.Name = "cdcpfMaskedTextBox";
            this.cdcpfMaskedTextBox.Size = new System.Drawing.Size(123, 20);
            this.cdcpfMaskedTextBox.TabIndex = 34;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.BackgroundImage = global::ProjetoBD2.Properties.Resources.kisspng_nokia_611_navigator_nokia_321_nokia_asha_3_2_aesthetic_vaporwave_tumblr_cellphone_5b7c10c88c31c6_0707198715348574165742;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 558);
            this.Controls.Add(cdcpfLabel1);
            this.Controls.Add(this.cdcpfMaskedTextBox);
            this.Controls.Add(cdcepLabel1);
            this.Controls.Add(this.cdcepMaskedTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cdclienteLabel);
            this.Controls.Add(this.cdclienteTextBox);
            this.Controls.Add(nmclienteLabel);
            this.Controls.Add(this.nmclienteTextBox);
            this.Controls.Add(nmenderecoLabel);
            this.Controls.Add(this.nmenderecoTextBox);
            this.Controls.Add(cdnumeroLabel);
            this.Controls.Add(this.cdnumeroTextBox);
            this.Controls.Add(nmbairroLabel);
            this.Controls.Add(this.nmbairroTextBox);
            this.Controls.Add(nmcidadeLabel);
            this.Controls.Add(this.nmcidadeTextBox);
            this.Controls.Add(sgestadoLabel);
            this.Controls.Add(this.sgestadoTextBox);
            this.Controls.Add(cdcepLabel);
            this.Controls.Add(cdtelefoneLabel);
            this.Controls.Add(this.cdtelefoneTextBox);
            this.Controls.Add(cdrgLabel);
            this.Controls.Add(this.cdrgTextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private CadastroDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cdclienteTextBox;
        private System.Windows.Forms.TextBox nmclienteTextBox;
        private System.Windows.Forms.TextBox nmenderecoTextBox;
        private System.Windows.Forms.TextBox cdnumeroTextBox;
        private System.Windows.Forms.TextBox nmbairroTextBox;
        private System.Windows.Forms.TextBox nmcidadeTextBox;
        private System.Windows.Forms.TextBox sgestadoTextBox;
        private System.Windows.Forms.TextBox cdtelefoneTextBox;
        private System.Windows.Forms.TextBox cdrgTextBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.MaskedTextBox cdcepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cdcpfMaskedTextBox;
    }
}