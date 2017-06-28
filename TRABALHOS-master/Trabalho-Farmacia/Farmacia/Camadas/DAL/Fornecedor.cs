using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.DAL
{
    public class Fornecedor
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Fornecedor> Select()
        {
            List<Model.Fornecedor> lstFornecedor = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fornecedor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = reader["Nome"].ToString();
                    fornecedor.CNPJ = reader["CNPJ"].ToString();
                    fornecedor.Telefone = reader["Telefone"].ToString();
                    fornecedor.Endereco = reader["Endereco"].ToString();
                    fornecedor.Bairro = reader["Bairro"].ToString();
                    fornecedor.Cidade = reader["Cidade"].ToString();
                    fornecedor.UF = reader["UF"].ToString();
                    fornecedor.CEP = reader["CEP"].ToString();
                    fornecedor.Email = reader["Email"].ToString();
                    lstFornecedor.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Fabricante...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstFornecedor;
        }

        public List<Model.Fornecedor> SelectById(int id)
        {
            List<Model.Fornecedor> lstFornecedor = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fornecedor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = reader["Nome"].ToString();
                    fornecedor.CNPJ = reader["CNPJ"].ToString();
                    fornecedor.Telefone = reader["Telefone"].ToString();
                    fornecedor.Endereco = reader["Endereco"].ToString();
                    fornecedor.Bairro = reader["Bairro"].ToString();
                    fornecedor.Cidade = reader["Cidade"].ToString();
                    fornecedor.UF = reader["UF"].ToString();
                    fornecedor.CEP = reader["CEP"].ToString();
                    fornecedor.Email = reader["Email"].ToString();
                    lstFornecedor.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Fabricante...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstFornecedor;
        }

        public List<Model.Fornecedor> SelectByNome(string nome)
        {
            List<Model.Fornecedor> lstFornecedor = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fornecedor where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = reader["Nome"].ToString();
                    fornecedor.CNPJ = reader["CNPJ"].ToString();
                    fornecedor.Telefone = reader["Telefone"].ToString();
                    fornecedor.Endereco = reader["Endereco"].ToString();
                    fornecedor.Bairro = reader["Bairro"].ToString();
                    fornecedor.Cidade = reader["Cidade"].ToString();
                    fornecedor.UF = reader["UF"].ToString();
                    fornecedor.CEP = reader["CEP"].ToString();
                    fornecedor.Email = reader["Email"].ToString();
                    lstFornecedor.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Fabricante...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstFornecedor;
        }

        public void Insert(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Fornecedor values ";
            sql = sql + " (@nome, @cnpj, @telefone, @endereco, @bairro, @cidade, @uf, @cep, @email);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
            cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
            cmd.Parameters.AddWithValue("@uf", fornecedor.UF);
            cmd.Parameters.AddWithValue("@cep", fornecedor.CEP);
            cmd.Parameters.AddWithValue("@email", fornecedor.Email);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Fabricante...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Fornecedor set nome=@nome, cnpj=@cnpj, telefone=@telefone, endereco=@endereco, bairro=@bairro, ";
            sql += "cidade=@cidade, uf=@uf, cep=@cep, email=@email ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            cmd.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
            cmd.Parameters.AddWithValue("@UF", fornecedor.UF);
            cmd.Parameters.AddWithValue("@CEP", fornecedor.CEP);
            cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
            cmd.Parameters.AddWithValue("@Id", fornecedor.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Fabricante...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Fornecedor where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", fornecedor.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção Fabricante");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
