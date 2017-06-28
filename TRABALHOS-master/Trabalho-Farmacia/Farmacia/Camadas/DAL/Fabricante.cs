using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.DAL
{
    public class Fabricante
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Fabricante> Select()
        {
            List<Model.Fabricante> lstFabricante = new List<Model.Fabricante>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fabricante;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fabricante fabricante = new Model.Fabricante();
                    fabricante.Id = Convert.ToInt32(reader["Id"]);
                    fabricante.Nome = reader["Nome"].ToString();
                    fabricante.CNPJ = reader["CNPJ"].ToString();
                    fabricante.Telefone = reader["Telefone"].ToString();
                    fabricante.Endereco = reader["Endereco"].ToString();
                    fabricante.Bairro = reader["Bairro"].ToString();
                    fabricante.Cidade = reader["Cidade"].ToString();
                    fabricante.UF = reader["UF"].ToString();
                    fabricante.CEP = reader["CEP"].ToString();
                    fabricante.Email = reader["Email"].ToString();
                    lstFabricante.Add(fabricante);
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
            return lstFabricante;
        }

        public List<Model.Fabricante> SelectById(int id)
        {
            List<Model.Fabricante> lstFabricante = new List<Model.Fabricante>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fabricante where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fabricante fabricante = new Model.Fabricante();
                    fabricante.Id = Convert.ToInt32(reader["id"]);
                    fabricante.Nome = reader["Nome"].ToString();
                    fabricante.CNPJ = reader["CNPJ"].ToString();
                    fabricante.Telefone = reader["Telefone"].ToString();
                    fabricante.Endereco = reader["Endereco"].ToString();
                    fabricante.Bairro = reader["Bairro"].ToString();
                    fabricante.Cidade = reader["Cidade"].ToString();
                    fabricante.UF = reader["UF"].ToString();
                    fabricante.CEP = reader["CEP"].ToString();
                    fabricante.Email = reader["Email"].ToString();
                    lstFabricante.Add(fabricante);
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
            return lstFabricante;
        }

        public List<Model.Fabricante> SelectByNome(string nome)
        {
            List<Model.Fabricante> lstFabricante = new List<Model.Fabricante>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Fabricante where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fabricante fabricante = new Model.Fabricante();
                    fabricante.Id = Convert.ToInt32(reader["id"]);
                    fabricante.Nome = reader["Nome"].ToString();
                    fabricante.CNPJ = reader["CNPJ"].ToString();
                    fabricante.Telefone = reader["Telefone"].ToString();
                    fabricante.Endereco = reader["Endereco"].ToString();
                    fabricante.Bairro = reader["Bairro"].ToString();
                    fabricante.Cidade = reader["Cidade"].ToString();
                    fabricante.UF = reader["UF"].ToString();
                    fabricante.CEP = reader["CEP"].ToString();
                    fabricante.Email = reader["Email"].ToString();
                    lstFabricante.Add(fabricante);
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
            return lstFabricante;
        }

        public void Insert(Model.Fabricante fabricante)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Fabricante values ";
            sql = sql + " (@nome, @cnpj, @telefone, @endereco, @bairro, @cidade, @uf, @cep, @email);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", fabricante.Nome);
            cmd.Parameters.AddWithValue("@cnpj", fabricante.CNPJ);
            cmd.Parameters.AddWithValue("@telefone", fabricante.Telefone);
            cmd.Parameters.AddWithValue("@endereco", fabricante.Endereco);
            cmd.Parameters.AddWithValue("@bairro", fabricante.Bairro);
            cmd.Parameters.AddWithValue("@cidade", fabricante.Cidade);
            cmd.Parameters.AddWithValue("@uf", fabricante.UF);
            cmd.Parameters.AddWithValue("@cep", fabricante.CEP);
            cmd.Parameters.AddWithValue("@email", fabricante.Email);
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

        public void Update(Model.Fabricante fabricante)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Fabricante set nome=@nome, cnpj=@cnpj, telefone=@telefone, endereco=@endereco, bairro=@bairro, ";
            sql += "cidade=@cidade, uf=@uf, cep=@cep, email=@email ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", fabricante.Nome);
            cmd.Parameters.AddWithValue("@CNPJ", fabricante.CNPJ);
            cmd.Parameters.AddWithValue("@Telefone", fabricante.Telefone);
            cmd.Parameters.AddWithValue("@Endereco", fabricante.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", fabricante.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", fabricante.Cidade);
            cmd.Parameters.AddWithValue("@UF", fabricante.UF);
            cmd.Parameters.AddWithValue("@CEP", fabricante.CEP);
            cmd.Parameters.AddWithValue("@Email", fabricante.Email);
            cmd.Parameters.AddWithValue("@Id", fabricante.Id);
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

        public void Delete (Model.Fabricante fabricante)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Fabricante where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", fabricante.Id);
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
