﻿namespace Farmacia
{
    partial class frmFabricante
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
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrvar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvFabricante = new System.Windows.Forms.DataGridView();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.White;
            this.btnPesquisa.Image = global::Farmacia.Properties.Resources.Gakuseisean_Ivista_2_Start_Menu_Search;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisa.Location = new System.Drawing.Point(394, 3);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(64, 52);
            this.btnPesquisa.TabIndex = 41;
            this.btnPesquisa.Text = "&Pesquisa";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Image = global::Farmacia.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Delete;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(329, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 52);
            this.btnLimpar.TabIndex = 40;
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
            this.btnCancelar.Location = new System.Drawing.Point(264, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 52);
            this.btnCancelar.TabIndex = 38;
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
            this.btnGrvar.Location = new System.Drawing.Point(199, 3);
            this.btnGrvar.Name = "btnGrvar";
            this.btnGrvar.Size = new System.Drawing.Size(64, 52);
            this.btnGrvar.TabIndex = 37;
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
            this.btnRemover.Location = new System.Drawing.Point(134, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(64, 52);
            this.btnRemover.TabIndex = 36;
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
            this.btnEditar.Location = new System.Drawing.Point(69, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 52);
            this.btnEditar.TabIndex = 35;
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
            this.btnInserir.Location = new System.Drawing.Point(4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 52);
            this.btnInserir.TabIndex = 34;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "UF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Email";
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(7, 114);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(116, 19);
            this.lblId.TabIndex = 52;
            this.lblId.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(493, 20);
            this.txtNome.TabIndex = 53;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(628, 114);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(93, 20);
            this.txtCep.TabIndex = 54;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(5, 187);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(159, 20);
            this.txtCnpj.TabIndex = 55;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(170, 187);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 20);
            this.txtTelefone.TabIndex = 56;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(302, 186);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(274, 20);
            this.txtEndereco.TabIndex = 57;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(582, 186);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(139, 20);
            this.txtBairro.TabIndex = 58;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(7, 252);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(253, 20);
            this.txtCidade.TabIndex = 59;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(267, 252);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(41, 20);
            this.txtUf.TabIndex = 60;
            this.txtUf.Leave += new System.EventHandler(this.txtUf_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(314, 252);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(407, 20);
            this.txtEmail.TabIndex = 61;
            // 
            // dgvFabricante
            // 
            this.dgvFabricante.BackgroundColor = System.Drawing.Color.White;
            this.dgvFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricante.Location = new System.Drawing.Point(5, 320);
            this.dgvFabricante.Name = "dgvFabricante";
            this.dgvFabricante.Size = new System.Drawing.Size(1045, 163);
            this.dgvFabricante.TabIndex = 62;
            this.dgvFabricante.DoubleClick += new System.EventHandler(this.dgvFabricante_DoubleClick);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesquisa.Controls.Add(this.btnFiltrar);
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblPesquisa);
            this.pnlPesquisa.Controls.Add(this.gpbPesquisa);
            this.pnlPesquisa.Location = new System.Drawing.Point(727, 114);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(323, 194);
            this.pnlPesquisa.TabIndex = 63;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(244, 168);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 145);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(304, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.BackColor = System.Drawing.Color.Peru;
            this.lblPesquisa.Location = new System.Drawing.Point(15, 122);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(304, 20);
            this.lblPesquisa.TabIndex = 1;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.BackColor = System.Drawing.Color.SaddleBrown;
            this.gpbPesquisa.Controls.Add(this.rdbNome);
            this.gpbPesquisa.Controls.Add(this.rdbCodigo);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Location = new System.Drawing.Point(15, 16);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(304, 103);
            this.gpbPesquisa.TabIndex = 0;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(7, 68);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(72, 17);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Por Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(7, 44);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 17);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Por Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(7, 20);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // frmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1057, 485);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.dgvFabricante);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrvar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Name = "frmFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fabrincante";
            this.Load += new System.EventHandler(this.frmFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrvar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvFabricante;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}