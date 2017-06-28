using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Produto> Select()
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                    Model.Produto produto = new Model.Produto();
                    produto.Id = Convert.ToInt32(reader["Id"]);
                    produto.Fornecedor = Convert.ToInt32(reader["Fabricante"]);
                    produto.Fabricante = Convert.ToInt32(reader["Fabricante"]);
                    produto.Nome = reader["Nome"].ToString();
                    produto.Data = Convert.ToDateTime(reader["Data"].ToString());
                    produto.Descricao = reader["Descricao"].ToString();
                    produto.Quantidade = Convert.ToInt32(reader["Quantidade"]);
                    produto.ValorUnitario = Convert.ToSingle(reader["ValorUnitario"].ToString());
                    produto.ValorFinal = Convert.ToSingle(reader["ValorFinal"].ToString());
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public List<Model.Produto> SelectById(int id)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                    Model.Produto produto = new Model.Produto();
                    produto.Id = Convert.ToInt32(reader["Id"]);
                    produto.Fornecedor = Convert.ToInt32(reader["Fabricante"]);
                    produto.Fabricante = Convert.ToInt32(reader["Fabricante"]);
                    produto.Nome = reader["Nome"].ToString();
                    produto.Data = Convert.ToDateTime(reader["Data"].ToString());
                    produto.Descricao = reader["Descricao"].ToString();
                    produto.Quantidade = Convert.ToInt32(reader["Quantidade"]);
                    produto.ValorUnitario = Convert.ToSingle(reader["ValorUnitario"].ToString());
                    produto.ValorFinal = Convert.ToSingle(reader["ValorFinal"].ToString());
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        //Buca valor unitario
        public Single BuscaValor(int id)
        {
            Single busca = -1;
          
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.Id = Convert.ToInt32(reader["Id"]);
                    produto.ValorFinal = Convert.ToSingle(reader["valorFinal"]);
                    if( id == produto.Id)
                    {
                        busca = Convert.ToSingle(produto.ValorFinal);
                        return busca;
                    }
                   
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return busca;
        }

        //Busca Quantidade no estoque
        public int qtdeProduto(int id)
        {
            int busca = -1;

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.Id = Convert.ToInt32(reader["Id"]);
                    produto.Quantidade = Convert.ToInt32(reader["quantidade"]);
                    if (id == produto.Id)
                    {
                        busca = Convert.ToInt32(produto.Quantidade);
                        return busca;
                    }

                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return busca;
        }

        public List<Model.Produto> SelectByNome(string nome)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                    Model.Produto produto = new Model.Produto();
                    produto.Id = Convert.ToInt32(reader["Id"]);
                    produto.Fornecedor = Convert.ToInt32(reader["Fabricante"]);
                    produto.Fabricante = Convert.ToInt32(reader["Fabricante"]);
                    produto.Nome = reader["Nome"].ToString();
                    produto.Data = Convert.ToDateTime(reader["Data"].ToString());
                    produto.Descricao = reader["Descricao"].ToString();
                    produto.Quantidade = Convert.ToInt32(reader["Quantidade"]);
                    produto.ValorUnitario = Convert.ToSingle(reader["ValorUnitario"].ToString());
                    produto.ValorFinal = Convert.ToSingle(reader["ValorFinal"].ToString());
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public void Insert(Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values ";
            sql = sql + " (@fornecedor, @fabricante, @nome, @data, @descricao, @quantidade, @valorUnitario, @valorFinal);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
            cmd.Parameters.AddWithValue("@Fabricante", produto.Fabricante);
            cmd.Parameters.AddWithValue("@Nome", produto.Nome);
            cmd.Parameters.AddWithValue("@Data", produto.Data);
            cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            cmd.Parameters.AddWithValue("@ValorUnitario", produto.ValorUnitario);
            cmd.Parameters.AddWithValue("@ValorFinal", produto.ValorFinal);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deur erro inserção de Produto...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set nome=@nome, data=@data, ";
            sql += "descricao=@descricao, quantidade=@quantidade, valorUnitario=@valorUnitario, valorFinal=@valorFinal ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            
            cmd.Parameters.AddWithValue("@Nome", produto.Nome);
            cmd.Parameters.AddWithValue("@Data", produto.Data);
            cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            cmd.Parameters.AddWithValue("@ValorUnitario", produto.ValorUnitario);
            cmd.Parameters.AddWithValue("@ValorFinal", produto.ValorFinal);
            cmd.Parameters.AddWithValue("@Id", produto.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Item Locacao...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Quantidade(int qtde, int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set quantidade=@quantidade ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@quantidade", qtde);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Item Locacao...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete (Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Item Locacao");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
    
}
