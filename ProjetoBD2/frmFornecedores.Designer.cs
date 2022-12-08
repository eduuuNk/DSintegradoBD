
namespace ProjetoBD2
{
    partial class frmFornecedores
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
            System.Windows.Forms.Label cdfornecedorLabel;
            System.Windows.Forms.Label nmfornecedorLabel;
            System.Windows.Forms.Label nmenderecoLabel;
            System.Windows.Forms.Label cdnumeroLabel;
            System.Windows.Forms.Label nmbairroLabel;
            System.Windows.Forms.Label nmcidadeLabel;
            System.Windows.Forms.Label sgestadoLabel;
            System.Windows.Forms.Label cdtelefoneLabel;
            System.Windows.Forms.Label cdieLabel;
            System.Windows.Forms.Label cdcnpjLabel1;
            System.Windows.Forms.Label cdcepLabel1;
            this.cadastroDataSet = new ProjetoBD2.CadastroDataSet();
            this.tbFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFornecedorTableAdapter = new ProjetoBD2.CadastroDataSetTableAdapters.tbFornecedorTableAdapter();
            this.tableAdapterManager = new ProjetoBD2.CadastroDataSetTableAdapters.TableAdapterManager();
            this.cdfornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nmfornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nmenderecoTextBox = new System.Windows.Forms.TextBox();
            this.cdnumeroTextBox = new System.Windows.Forms.TextBox();
            this.nmbairroTextBox = new System.Windows.Forms.TextBox();
            this.nmcidadeTextBox = new System.Windows.Forms.TextBox();
            this.sgestadoTextBox = new System.Windows.Forms.TextBox();
            this.cdtelefoneTextBox = new System.Windows.Forms.TextBox();
            this.cdieTextBox = new System.Windows.Forms.TextBox();
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
            this.cdcnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cdcepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cdfornecedorLabel = new System.Windows.Forms.Label();
            nmfornecedorLabel = new System.Windows.Forms.Label();
            nmenderecoLabel = new System.Windows.Forms.Label();
            cdnumeroLabel = new System.Windows.Forms.Label();
            nmbairroLabel = new System.Windows.Forms.Label();
            nmcidadeLabel = new System.Windows.Forms.Label();
            sgestadoLabel = new System.Windows.Forms.Label();
            cdtelefoneLabel = new System.Windows.Forms.Label();
            cdieLabel = new System.Windows.Forms.Label();
            cdcnpjLabel1 = new System.Windows.Forms.Label();
            cdcepLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cdfornecedorLabel
            // 
            cdfornecedorLabel.AutoSize = true;
            cdfornecedorLabel.BackColor = System.Drawing.Color.Transparent;
            cdfornecedorLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdfornecedorLabel.ForeColor = System.Drawing.Color.White;
            cdfornecedorLabel.Location = new System.Drawing.Point(23, 9);
            cdfornecedorLabel.Name = "cdfornecedorLabel";
            cdfornecedorLabel.Size = new System.Drawing.Size(81, 24);
            cdfornecedorLabel.TabIndex = 1;
            cdfornecedorLabel.Text = "Código:";
            // 
            // nmfornecedorLabel
            // 
            nmfornecedorLabel.AutoSize = true;
            nmfornecedorLabel.BackColor = System.Drawing.Color.Transparent;
            nmfornecedorLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmfornecedorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nmfornecedorLabel.Location = new System.Drawing.Point(192, 9);
            nmfornecedorLabel.Name = "nmfornecedorLabel";
            nmfornecedorLabel.Size = new System.Drawing.Size(70, 24);
            nmfornecedorLabel.TabIndex = 3;
            nmfornecedorLabel.Text = "Nome:";
            // 
            // nmenderecoLabel
            // 
            nmenderecoLabel.AutoSize = true;
            nmenderecoLabel.BackColor = System.Drawing.Color.Transparent;
            nmenderecoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmenderecoLabel.ForeColor = System.Drawing.Color.White;
            nmenderecoLabel.Location = new System.Drawing.Point(23, 47);
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
            cdnumeroLabel.ForeColor = System.Drawing.Color.White;
            cdnumeroLabel.Location = new System.Drawing.Point(23, 82);
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
            nmbairroLabel.ForeColor = System.Drawing.Color.White;
            nmbairroLabel.Location = new System.Drawing.Point(23, 115);
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
            nmcidadeLabel.ForeColor = System.Drawing.Color.White;
            nmcidadeLabel.Location = new System.Drawing.Point(23, 152);
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
            sgestadoLabel.ForeColor = System.Drawing.Color.White;
            sgestadoLabel.Location = new System.Drawing.Point(23, 187);
            sgestadoLabel.Name = "sgestadoLabel";
            sgestadoLabel.Size = new System.Drawing.Size(79, 24);
            sgestadoLabel.TabIndex = 13;
            sgestadoLabel.Text = "Estado:";
            // 
            // cdtelefoneLabel
            // 
            cdtelefoneLabel.AutoSize = true;
            cdtelefoneLabel.BackColor = System.Drawing.Color.Transparent;
            cdtelefoneLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdtelefoneLabel.ForeColor = System.Drawing.Color.White;
            cdtelefoneLabel.Location = new System.Drawing.Point(23, 224);
            cdtelefoneLabel.Name = "cdtelefoneLabel";
            cdtelefoneLabel.Size = new System.Drawing.Size(92, 24);
            cdtelefoneLabel.TabIndex = 17;
            cdtelefoneLabel.Text = "Telefone:";
            // 
            // cdieLabel
            // 
            cdieLabel.AutoSize = true;
            cdieLabel.BackColor = System.Drawing.Color.Transparent;
            cdieLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdieLabel.ForeColor = System.Drawing.Color.White;
            cdieLabel.Location = new System.Drawing.Point(23, 256);
            cdieLabel.Name = "cdieLabel";
            cdieLabel.Size = new System.Drawing.Size(38, 24);
            cdieLabel.TabIndex = 21;
            cdieLabel.Text = "IE:";
            // 
            // cdcnpjLabel1
            // 
            cdcnpjLabel1.AutoSize = true;
            cdcnpjLabel1.BackColor = System.Drawing.Color.Transparent;
            cdcnpjLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdcnpjLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdcnpjLabel1.Location = new System.Drawing.Point(353, 227);
            cdcnpjLabel1.Name = "cdcnpjLabel1";
            cdcnpjLabel1.Size = new System.Drawing.Size(72, 24);
            cdcnpjLabel1.TabIndex = 32;
            cdcnpjLabel1.Text = "CNPJ:";
            // 
            // cdcepLabel1
            // 
            cdcepLabel1.AutoSize = true;
            cdcepLabel1.BackColor = System.Drawing.Color.Transparent;
            cdcepLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdcepLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cdcepLabel1.Location = new System.Drawing.Point(353, 155);
            cdcepLabel1.Name = "cdcepLabel1";
            cdcepLabel1.Size = new System.Drawing.Size(60, 24);
            cdcepLabel1.TabIndex = 34;
            cdcepLabel1.Text = "CEP:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFornecedorBindingSource
            // 
            this.tbFornecedorBindingSource.DataMember = "tbFornecedor";
            this.tbFornecedorBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbFornecedorTableAdapter
            // 
            this.tbFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = this.tbFornecedorTableAdapter;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBD2.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cdfornecedorTextBox
            // 
            this.cdfornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cdfornecedor", true));
            this.cdfornecedorTextBox.Location = new System.Drawing.Point(117, 12);
            this.cdfornecedorTextBox.Name = "cdfornecedorTextBox";
            this.cdfornecedorTextBox.Size = new System.Drawing.Size(54, 20);
            this.cdfornecedorTextBox.TabIndex = 2;
            // 
            // nmfornecedorTextBox
            // 
            this.nmfornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nmfornecedor", true));
            this.nmfornecedorTextBox.Location = new System.Drawing.Point(263, 12);
            this.nmfornecedorTextBox.Name = "nmfornecedorTextBox";
            this.nmfornecedorTextBox.Size = new System.Drawing.Size(275, 20);
            this.nmfornecedorTextBox.TabIndex = 4;
            // 
            // nmenderecoTextBox
            // 
            this.nmenderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nmendereco", true));
            this.nmenderecoTextBox.Location = new System.Drawing.Point(156, 50);
            this.nmenderecoTextBox.Name = "nmenderecoTextBox";
            this.nmenderecoTextBox.Size = new System.Drawing.Size(382, 20);
            this.nmenderecoTextBox.TabIndex = 6;
            // 
            // cdnumeroTextBox
            // 
            this.cdnumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cdnumero", true));
            this.cdnumeroTextBox.Location = new System.Drawing.Point(130, 82);
            this.cdnumeroTextBox.Name = "cdnumeroTextBox";
            this.cdnumeroTextBox.Size = new System.Drawing.Size(85, 20);
            this.cdnumeroTextBox.TabIndex = 8;
            // 
            // nmbairroTextBox
            // 
            this.nmbairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nmbairro", true));
            this.nmbairroTextBox.Location = new System.Drawing.Point(130, 118);
            this.nmbairroTextBox.Name = "nmbairroTextBox";
            this.nmbairroTextBox.Size = new System.Drawing.Size(408, 20);
            this.nmbairroTextBox.TabIndex = 10;
            // 
            // nmcidadeTextBox
            // 
            this.nmcidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nmcidade", true));
            this.nmcidadeTextBox.Location = new System.Drawing.Point(130, 155);
            this.nmcidadeTextBox.Name = "nmcidadeTextBox";
            this.nmcidadeTextBox.Size = new System.Drawing.Size(213, 20);
            this.nmcidadeTextBox.TabIndex = 12;
            // 
            // sgestadoTextBox
            // 
            this.sgestadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "sgestado", true));
            this.sgestadoTextBox.Location = new System.Drawing.Point(130, 190);
            this.sgestadoTextBox.Name = "sgestadoTextBox";
            this.sgestadoTextBox.Size = new System.Drawing.Size(213, 20);
            this.sgestadoTextBox.TabIndex = 14;
            // 
            // cdtelefoneTextBox
            // 
            this.cdtelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cdtelefone", true));
            this.cdtelefoneTextBox.Location = new System.Drawing.Point(156, 227);
            this.cdtelefoneTextBox.Name = "cdtelefoneTextBox";
            this.cdtelefoneTextBox.Size = new System.Drawing.Size(187, 20);
            this.cdtelefoneTextBox.TabIndex = 18;
            this.cdtelefoneTextBox.TextChanged += new System.EventHandler(this.cdtelefoneTextBox_TextChanged);
            // 
            // cdieTextBox
            // 
            this.cdieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cdie", true));
            this.cdieTextBox.Location = new System.Drawing.Point(78, 259);
            this.cdieTextBox.Name = "cdieTextBox";
            this.cdieTextBox.Size = new System.Drawing.Size(181, 20);
            this.cdieTextBox.TabIndex = 22;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(381, 474);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 34);
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
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.Location = new System.Drawing.Point(251, 474);
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
            this.btnPesquisar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Location = new System.Drawing.Point(515, 396);
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
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(120, 474);
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
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(380, 435);
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
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(251, 435);
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
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Location = new System.Drawing.Point(121, 435);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 34);
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
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Location = new System.Drawing.Point(380, 396);
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
            this.btnProximo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProximo.Location = new System.Drawing.Point(251, 396);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(123, 34);
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
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.Location = new System.Drawing.Point(121, 396);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(124, 34);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cdcnpjMaskedTextBox
            // 
            this.cdcnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cdcnpj", true));
            this.cdcnpjMaskedTextBox.Location = new System.Drawing.Point(422, 227);
            this.cdcnpjMaskedTextBox.Mask = "000,000,000-00";
            this.cdcnpjMaskedTextBox.Name = "cdcnpjMaskedTextBox";
            this.cdcnpjMaskedTextBox.Size = new System.Drawing.Size(116, 20);
            this.cdcnpjMaskedTextBox.TabIndex = 33;
            // 
            // cdcepMaskedTextBox
            // 
            this.cdcepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cdcep", true));
            this.cdcepMaskedTextBox.Location = new System.Drawing.Point(421, 152);
            this.cdcepMaskedTextBox.Mask = "00000-00";
            this.cdcepMaskedTextBox.Name = "cdcepMaskedTextBox";
            this.cdcepMaskedTextBox.Size = new System.Drawing.Size(117, 20);
            this.cdcepMaskedTextBox.TabIndex = 35;
            this.cdcepMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cdcepMaskedTextBox_MaskInputRejected);
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.BackgroundImage = global::ProjetoBD2.Properties.Resources.kisspng_aesthetics_vaporwave_iphone_vaporwave_aesthetic_5b4c49fd37d6d6_1250041415317263332287;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(cdcepLabel1);
            this.Controls.Add(this.cdcepMaskedTextBox);
            this.Controls.Add(cdcnpjLabel1);
            this.Controls.Add(this.cdcnpjMaskedTextBox);
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
            this.Controls.Add(cdfornecedorLabel);
            this.Controls.Add(this.cdfornecedorTextBox);
            this.Controls.Add(nmfornecedorLabel);
            this.Controls.Add(this.nmfornecedorTextBox);
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
            this.Controls.Add(cdtelefoneLabel);
            this.Controls.Add(this.cdtelefoneTextBox);
            this.Controls.Add(cdieLabel);
            this.Controls.Add(this.cdieTextBox);
            this.DoubleBuffered = true;
            this.Name = "frmFornecedores";
            this.Text = "frmFornecedores";
            this.Load += new System.EventHandler(this.frmFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbFornecedorBindingSource;
        private CadastroDataSetTableAdapters.tbFornecedorTableAdapter tbFornecedorTableAdapter;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cdfornecedorTextBox;
        private System.Windows.Forms.TextBox nmfornecedorTextBox;
        private System.Windows.Forms.TextBox nmenderecoTextBox;
        private System.Windows.Forms.TextBox cdnumeroTextBox;
        private System.Windows.Forms.TextBox nmbairroTextBox;
        private System.Windows.Forms.TextBox nmcidadeTextBox;
        private System.Windows.Forms.TextBox sgestadoTextBox;
        private System.Windows.Forms.TextBox cdtelefoneTextBox;
        private System.Windows.Forms.TextBox cdieTextBox;
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
        private System.Windows.Forms.MaskedTextBox cdcnpjMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cdcepMaskedTextBox;
    }
}