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
    public partial class frmFabricante : Form
    {
        public frmFabricante()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtCnpj.Enabled = status;
            txtTelefone.Enabled = status;
            txtEndereco.Enabled = status;
            txtBairro.Enabled = status;
            txtCidade.Enabled = status;
            txtUf.Enabled = status;
            txtCep.Enabled = status;
            txtEmail.Enabled = status;
            dgvFabricante.Enabled = !status;

            //botões
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGrvar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtCep.Text = "";
            txtEmail.Text = "";
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Fabricante bllFabricante = new Camadas.BLL.Fabricante();
            dgvFabricante.DataSource = bllFabricante.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblId.Text = "-1";
            Habilitar(true);
            txtNome.Focus();
        }

        private void dgvFabricante_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFabricante.SelectedRows.Count > 0)
            {

                lblId.Text = dgvFabricante.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvFabricante.SelectedRows[0].Cells["nome"].Value.ToString();
                txtCnpj.Text = dgvFabricante.SelectedRows[0].Cells["cnpj"].Value.ToString();
                txtTelefone.Text = dgvFabricante.SelectedRows[0].Cells["telefone"].Value.ToString();
                txtEndereco.Text = dgvFabricante.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtBairro.Text = dgvFabricante.SelectedRows[0].Cells["bairro"].Value.ToString();
                txtCidade.Text = dgvFabricante.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtUf.Text = dgvFabricante.SelectedRows[0].Cells["uf"].Value.ToString();
                txtCep.Text = dgvFabricante.SelectedRows[0].Cells["cep"].Value.ToString();
                txtEmail.Text = dgvFabricante.SelectedRows[0].Cells["email"].Value.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                Habilitar(true);
                txtNome.Focus();
            }
            else{
                    string msg = "Não há Registro para edição...";
                    MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnGrvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Fabricante bllFabricante = new Camadas.BLL.Fabricante();
            Camadas.Model.Fabricante fabricante = new Camadas.Model.Fabricante();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1)
                msg = "Confirma Inclusao dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                fabricante.Id = id;
                fabricante.Nome = txtNome.Text;
                fabricante.CNPJ = txtCnpj.Text;
                fabricante.Telefone = txtTelefone.Text;
                fabricante.Endereco = txtEndereco.Text;
                fabricante.Bairro = txtBairro.Text;
                fabricante.Cidade = txtCidade.Text;
                fabricante.UF = txtUf.Text;
                fabricante.CEP = txtCep.Text;
                fabricante.Email = txtEmail.Text;
                if (id == -1)
                    bllFabricante.Insert(fabricante);
                else bllFabricante.Update(fabricante);
            }
            dgvFabricante.DataSource = "";
            dgvFabricante.DataSource = bllFabricante.Select();
            limparCampos();
            Habilitar(false);
        }

        private void txtUf_Leave(object sender, EventArgs e)
        {
            txtUf.Text = txtUf.Text.ToUpper();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Confirma Remoção do Fabricante " + txtNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.Fabricante bllFabricante = new Camadas.BLL.Fabricante();
                    Camadas.Model.Fabricante fabricante = new Camadas.Model.Fabricante();
                    fabricante.Id = id;
                    bllFabricante.Delete(fabricante);
                    dgvFabricante.DataSource = "";
                    dgvFabricante.DataSource = bllFabricante.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            limparCampos();
            Habilitar(false);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos_CheckedChanged(null, null);
        }

       

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != string.Empty)
            {
                Camadas.BLL.Fabricante bllFabricante = new Camadas.BLL.Fabricante();
                List<Camadas.Model.Fabricante> lstFabricante = new List<Camadas.Model.Fabricante>();

                if (rdbCodigo.Checked)
                    lstFabricante = bllFabricante.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbNome.Checked)
                    lstFabricante = bllFabricante.SelectByNome(txtPesquisa.Text);

                dgvFabricante.DataSource = "";
                dgvFabricante.DataSource = lstFabricante;
            }
            else
            {
                string msg = "Campo Pesquisa esta vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Fabricante bllCliente = new Camadas.BLL.Fabricante();
            dgvFabricante.DataSource = "";
            dgvFabricante.DataSource = bllCliente.Select();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            dgvFabricante.DataSource = "";
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            dgvFabricante.DataSource = "";
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }
    }
}
