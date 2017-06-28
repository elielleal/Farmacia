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
    public partial class frmVenda : Form
    {
        Camadas.Model.Produto produto = new Camadas.Model.Produto();
        public frmVenda()
        {
            InitializeComponent();
        }

        private void HabilitarControlesVenda(bool status)
        {
            txtIdCliente.Enabled = status;
            cmbCliente.Enabled = status;
            txtIdFuncionario.Enabled = status;
            cmbFuncionario.Enabled = status;
            dtpVenda.Enabled = status;
            dtpVencimento.Enabled = status;
            dtpPagamento.Enabled = status;
            dgvVenda.Enabled = !status;

            //botões
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGrvar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void LimparControlesVenda()
        {
            lbl.Text = "";
            txtIdCliente.Text = "";
            cmbCliente.Text = "";
            txtIdFuncionario.Text = "";
            cmbFuncionario.Text = "";
            dtpVenda.Value = DateTime.Now.Date;
            dtpVencimento.Value = DateTime.Now.Date;
            dtpPagamento.Value = DateTime.Now.Date;
        }

        private void HabilitarControlesItemVenda(bool status)
        {
            
            txtIdProduto.Enabled = status;
            cmbProduto.Enabled = status;
            txtQuantidade.Enabled = status;
            txtValorUnitario.Enabled = status;

            //botões
            btnGrav.Enabled = !status;
            btnEdit.Enabled = !status;
            btnRemov.Enabled = !status;
            btnGrav.Enabled = status;
            btnCancel.Enabled = status;
        }

        private void LimparControlesItemVenda()
        {
            
            txtIdProduto.Text = "";
            cmbProduto.Text = "";
            txtValorUnitario.Text = "";
            cmbQuantidade.Text = "0";
            txtValorTotal.Text = "0";
            txtQuantidade.Text = "0";
            txtComprados.Text = "";
            txtDevedor.Text = "";
        }

        private void RecuperarDadosProduto()
        {
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lstProd = new List<Camadas.Model.Produto>();
            lstProd = bllProduto.SelectById(Convert.ToInt32(txtIdProduto.Text));
            if (lstProd != null)
                produto = lstProd[0];
            else MessageBox.Show("Produto não encontrado");
            if (produto.Quantidade <= 0)
            {
                MessageBox.Show("Produto esta em Falta no Estoque " + produto.Quantidade);
                cmbProduto.Focus();
            }
            else
            {
                txtQuantidade.Text = produto.Quantidade.ToString();
                txtValorUnitario.Text = produto.ValorFinal.ToString();
            }
        }
        private void frmVenda_Load(object sender, EventArgs e)
        {
            HabilitarControlesVenda(false);
            HabilitarControlesItemVenda(false);
            LimparControlesVenda();
            LimparControlesItemVenda();

            Camadas.BLL.Venda bllVenda = new Camadas.BLL.Venda();
            Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();

            dgvVenda.DataSource = bllVenda.Select();
            dgvItemVenda.DataSource = bllItemVenda.Select();

            //combox
            //cliente
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCliente.Select();

            //funcionario
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
            cmbFuncionario.DisplayMember = "nome";
            cmbFuncionario.ValueMember = "id";
            cmbFuncionario.DataSource = bllFuncionario.Select();

            //venda
            Camadas.BLL.Venda bllVendas = new Camadas.BLL.Venda();
            cmbVenda.DisplayMember = "id";
            cmbVenda.DataSource = bllVendas.Select();

            //produto
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            cmbProduto.DisplayMember = "nome";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = bllProduto.Select();

            txtIdCliente.Text = cmbCliente.SelectedValue.ToString();
            txtIdFuncionario.Text = cmbFuncionario.SelectedValue.ToString();
        }

        private void pnlVenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LimparControlesVenda();
            lblIdVenda.Text = "-1";
            HabilitarControlesVenda(true);
            dtpVenda.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblIdVenda.Text != string.Empty)
            {
                HabilitarControlesVenda(true);
                dtpVenda.Focus();
            }
            else
            {
                string msg = "Não há Venda para remoção...";
                MessageBox.Show(msg, "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblIdVenda.Text != string.Empty)
            {
                msg = "Confirma Remoção de Venda " + lblIdVenda.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblIdVenda.Text);
                    Camadas.BLL.Venda bllVenda = new Camadas.BLL.Venda();
                    Camadas.Model.Venda venda = new Camadas.Model.Venda();
                    venda.Id = id;
                    bllVenda.Delete(venda);
                    dgvVenda.DataSource = "";
                    dgvVenda.DataSource = bllVenda.Select();
                }
            }
            else
            {
                msg = "Não há Venda para remoção...";
                MessageBox.Show(msg, "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimparControlesVenda();
            HabilitarControlesVenda(false);
        }

        private void btnGrvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Venda bllVenda = new Camadas.BLL.Venda();
            Camadas.Model.Venda venda = new Camadas.Model.Venda();
            int id = Convert.ToInt32(lblIdVenda.Text);

            string msg = "";
            if (id == -1)
                msg = "Confirma Inclusão de venda?";
            else msg = "Confirma Atualização de Venda?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                venda.Cliente = Convert.ToInt32(txtIdCliente.Text);
                venda.Funcionario = Convert.ToInt32(txtIdFuncionario.Text);
                venda.DataVenda = dtpVenda.Value;
                venda.DataVencimento = dtpVencimento.Value;
                venda.DataPagamento = dtpPagamento.Value;

                if (id == -1)
                {
                    bllVenda.Insert(venda);
                }
                else
                {
                    venda.Id = id;
                    bllVenda.Update(venda);
                }
            }
            dgvVenda.DataSource = "";
            dgvVenda.DataSource = bllVenda.Select();
            LimparControlesVenda();
            HabilitarControlesVenda(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparControlesVenda();
            HabilitarControlesVenda(false);
        }

        private void dgvVenda_DoubleClick(object sender, EventArgs e)
        {
            if ( dgvVenda.SelectedRows.Count > 0)
            {
                lblIdVenda.Text = dgvVenda.SelectedRows[0].Cells["id"].Value.ToString();
                
                cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text);
                txtIdCliente.Text = dgvVenda.SelectedRows[0].Cells["cliente"].Value.ToString();
                cmbFuncionario.SelectedValue = Convert.ToInt32(txtIdFuncionario.Text);
                txtIdFuncionario.Text = dgvVenda.SelectedRows[0].Cells["funcionario"].Value.ToString();
                dtpVenda.Value = Convert.ToDateTime(dgvVenda.SelectedRows[0].Cells["dataVenda"].Value.ToString());
                dtpVencimento.Value = Convert.ToDateTime(dgvVenda.SelectedRows[0].Cells["dataVencimento"].Value.ToString());
                dtpPagamento.Value = Convert.ToDateTime(dgvVenda.SelectedRows[0].Cells["dataPagamento"].Value.ToString());
                
                Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
                int venda = Convert.ToInt32(lblIdVenda.Text);
                dgvItemVenda.DataSource = "";
                dgvItemVenda.DataSource = bllItemVenda.SelectByVenda(venda);
            }
        }

        private void dgvItemVenda_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItemVenda.SelectedRows.Count > 0)
            {
                lblItemVenda.Text = dgvItemVenda.SelectedRows[0].Cells["Id"].Value.ToString();
                cmbVenda.SelectedValue = Convert.ToInt32(lblIdVenda.Text);
                txtIdProduto.Text = dgvItemVenda.SelectedRows[0].Cells["produto"].Value.ToString();
                cmbProduto.SelectedValue = Convert.ToInt32(txtIdProduto.Text);
                txtQuantidade.Text = dgvItemVenda.SelectedRows[0].Cells["quantidade"].Value.ToString();
                txtComprados.Text = dgvItemVenda.SelectedRows[0].Cells["comprados"].Value.ToString();
                txtValorUnitario.Text = dgvItemVenda.SelectedRows[0].Cells["valorUnitario"].Value.ToString();
                cmbQuantidade.SelectedValue = Convert.ToInt32(txtQuantidade.Text);
                Single n1, n2;
                n1 = Convert.ToSingle(txtComprados.Text);
                n2 = Convert.ToSingle(txtValorUnitario.Text);
                txtDevedor.Text = (n1 * n2).ToString();

            }
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            
                LimparControlesItemVenda();
                lblItemVenda.Text = "-1";
                HabilitarControlesItemVenda(true);         
        }


        private void cmbProduto_Leave(object sender, EventArgs e)
        {
           // txtIdProduto.Text = cmbProduto.SelectedValue.ToString();
                
        }

        private Camadas.BLL.Produto bllProduto()
        {
            Camadas.BLL.Produto prod = new Camadas.BLL.Produto();
            return prod;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGrav_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
            Camadas.Model.ItemVenda itemVenda = new Camadas.Model.ItemVenda();
            int id = Convert.ToInt32(lblItemVenda.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão de Item de Locação?";
            else msg = "Confirma Atualização de Item de Locação?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Item de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                
                itemVenda.Venda = Convert.ToInt32(cmbVenda.Text);
                itemVenda.Produto = Convert.ToInt32(txtIdProduto.Text);
                itemVenda.Quantidade = Convert.ToInt32(cmbQuantidade.Text);
                itemVenda.ValorUnitario = Convert.ToSingle(txtValorUnitario.Text);


                if (id == -1)
                {
                    bllItemVenda.Insert(itemVenda);
                    //atualiza a quantidade de produtos após a compra
                    Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
                    int num = Convert.ToInt32(txtIdProduto.Text);
                    int qtde = Convert.ToInt32(txtQuantidade.Text);
                    bllProd.Quantidade(qtde, num);
                }
                else
                {
                    itemVenda.Id = id;
                    bllItemVenda.Update(itemVenda);
                }
            }
            dgvItemVenda.DataSource = "";
            dgvItemVenda.DataSource = bllItemVenda.SelectByVenda(Convert.ToInt32(lblItemVenda.Text));  //atualiza a grid
            LimparControlesItemVenda();
            HabilitarControlesItemVenda(false);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtoTableAdapter.FillBy(this.farmaciaDataSet.Produto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControlesVenda();
            HabilitarControlesVenda(false);

        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            //txtIdCliente.Text = cmbCliente.SelectedValue.ToString();
        }

        private void cmbFuncionario_Leave(object sender, EventArgs e)
        {
            //txtIdFuncionario.Text = cmbFuncionario.SelectedValue.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblItemVenda.Text != string.Empty)
            {
                HabilitarControlesItemVenda(true);
                LimparControlesItemVenda();

            }
            else
            {
                string msg = "Não há Itens Item Venda para edição...";
                MessageBox.Show(msg, "Itens Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemov_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblItemVenda.Text != string.Empty)
            {
                msg = "Confirma Remoção de Itens de Venda " + lblItemVenda.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover Item Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblItemVenda.Text);
                    Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
                    Camadas.Model.ItemVenda itemVenda = new Camadas.Model.ItemVenda();
                    itemVenda.Id = id;

                    bllItemVenda.Delete(itemVenda);
                    dgvItemVenda.DataSource = "";
                    dgvItemVenda.DataSource = bllItemVenda.Select();
                }
            }
            else
            {
                msg = "Não há Item Venda para remoção...";
                MessageBox.Show(msg, "Item Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            LimparControlesItemVenda();
            HabilitarControlesItemVenda(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimparControlesItemVenda();
            HabilitarControlesItemVenda(false);
            Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
            dgvItemVenda.DataSource = bllItemVenda.SelectByVenda(Convert.ToInt32(lblItemVenda.Text));
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCliente.Text = cmbCliente.SelectedValue.ToString();
        }

        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdFuncionario.Text = cmbFuncionario.SelectedValue.ToString();
        }

        private int[] estoque(int T)
        {
            int[] numeros = new int[T];
            for (int i = 0; i < T; i++)
            {
                numeros[i] = i + 1;
            }
            return numeros;
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdProduto.Text = cmbProduto.SelectedValue.ToString();

            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            int id = Convert.ToInt32(txtIdProduto.Text);
            txtValorUnitario.Text = bllProd.BuscaValor(id).ToString();
            txtQuantidade.Text = bllProd.qtdeProduto(id).ToString();

            int TAM = Convert.ToInt32(txtQuantidade.Text);
            cmbQuantidade.DataSource = estoque(TAM);

        }

        private void cmbQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Single valor = Convert.ToSingle(txtValorUnitario.Text);
            Single qtde = Convert.ToSingle(cmbQuantidade.Text);
            txtValorTotal.Text = (valor * qtde).ToString();

            int qtde2 = Convert.ToInt32(txtQuantidade.Text);
            txtQuantidade.Text = (qtde2 - qtde).ToString();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantidade.Text);
            if(x < 0 && txtIdProduto.Text != "")
            {
                Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
                string msg = "Excedeu a quantidade de Produtos!";
                int id = Convert.ToInt32(txtIdProduto.Text);
                string qtde = bllProd.qtdeProduto(id).ToString();
                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantidade.Text = qtde;
            }
        }

        private void cmbVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camadas.BLL.ItemVenda itemV = new Camadas.BLL.ItemVenda();
            int id = Convert.ToInt32(cmbVenda.Text);
            dgvItemVenda.DataSource = itemV.SelectById(id);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
        private void dgvItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            List<Camadas.Model.ItemVenda> lstItemVenda = new List<Camadas.Model.ItemVenda>();
            Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
            lstItemVenda = bllItemVenda.Select();
            foreach (Camadas.Model.ItemVenda itemVenda in lstItemVenda)
            {
                int cont = 0;
                float soma = 0;
                int quant = itemVenda.Quantidade;
                float x = quant * itemVenda.ValorUnitario;

                cont++;
                soma = soma + x;

                
                
            }
        }
    }
    
}
