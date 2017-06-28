using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.DAL
{
    public class ItemVenda
    {
        private string strCon = Conexao.getConexao();

        public List<Model.ItemVenda> Select()
        {
            List<Model.ItemVenda> lstItemVenda = new List<Model.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemVenda itemVenda = new Model.ItemVenda();
                    itemVenda.Id = Convert.ToInt32(reader["id"]);
                    itemVenda.Venda = Convert.ToInt32(reader["venda"]);
                    itemVenda.Produto = Convert.ToInt32(reader["produto"]);
                    itemVenda.Quantidade = Convert.ToInt32(reader["quantidade"]);
                    itemVenda.ValorUnitario = Convert.ToSingle(reader["valorUnitario"].ToString());
                    itemVenda.ValorTotal = Convert.ToSingle(reader["valorFinal"].ToString());
                    lstItemVenda.Add(itemVenda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Venda...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemVenda;
        }

        public List<Model.ItemVenda> SelectById(int id)
        {
            List<Model.ItemVenda> lstItemVenda = new List<Model.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemVenda where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemVenda itemVenda = new Model.ItemVenda();
                    itemVenda.Id = Convert.ToInt32(reader["id"]);
                    itemVenda.Venda = Convert.ToInt32(reader["venda"]);
                    itemVenda.Produto = Convert.ToInt32(reader["produto"]);
                    itemVenda.Quantidade = Convert.ToInt32(reader["quantidade"]);
                    itemVenda.ValorUnitario = Convert.ToSingle(reader["valorUnitario"].ToString());
                    
                    lstItemVenda.Add(itemVenda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Venda...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemVenda;
        }

        public List<Model.ItemVenda> SelectByVenda(int venda)
        {
            List<Model.ItemVenda> lstItemVenda = new List<Model.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemVenda where venda=@venda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@venda", venda);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemVenda itemVenda = new Model.ItemVenda();
                    itemVenda.Id = Convert.ToInt32(reader["id"]);
                    itemVenda.Venda = Convert.ToInt32(reader["venda"]);
                    itemVenda.Produto = Convert.ToInt32(reader["produto"]);
                    itemVenda.Quantidade = Convert.ToInt32(reader["quantidade"]);
                    itemVenda.ValorUnitario = Convert.ToSingle(reader["valorUnitario"].ToString());
                    
                    lstItemVenda.Add(itemVenda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Venda...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemVenda;
        }


        public void Insert(Model.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into ItemVenda values ";
            sql = sql + " (@venda, @produto, @quantidade, @valorUnitario);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@venda", itemVenda.Venda);
            cmd.Parameters.AddWithValue("@produto", itemVenda.Produto);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);
           
          
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Item Venda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update ItemVenda set venda=@venda, produto=@produto, quantidade=@quantidade, valorUnitario=@valorUnitario ";
            sql += " venda=@venda, produto=@produto, quantidade=@quantidade, valorUnitario=@valorUnitario ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@venda", itemVenda.Venda);
            cmd.Parameters.AddWithValue("@produto", itemVenda.Produto);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@valorUnitario", itemVenda.ValorUnitario);
            cmd.Parameters.AddWithValue("@id", itemVenda.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Item Venda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from ItemVenda where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", itemVenda.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Item Venda...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
