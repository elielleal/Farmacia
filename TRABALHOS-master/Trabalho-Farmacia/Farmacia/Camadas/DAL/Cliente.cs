using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = reader["Nome"].ToString();
                    cliente.CPF = reader["CPF"].ToString();
                    cliente.RG = reader["RG"].ToString();
                    cliente.Endereco = reader["Endereco"].ToString();
                    cliente.Bairro = reader["Bairro"].ToString();
                    cliente.Cidade = reader["Cidade"].ToString();
                    cliente.UF = reader["UF"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();
                    cliente.Celular = reader["Celular"].ToString();
                    cliente.Sexo = reader["Sexo"].ToString();
                    cliente.Email = reader["Email"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }


        public List<Model.Cliente> SelectById(int id)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = reader["Nome"].ToString();
                    cliente.CPF = reader["CPF"].ToString();
                    cliente.RG = reader["RG"].ToString();
                    cliente.Endereco = reader["Endereco"].ToString();
                    cliente.Bairro = reader["Bairro"].ToString();
                    cliente.Cidade = reader["Cidade"].ToString();
                    cliente.UF = reader["UF"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();
                    cliente.Celular = reader["Celular"].ToString();
                    cliente.Sexo = reader["Sexo"].ToString();
                    cliente.Email = reader["Email"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = reader["Nome"].ToString();
                    cliente.CPF = reader["CPF"].ToString();
                    cliente.RG = reader["RG"].ToString();
                    cliente.Endereco = reader["Endereco"].ToString();
                    cliente.Bairro = reader["Bairro"].ToString();
                    cliente.Cidade = reader["Cidade"].ToString();
                    cliente.UF = reader["UF"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();
                    cliente.Celular = reader["Celular"].ToString();
                    cliente.Sexo = reader["Sexo"].ToString();
                    cliente.Email = reader["Email"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCliente;
        }

        public void Insert(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values ";
            sql = sql + " (@nome, @cpf, @rg, @endereco, @bairro, @cidade, @uf, @telefone, @celular, @sexo, @email);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("@rg", cliente.RG);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@uf", cliente.UF);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@celular", cliente.Celular);
            cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, cpf=@cpf, rg=@rg, endereco=@endereco, bairro=@bairro, ";
            sql += "cidade=@cidade, uf=@uf, telefone=@telefone, celular=@celular, sexo=@sexo, email=@email ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@RG", cliente.RG);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@UF", cliente.UF);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
            
        }

        public void Delete (Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where Id=@Id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Cliente");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
