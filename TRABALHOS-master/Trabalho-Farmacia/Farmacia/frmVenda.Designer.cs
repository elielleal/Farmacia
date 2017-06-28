namespace Farmacia
{
    partial class frmVenda
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
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrvar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtpVenda = new System.Windows.Forms.DateTimePicker();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDevedor = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtComprados = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.cmbVenda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDataSet = new Farmacia.farmaciaDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItemVenda = new System.Windows.Forms.Label();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnInser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGrav = new System.Windows.Forms.Button();
            this.btnRemov = new System.Windows.Forms.Button();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new Farmacia.farmaciaDataSetTableAdapters.VendaTableAdapter();
            this.tableAdapterManager = new Farmacia.farmaciaDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Farmacia.farmaciaDataSetTableAdapters.ClienteTableAdapter();
            this.funcionarioTableAdapter = new Farmacia.farmaciaDataSetTableAdapters.FuncionarioTableAdapter();
            this.itemVendaTableAdapter = new Farmacia.farmaciaDataSetTableAdapters.ItemVendaTableAdapter();
            this.produtoTableAdapter = new Farmacia.farmaciaDataSetTableAdapters.ProdutoTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenda
            // 
            this.pnlVenda.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlVenda.Controls.Add(this.label12);
            this.pnlVenda.Controls.Add(this.label11);
            this.pnlVenda.Controls.Add(this.btnLimpar);
            this.pnlVenda.Controls.Add(this.btnCancelar);
            this.pnlVenda.Controls.Add(this.btnGrvar);
            this.pnlVenda.Controls.Add(this.btnRemover);
            this.pnlVenda.Controls.Add(this.btnEditar);
            this.pnlVenda.Controls.Add(this.btnInserir);
            this.pnlVenda.Controls.Add(this.label9);
            this.pnlVenda.Controls.Add(this.label8);
            this.pnlVenda.Controls.Add(this.label7);
            this.pnlVenda.Controls.Add(this.dtpPagamento);
            this.pnlVenda.Controls.Add(this.dtpVencimento);
            this.pnlVenda.Controls.Add(this.dtpVenda);
            this.pnlVenda.Controls.Add(this.cmbFuncionario);
            this.pnlVenda.Controls.Add(this.label4);
            this.pnlVenda.Controls.Add(this.txtIdFuncionario);
            this.pnlVenda.Controls.Add(this.cmbCliente);
            this.pnlVenda.Controls.Add(this.lbl);
            this.pnlVenda.Controls.Add(this.txtIdCliente);
            this.pnlVenda.Controls.Add(this.lblIdVenda);
            this.pnlVenda.Controls.Add(this.label1);
            this.pnlVenda.Controls.Add(this.dgvVenda);
            this.pnlVenda.Location = new System.Drawing.Point(12, 12);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(1015, 386);
            this.pnlVenda.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(653, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Nome do Funcionário";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Nome do Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Image = global::Farmacia.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Delete;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(870, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 52);
            this.btnLimpar.TabIndex = 62;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Farmacia.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(806, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 52);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrvar
            // 
            this.btnGrvar.BackColor = System.Drawing.Color.White;
            this.btnGrvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrvar.Image = global::Farmacia.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save;
            this.btnGrvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrvar.Location = new System.Drawing.Point(742, 3);
            this.btnGrvar.Name = "btnGrvar";
            this.btnGrvar.Size = new System.Drawing.Size(64, 52);
            this.btnGrvar.TabIndex = 59;
            this.btnGrvar.Text = "&Gravar";
            this.btnGrvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrvar.UseVisualStyleBackColor = false;
            this.btnGrvar.Click += new System.EventHandler(this.btnGrvar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Image = global::Farmacia.Properties.Resources.Creative_Freedom_Shimmer_Document_Delete;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.Location = new System.Drawing.Point(678, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(64, 52);
            this.btnRemover.TabIndex = 58;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Farmacia.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(614, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 52);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = global::Farmacia.Properties.Resources.Creative_Freedom_Shimmer_Document_Add;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(550, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 52);
            this.btnInserir.TabIndex = 56;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Data da Venda";
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Location = new System.Drawing.Point(658, 164);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(254, 20);
            this.dtpPagamento.TabIndex = 52;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Location = new System.Drawing.Point(388, 164);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(256, 20);
            this.dtpVencimento.TabIndex = 51;
            // 
            // dtpVenda
            // 
            this.dtpVenda.Location = new System.Drawing.Point(102, 164);
            this.dtpVenda.Name = "dtpVenda";
            this.dtpVenda.Size = new System.Drawing.Size(272, 20);
            this.dtpVenda.TabIndex = 50;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(648, 97);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(353, 21);
            this.cmbFuncionario.TabIndex = 48;
            this.cmbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionario_SelectedIndexChanged);
            this.cmbFuncionario.Leave += new System.EventHandler(this.cmbFuncionario_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "ID Funcionario";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Location = new System.Drawing.Point(542, 97);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtIdFuncionario.TabIndex = 46;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(121, 97);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(415, 21);
            this.cmbCliente.TabIndex = 44;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 82);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 13);
            this.lbl.TabIndex = 43;
            this.lbl.Text = "ID Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(15, 98);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 42;
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.BackColor = System.Drawing.Color.White;
            this.lblIdVenda.Location = new System.Drawing.Point(15, 48);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(100, 23);
            this.lblIdVenda.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID";
            // 
            // dgvVenda
            // 
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(15, 233);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(986, 150);
            this.dgvVenda.TabIndex = 39;
            this.dgvVenda.DoubleClick += new System.EventHandler(this.dgvVenda_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtDevedor);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.txtComprados);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cmbQuantidade);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtValorTotal);
            this.panel2.Controls.Add(this.cmbVenda);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtValorUnitario);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.cmbProduto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdProduto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblItemVenda);
            this.panel2.Controls.Add(this.dgvItemVenda);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnLimp);
            this.panel2.Controls.Add(this.btnInser);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnGrav);
            this.panel2.Controls.Add(this.btnRemov);
            this.panel2.Location = new System.Drawing.Point(12, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 331);
            this.panel2.TabIndex = 40;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(806, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "Cliente Devendo";
            // 
            // txtDevedor
            // 
            this.txtDevedor.BackColor = System.Drawing.Color.White;
            this.txtDevedor.Location = new System.Drawing.Point(898, 148);
            this.txtDevedor.Name = "txtDevedor";
            this.txtDevedor.Size = new System.Drawing.Size(100, 23);
            this.txtDevedor.TabIndex = 66;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Enabled = false;
            this.label.Location = new System.Drawing.Point(608, 158);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 13);
            this.label.TabIndex = 65;
            this.label.Text = "Qtde Comprados";
            // 
            // txtComprados
            // 
            this.txtComprados.BackColor = System.Drawing.Color.White;
            this.txtComprados.Enabled = false;
            this.txtComprados.Location = new System.Drawing.Point(700, 148);
            this.txtComprados.Name = "txtComprados";
            this.txtComprados.Size = new System.Drawing.Size(100, 23);
            this.txtComprados.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "Qtde Comprar";
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Location = new System.Drawing.Point(18, 148);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(121, 21);
            this.cmbQuantidade.TabIndex = 62;
            this.cmbQuantidade.SelectedIndexChanged += new System.EventHandler(this.cmbQuantidade_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Total a Pagar";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(224, 148);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 60;
            // 
            // cmbVenda
            // 
            this.cmbVenda.FormattingEnabled = true;
            this.cmbVenda.Location = new System.Drawing.Point(18, 97);
            this.cmbVenda.Name = "cmbVenda";
            this.cmbVenda.Size = new System.Drawing.Size(97, 21);
            this.cmbVenda.TabIndex = 56;
            this.cmbVenda.SelectedIndexChanged += new System.EventHandler(this.cmbVenda_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Valor Unitario";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valorUnitario", true));
            this.txtValorUnitario.Location = new System.Drawing.Point(716, 98);
            this.txtValorUnitario.Multiline = true;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(145, 20);
            this.txtValorUnitario.TabIndex = 58;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.farmaciaDataSet;
            // 
            // farmaciaDataSet
            // 
            this.farmaciaDataSet.DataSetName = "farmaciaDataSet";
            this.farmaciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Qtde Estoque";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(407, 149);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 56;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(227, 97);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(471, 21);
            this.cmbProduto.TabIndex = 55;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "ID Produto";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(121, 98);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduto.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "ID Venda";
            // 
            // lblItemVenda
            // 
            this.lblItemVenda.BackColor = System.Drawing.Color.White;
            this.lblItemVenda.Location = new System.Drawing.Point(15, 44);
            this.lblItemVenda.Name = "lblItemVenda";
            this.lblItemVenda.Size = new System.Drawing.Size(100, 23);
            this.lblItemVenda.TabIndex = 50;
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.AutoGenerateColumns = false;
            this.dgvItemVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vendaDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.ValorFinal});
            this.dgvItemVenda.DataSource = this.itemVendaBindingSource;
            this.dgvItemVenda.Location = new System.Drawing.Point(15, 175);
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.Size = new System.Drawing.Size(986, 150);
            this.dgvItemVenda.TabIndex = 49;
            this.dgvItemVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemVenda_CellContentClick);
            this.dgvItemVenda.DoubleClick += new System.EventHandler(this.dgvItemVenda_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendaDataGridViewTextBoxColumn
            // 
            this.vendaDataGridViewTextBoxColumn.DataPropertyName = "venda";
            this.vendaDataGridViewTextBoxColumn.HeaderText = "venda";
            this.vendaDataGridViewTextBoxColumn.Name = "vendaDataGridViewTextBoxColumn";
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "valorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "valorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            // 
            // ValorFinal
            // 
            this.ValorFinal.HeaderText = "ValorFinal";
            this.ValorFinal.Name = "ValorFinal";
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataMember = "ItemVenda";
            this.itemVendaBindingSource.DataSource = this.farmaciaDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "ID";
            // 
            // btnLimp
            // 
            this.btnLimp.BackColor = System.Drawing.Color.White;
            this.btnLimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimp.Image = global::Farmacia.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Delete;
            this.btnLimp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimp.Location = new System.Drawing.Point(934, 3);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(64, 52);
            this.btnLimp.TabIndex = 45;
            this.btnLimp.Text = "&Limpar";
            this.btnLimp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimp.UseVisualStyleBackColor = false;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnInser
            // 
            this.btnInser.BackColor = System.Drawing.Color.White;
            this.btnInser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInser.Image = global::Farmacia.Properties.Resources.Creative_Freedom_Shimmer_Document_Add;
            this.btnInser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInser.Location = new System.Drawing.Point(614, 3);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(64, 52);
            this.btnInser.TabIndex = 39;
            this.btnInser.Text = "&Inserir";
            this.btnInser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInser.UseVisualStyleBackColor = false;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::Farmacia.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(870, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 52);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::Farmacia.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(678, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 52);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGrav
            // 
            this.btnGrav.BackColor = System.Drawing.Color.White;
            this.btnGrav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrav.Image = global::Farmacia.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save;
            this.btnGrav.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrav.Location = new System.Drawing.Point(806, 3);
            this.btnGrav.Name = "btnGrav";
            this.btnGrav.Size = new System.Drawing.Size(64, 52);
            this.btnGrav.TabIndex = 42;
            this.btnGrav.Text = "&Gravar";
            this.btnGrav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrav.UseVisualStyleBackColor = false;
            this.btnGrav.Click += new System.EventHandler(this.btnGrav_Click);
            // 
            // btnRemov
            // 
            this.btnRemov.BackColor = System.Drawing.Color.White;
            this.btnRemov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemov.Image = global::Farmacia.Properties.Resources.Creative_Freedom_Shimmer_Document_Delete;
            this.btnRemov.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemov.Location = new System.Drawing.Point(742, 3);
            this.btnRemov.Name = "btnRemov";
            this.btnRemov.Size = new System.Drawing.Size(64, 52);
            this.btnRemov.TabIndex = 41;
            this.btnRemov.Text = "&Remover";
            this.btnRemov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemov.UseVisualStyleBackColor = false;
            this.btnRemov.Click += new System.EventHandler(this.btnRemov_Click);
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.farmaciaDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FabricanteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.HistoricoPagamentoTableAdapter = null;
            this.tableAdapterManager.ItemVendaTableAdapter = this.itemVendaTableAdapter;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Farmacia.farmaciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = this.vendaTableAdapter;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // itemVendaTableAdapter
            // 
            this.itemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.farmaciaDataSet;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.farmaciaDataSet;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1038, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVenda";
            this.Text = "frmVenda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.pnlVenda.ResumeLayout(false);
            this.pnlVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private farmaciaDataSet farmaciaDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private farmaciaDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private farmaciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlVenda;
        private farmaciaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private farmaciaDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.Panel panel2;
        private farmaciaDataSetTableAdapters.ItemVendaTableAdapter itemVendaTableAdapter;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private farmaciaDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGrav;
        private System.Windows.Forms.Button btnRemov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.DateTimePicker dtpVenda;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItemVenda;
        private System.Windows.Forms.ComboBox cmbVenda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrvar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label txtValorTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label txtComprados;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtDevedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFinal;
    }
}