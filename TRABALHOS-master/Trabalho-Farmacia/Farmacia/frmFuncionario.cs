using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Camadas;

namespace Farmacia
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtCpf.Enabled = status;
            txtRg.Enabled = status;
            txtEndereco.Enabled = status;
            txtBairro.Enabled = status;
            txtCidade.Enabled = status;
            txtUf.Enabled = status;
            txtTelefone.Enabled = status;
            txtCelular.Enabled = status;
            txtSexo.Enabled = status;
            txtEmail.Enabled = status;

            // botões
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
            txtCpf.Text = "";
            txtRg.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtSexo.Text = "";
            txtEmail.Text = "";
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
            dgvFuncionario.DataSource = bllFuncionario.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;
        }

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                lblId.Text = dgvFuncionario.SelectedRows[0].Cells["Id"].Value.ToString();
                txtNome.Text = dgvFuncionario.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtCpf.Text = dgvFuncionario.SelectedRows[0].Cells["CPF"].Value.ToString();
                txtRg.Text = dgvFuncionario.SelectedRows[0].Cells["RG"].Value.ToString();
                txtEndereco.Text = dgvFuncionario.SelectedRows[0].Cells["Endereco"].Value.ToString();
                txtBairro.Text = dgvFuncionario.SelectedRows[0].Cells["Bairro"].Value.ToString();
                txtCidade.Text = dgvFuncionario.SelectedRows[0].Cells["Cidade"].Value.ToString();
                txtUf.Text = dgvFuncionario.SelectedRows[0].Cells["UF"].Value.ToString();
                txtTelefone.Text = dgvFuncionario.SelectedRows[0].Cells["Telefone"].Value.ToString();
                txtCelular.Text = dgvFuncionario.SelectedRows[0].Cells["Celular"].Value.ToString();
                txtSexo.Text = dgvFuncionario.SelectedRows[0].Cells["Sexo"].Value.ToString();
                txtEmail.Text = dgvFuncionario.SelectedRows[0].Cells["Email"].Value.ToString();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparCampos();
            lblId.Text = "-1";
            Habilitar(true);
            txtNome.Focus();
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
            else
            {
                string msg = ("Não há Registro para edição...");
                MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGrvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
            Camadas.Model.Funcionario funcionario = new Camadas.Model.Funcionario();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                funcionario.Id = id;
                funcionario.Nome = txtNome.Text;
                funcionario.CPF = txtCpf.Text;
                funcionario.RG = txtRg.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Cidade = txtCidade.Text;
                funcionario.UF = txtUf.Text.ToUpper();
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Celular = txtCelular.Text;
                funcionario.Sexo = txtSexo.Text;
                funcionario.Email = txtEmail.Text;
                if (id == -1)
                    bllFuncionario.Insert(funcionario);
                else bllFuncionario.Update(funcionario);
            }
            dgvFuncionario.DataSource = "";
            dgvFuncionario.DataSource = bllFuncionario.Select();
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
                msg = "Confirma Remoção do Funcionario " + txtNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
                    Camadas.Model.Funcionario funcionario = new Camadas.Model.Funcionario();
                    funcionario.Id = id;
                    bllFuncionario.Delete(funcionario);
                    dgvFuncionario.DataSource = "";
                    dgvFuncionario.DataSource = bllFuncionario.Select();
                }
                else
                {
                    msg = "Não há registro para remoção...";
                    MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                limparCampos();
                Habilitar(false);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos_CheckedChange(null, null);
        }

        private void rdbTodos_CheckedChange(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
            dgvFuncionario.DataSource = "";
            dgvFuncionario.DataSource = bllFuncionario.Select();
        }



        private void rdbNome_CheckedChange(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = "";
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != string.Empty)
            {
                Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
                List<Camadas.Model.Funcionario> lstFuncionario = new List<Camadas.Model.Funcionario>();

                if (rdbCodigo.Checked)
                    lstFuncionario = bllFuncionario.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbNome.Checked)
                    lstFuncionario = bllFuncionario.SelectByNome(txtPesquisa.Text);

                dgvFuncionario.DataSource = "";
                dgvFuncionario.DataSource = lstFuncionario;
            }
            else
            {
                string msg = "Campo Pesquisa esta vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = "";
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }
    }
}
