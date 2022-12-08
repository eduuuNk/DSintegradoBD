
namespace ProjetoBD2
{
    partial class frmProdutos
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
            System.Windows.Forms.Label cdprodutoLabel;
            System.Windows.Forms.Label nmprodutoLabel;
            System.Windows.Forms.Label sgunidadeLabel;
            System.Windows.Forms.Label vlcustoLabel;
            System.Windows.Forms.Label vlvendaLabel;
            System.Windows.Forms.Label qtdestoqueLabel;
            this.cadastroDataSet = new ProjetoBD2.CadastroDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new ProjetoBD2.CadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.tableAdapterManager = new ProjetoBD2.CadastroDataSetTableAdapters.TableAdapterManager();
            this.cdprodutoTextBox = new System.Windows.Forms.TextBox();
            this.nmprodutoTextBox = new System.Windows.Forms.TextBox();
            this.sgunidadeTextBox = new System.Windows.Forms.TextBox();
            this.vlcustoTextBox = new System.Windows.Forms.TextBox();
            this.vlvendaTextBox = new System.Windows.Forms.TextBox();
            this.qtdestoqueTextBox = new System.Windows.Forms.TextBox();
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
            cdprodutoLabel = new System.Windows.Forms.Label();
            nmprodutoLabel = new System.Windows.Forms.Label();
            sgunidadeLabel = new System.Windows.Forms.Label();
            vlcustoLabel = new System.Windows.Forms.Label();
            vlvendaLabel = new System.Windows.Forms.Label();
            qtdestoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cdprodutoLabel
            // 
            cdprodutoLabel.AutoSize = true;
            cdprodutoLabel.BackColor = System.Drawing.Color.Transparent;
            cdprodutoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdprodutoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cdprodutoLabel.Location = new System.Drawing.Point(12, 35);
            cdprodutoLabel.Name = "cdprodutoLabel";
            cdprodutoLabel.Size = new System.Drawing.Size(81, 24);
            cdprodutoLabel.TabIndex = 1;
            cdprodutoLabel.Text = "Código:";
            cdprodutoLabel.Click += new System.EventHandler(this.cdprodutoLabel_Click);
            // 
            // nmprodutoLabel
            // 
            nmprodutoLabel.AutoSize = true;
            nmprodutoLabel.BackColor = System.Drawing.Color.Transparent;
            nmprodutoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmprodutoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nmprodutoLabel.Location = new System.Drawing.Point(379, 37);
            nmprodutoLabel.Name = "nmprodutoLabel";
            nmprodutoLabel.Size = new System.Drawing.Size(70, 24);
            nmprodutoLabel.TabIndex = 3;
            nmprodutoLabel.Text = "Nome:";
            nmprodutoLabel.Click += new System.EventHandler(this.nmprodutoLabel_Click);
            // 
            // sgunidadeLabel
            // 
            sgunidadeLabel.AutoSize = true;
            sgunidadeLabel.BackColor = System.Drawing.Color.Transparent;
            sgunidadeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgunidadeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            sgunidadeLabel.Location = new System.Drawing.Point(12, 72);
            sgunidadeLabel.Name = "sgunidadeLabel";
            sgunidadeLabel.Size = new System.Drawing.Size(99, 24);
            sgunidadeLabel.TabIndex = 5;
            sgunidadeLabel.Text = "Unidades:";
            sgunidadeLabel.Click += new System.EventHandler(this.sgunidadeLabel_Click);
            // 
            // vlcustoLabel
            // 
            vlcustoLabel.AutoSize = true;
            vlcustoLabel.BackColor = System.Drawing.Color.Transparent;
            vlcustoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlcustoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            vlcustoLabel.Location = new System.Drawing.Point(12, 108);
            vlcustoLabel.Name = "vlcustoLabel";
            vlcustoLabel.Size = new System.Drawing.Size(122, 24);
            vlcustoLabel.TabIndex = 7;
            vlcustoLabel.Text = "Valor Custo:";
            vlcustoLabel.Click += new System.EventHandler(this.vlcustoLabel_Click);
            // 
            // vlvendaLabel
            // 
            vlvendaLabel.AutoSize = true;
            vlvendaLabel.BackColor = System.Drawing.Color.Transparent;
            vlvendaLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlvendaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            vlvendaLabel.Location = new System.Drawing.Point(12, 143);
            vlvendaLabel.Name = "vlvendaLabel";
            vlvendaLabel.Size = new System.Drawing.Size(126, 24);
            vlvendaLabel.TabIndex = 9;
            vlvendaLabel.Text = "Valor Venda:";
            vlvendaLabel.Click += new System.EventHandler(this.vlvendaLabel_Click);
            // 
            // qtdestoqueLabel
            // 
            qtdestoqueLabel.AutoSize = true;
            qtdestoqueLabel.BackColor = System.Drawing.Color.Transparent;
            qtdestoqueLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtdestoqueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            qtdestoqueLabel.Location = new System.Drawing.Point(12, 178);
            qtdestoqueLabel.Name = "qtdestoqueLabel";
            qtdestoqueLabel.Size = new System.Drawing.Size(226, 24);
            qtdestoqueLabel.TabIndex = 11;
            qtdestoqueLabel.Text = "Quantidade em estoque:";
            qtdestoqueLabel.Click += new System.EventHandler(this.qtdestoqueLabel_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = this.tbProdutoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBD2.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cdprodutoTextBox
            // 
            this.cdprodutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "cdproduto", true));
            this.cdprodutoTextBox.Location = new System.Drawing.Point(110, 38);
            this.cdprodutoTextBox.Name = "cdprodutoTextBox";
            this.cdprodutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cdprodutoTextBox.TabIndex = 2;
            this.cdprodutoTextBox.TextChanged += new System.EventHandler(this.cdprodutoTextBox_TextChanged);
            // 
            // nmprodutoTextBox
            // 
            this.nmprodutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "nmproduto", true));
            this.nmprodutoTextBox.Location = new System.Drawing.Point(458, 40);
            this.nmprodutoTextBox.Name = "nmprodutoTextBox";
            this.nmprodutoTextBox.Size = new System.Drawing.Size(160, 20);
            this.nmprodutoTextBox.TabIndex = 4;
            this.nmprodutoTextBox.TextChanged += new System.EventHandler(this.nmprodutoTextBox_TextChanged);
            // 
            // sgunidadeTextBox
            // 
            this.sgunidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "sgunidade", true));
            this.sgunidadeTextBox.Location = new System.Drawing.Point(133, 75);
            this.sgunidadeTextBox.Name = "sgunidadeTextBox";
            this.sgunidadeTextBox.Size = new System.Drawing.Size(77, 20);
            this.sgunidadeTextBox.TabIndex = 6;
            this.sgunidadeTextBox.TextChanged += new System.EventHandler(this.sgunidadeTextBox_TextChanged);
            // 
            // vlcustoTextBox
            // 
            this.vlcustoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vlcusto", true));
            this.vlcustoTextBox.Location = new System.Drawing.Point(173, 111);
            this.vlcustoTextBox.Name = "vlcustoTextBox";
            this.vlcustoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vlcustoTextBox.TabIndex = 8;
            this.vlcustoTextBox.TextChanged += new System.EventHandler(this.vlcustoTextBox_TextChanged);
            // 
            // vlvendaTextBox
            // 
            this.vlvendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vlvenda", true));
            this.vlvendaTextBox.Location = new System.Drawing.Point(173, 146);
            this.vlvendaTextBox.Name = "vlvendaTextBox";
            this.vlvendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vlvendaTextBox.TabIndex = 10;
            this.vlvendaTextBox.TextChanged += new System.EventHandler(this.vlvendaTextBox_TextChanged);
            // 
            // qtdestoqueTextBox
            // 
            this.qtdestoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "qtdestoque", true));
            this.qtdestoqueTextBox.Location = new System.Drawing.Point(314, 178);
            this.qtdestoqueTextBox.Name = "qtdestoqueTextBox";
            this.qtdestoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtdestoqueTextBox.TabIndex = 12;
            this.qtdestoqueTextBox.TextChanged += new System.EventHandler(this.qtdestoqueTextBox_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.Orange;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(412, 438);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 34);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Orange;
            this.btnImprimir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(282, 438);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 34);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Orange;
            this.btnPesquisar.BackgroundImage = global::ProjetoBD2.Properties.Resources.kisspng_vaporwave_statue_aesthetics_internet_art_sculpture_vaporwave_5b1170d198bc42_7976662415278696496256;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(555, 360);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 111);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Orange;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(152, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 34);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Orange;
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(412, 399);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 34);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.Color.Orange;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(282, 399);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 34);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.Color.Orange;
            this.btnAlterar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(152, 399);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 34);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.Color.Orange;
            this.btnNovo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(412, 360);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 34);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.BackColor = System.Drawing.Color.Orange;
            this.btnProximo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(282, 360);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(124, 34);
            this.btnProximo.TabIndex = 22;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.BackColor = System.Drawing.Color.Orange;
            this.btnAnterior.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(152, 360);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(124, 34);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::ProjetoBD2.Properties.Resources.kisspng_t_shirt_vaporwave_hoodie_computer_icons_vaporwave_png_pic_5ab1ca3ea22b15_8363731015216010866643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 493);
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
            this.Controls.Add(cdprodutoLabel);
            this.Controls.Add(this.cdprodutoTextBox);
            this.Controls.Add(nmprodutoLabel);
            this.Controls.Add(this.nmprodutoTextBox);
            this.Controls.Add(sgunidadeLabel);
            this.Controls.Add(this.sgunidadeTextBox);
            this.Controls.Add(vlcustoLabel);
            this.Controls.Add(this.vlcustoTextBox);
            this.Controls.Add(vlvendaLabel);
            this.Controls.Add(this.vlvendaTextBox);
            this.Controls.Add(qtdestoqueLabel);
            this.Controls.Add(this.qtdestoqueTextBox);
            this.DoubleBuffered = true;
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private CadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cdprodutoTextBox;
        private System.Windows.Forms.TextBox nmprodutoTextBox;
        private System.Windows.Forms.TextBox sgunidadeTextBox;
        private System.Windows.Forms.TextBox vlcustoTextBox;
        private System.Windows.Forms.TextBox vlvendaTextBox;
        private System.Windows.Forms.TextBox qtdestoqueTextBox;
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
    }
}