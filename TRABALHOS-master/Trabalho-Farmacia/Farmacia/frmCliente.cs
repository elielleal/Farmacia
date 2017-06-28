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
    public partial class frmClientes : Form
    {
        public frmClientes()
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
            dgvClientes.Enabled = !status;

            //Botões
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = bllCliente.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                lblId.Text = dgvClientes.SelectedRows[0].Cells["Id"].Value.ToString();
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["Nome"].Value.ToString();
                txtCpf.Text = dgvClientes.SelectedRows[0].Cells["CPF"].Value.ToString();
                txtRg.Text = dgvClientes.SelectedRows[0].Cells["RG"].Value.ToString();
                txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["Endereco"].Value.ToString();
                txtBairro.Text = dgvClientes.SelectedRows[0].Cells["Bairro"].Value.ToString();
                txtCidade.Text = dgvClientes.SelectedRows[0].Cells["Cidade"].Value.ToString();
                txtUf.Text = dgvClientes.SelectedRows[0].Cells["UF"].Value.ToString();
                txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["Telefone"].Value.ToString();
                txtCelular.Text = dgvClientes.SelectedRows[0].Cells["Celular"].Value.ToString();
                txtSexo.Text = dgvClientes.SelectedRows[0].Cells["Sexo"].Value.ToString();
                txtEmail.Text = dgvClientes.SelectedRows[0].Cells["Email"].Value.ToString();
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

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

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
            else {
                    string msg = ("Não há Registro para edição...");
                    MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
        }

        private void btnGrvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1)
                msg = "Confirma Inclusão dos Dados?";
            else msg = "Confirma Atualização dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                cliente.Id = id;
                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCpf.Text;
                cliente.RG = txtRg.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.UF = txtUf.Text.ToUpper();
                cliente.Telefone = txtTelefone.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Sexo = txtSexo.Text;
                cliente.Email = txtEmail.Text;
                if (id == -1)
                    bllCliente.Insert(cliente);
                else bllCliente.Update(cliente);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCliente.Select();
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
                msg = "Confirma Remoção do Cliente " + txtNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
                    Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
                    cliente.Id = id;
                    bllCliente.Delete(cliente);
                    dgvClientes.DataSource = "";
                    dgvClientes.DataSource = bllCliente.Select();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos_CheckedChanged(null, null);

        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCliente.Select();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = "";
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
                Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
                List<Camadas.Model.Cliente> lstCliente = new List<Camadas.Model.Cliente>();

                if (rdbCodigo.Checked)
                    lstCliente = bllCliente.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbNome.Checked)
                    lstCliente = bllCliente.SelectByNome(txtPesquisa.Text);

                dgvClientes.DataSource = "";
                dgvClientes.DataSource = lstCliente;
            }
            else
            {
                string msg = "Campo Pesquisa esta vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = "";
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }
    }
}
