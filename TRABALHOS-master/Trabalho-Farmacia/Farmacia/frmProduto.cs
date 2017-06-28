using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmProduto : Form
    {
        Camadas.Model.Fornecedor fornecedor = new Camadas.Model.Fornecedor();
        Camadas.Model.Fabricante fabricante = new Camadas.Model.Fabricante();
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitarControlesProduto(bool status)
        {
            dtpData.Enabled = status;
            txtNome.Enabled = status;
            txtDescricao.Enabled = status;
            txtQuantidade.Enabled = status;
            txtValorFinal.Enabled = status;
            txtValorUnit.Enabled = status;

            //botões
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGrvar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void LimpaControlesProduto()
        {
            txtNome.Text = "";
            txtIdForn.Text = "";
            txtIdFrabr.Text = "";
            dtpData.Value = DateTime.Now.Date;
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValorUnit.Text = "";
            txtValorFinal.Text = "";
        }

        private void RecuperarDadosFornecedor()
        {
            Camadas.BLL.Fornecedor bllFornecedor = new Camadas.BLL.Fornecedor();
            List<Camadas.Model.Fornecedor> lstForn = new List<Camadas.Model.Fornecedor>();
            lstForn = bllFornecedor.SelectById(Convert.ToInt32(txtIdForn.Text));
            if (lstForn != null)
                fornecedor = lstForn[0];
            else MessageBox.Show("Fornecedor não encontrado");
            
        }

        private void RecuperarDadosFabricante()
        {
            Camadas.BLL.Fabricante bllFabricante = new Camadas.BLL.Fabricante();
            List<Camadas.Model.Fabricante> lstFabr = new List<Camadas.Model.Fabricante>();
            lstFabr = bllFabricante.SelectById(Convert.ToInt32(txtIdFrabr.Text));
            if (lstFabr != null)
                fabricante = lstFabr[0];
            else MessageBox.Show("Fornecedor não encontrado");

        }


        private void frmProduto_Load(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
            HabilitarControlesProduto(false);
            LimpaControlesProduto();
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();

            dgvProduto.DataSource = bllProduto.Select();

            Camadas.BLL.Fornecedor bllFornecedor = new Camadas.BLL.Fornecedor();
            cmbNomeForn.DisplayMember = "nome";
            cmbNomeForn.ValueMember = "id";
            cmbNomeForn.DataSource = bllFornecedor.Select();

            Camadas.BLL.Fabricante bllFabricante = new Camadas.BLL.Fabricante();
            cmbNomeFabr.DisplayMember = "nome";
            cmbNomeFabr.ValueMember = "id";
            cmbNomeFabr.DataSource = bllFabricante.Select();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LimpaControlesProduto();
            lblId.Text = "-1";
            HabilitarControlesProduto(true);
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                HabilitarControlesProduto(true);
                dtpData.Focus();
            }
            else
            {
                string msg = "Não há Produto para edição...";
                MessageBox.Show(msg, "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Confirma Remoção de Produto " + lblId.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
                    Camadas.Model.Produto produto = new Camadas.Model.Produto();
                    produto.Id = id;

                    bllProduto.Delete(produto);
                    dgvProduto.DataSource = "";
                    dgvProduto.DataSource = bllProduto.Select();
                }
            }
            else
            {
                msg = "Não há Produto para remoção...";
                MessageBox.Show(msg, "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LimpaControlesProduto();
            HabilitarControlesProduto(false);
        }

        private void btnGrvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            Camadas.Model.Produto produto = new Camadas.Model.Produto();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1) 
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                produto.Id = id;
                produto.Fornecedor = Convert.ToInt32(txtIdForn.Text);
                produto.Fabricante = Convert.ToInt32(txtIdFrabr.Text);
                produto.Nome = txtNome.Text;
                produto.Data = dtpData.Value;
                produto.Descricao = txtDescricao.Text;
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                produto.ValorUnitario = Convert.ToSingle(txtValorUnit.Text);
                produto.ValorFinal = Convert.ToSingle(txtValorFinal.Text);
                if (id == -1)   
                    bllProd.Insert(produto);
                else bllProd.Update(produto);
            }
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();  
            LimpaControlesProduto();
            HabilitarControlesProduto(false);
        }



        private void cmbNomeForn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdForn.Text = cmbNomeForn.SelectedValue.ToString();
            RecuperarDadosFornecedor();
        }

        private void cmbNomeFabr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdFrabr.Text = cmbNomeFabr.SelectedValue.ToString();
            RecuperarDadosFabricante();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControlesProduto();
            HabilitarControlesProduto(false);
            ;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvProduto.SelectedRows[0].Cells["id"].Value.ToString();
            txtIdForn.Text = dgvProduto.SelectedRows[0].Cells["fornecedor"].Value.ToString();
            txtIdFrabr.Text = dgvProduto.SelectedRows[0].Cells["fabricante"].Value.ToString();
            txtNome.Text = dgvProduto.SelectedRows[0].Cells["nome"].Value.ToString();
            
            dtpData.Text = dgvProduto.SelectedRows[0].Cells["Data"].Value.ToString();
            txtDescricao.Text = dgvProduto.SelectedRows[0].Cells["Descricao"].Value.ToString();
            txtQuantidade.Text = dgvProduto.SelectedRows[0].Cells["Quantidade"].Value.ToString();
            txtValorUnit.Text = dgvProduto.SelectedRows[0].Cells["ValorUnitario"].Value.ToString();
            txtValorFinal.Text = dgvProduto.SelectedRows[0].Cells["ValorFinal"].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaControlesProduto();
            HabilitarControlesProduto(false);
        }

        

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProduto.Select();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            dgvProduto.DataSource = "";
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            dgvProduto.DataSource = "";
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos_CheckedChanged(null, null);
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != string.Empty)
            {
                Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
                List<Camadas.Model.Produto> lstProduto = new List<Camadas.Model.Produto>();

                if (rdbCodigo.Checked)
                    lstProduto = bllProduto.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbNome.Checked)
                    lstProduto = bllProduto.SelectByNome(txtPesquisa.Text);

                dgvProduto.DataSource = "";
                dgvProduto.DataSource = lstProduto;
            }
            else
            {
                string msg = "Campo Pesquisa esta vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pnlPesquisa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
