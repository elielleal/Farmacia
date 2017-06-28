using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.DAL
{
    public class Funcionario
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Funcionario> Select()
        {
            List<Model.Funcionario> lstFuncionario = new List<Model.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Funcionario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Funcionario funcionario = new Model.Funcionario();
                    funcionario.Id = Convert.ToInt32(reader["Id"]);
                    funcionario.Nome = reader["Nome"].ToString();
                    funcionario.CPF = reader["CPF"].ToString();
                    funcionario.RG = reader["RG"].ToString();
                    funcionario.Endereco = reader["Endereco"].ToString();
                    funcionario.Bairro = reader["Bairro"].ToString();
                    funcionario.Cidade = reader["Cidade"].ToString();
                    funcionario.UF = reader["UF"].ToString();
                    funcionario.Telefone = reader["Telefone"].ToString();
                    funcionario.Celular = reader["Celular"].ToString();
                    funcionario.Sexo = reader["Sexo"].ToString();
                    funcionario.Email = reader["Email"].ToString();
                    lstFuncionario.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Funcionario...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstFuncionario;
        }

        public List<Model.Funcionario> SelectById(int id)
        {
            List<Model.Funcionario> lstFuncionario = new List<Model.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Funcionario funcionario = new Model.Funcionario();
                    funcionario.Id = Convert.ToInt32(reader["Id"]);
                    funcionario.Nome = reader["Nome"].ToString();
                    funcionario.CPF = reader["CPF"].ToString();
                    funcionario.RG = reader["RG"].ToString();
                    funcionario.Endereco = reader["Endereco"].ToString();
                    funcionario.Bairro = reader["Bairro"].ToString();
                    funcionario.Cidade = reader["Cidade"].ToString();
                    funcionario.UF = reader["UF"].ToString();
                    funcionario.Telefone = reader["Telefone"].ToString();
                    funcionario.Celular = reader["Celular"].ToString();
                    funcionario.Sexo = reader["Sexo"].ToString();
                    funcionario.Email = reader["Email"].ToString();
                    lstFuncionario.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Funcionario...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstFuncionario;
        }

        public List<Model.Funcionario> SelectByNome(string nome)
        {
            List<Model.Funcionario> lstFuncionario = new List<Model.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Funcionario where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Funcionario funcionario = new Model.Funcionario();
                    funcionario.Id = Convert.ToInt32(reader["Id"]);
                    funcionario.Nome = reader["Nome"].ToString();
                    funcionario.CPF = reader["CPF"].ToString();
                    funcionario.RG = reader["RG"].ToString();
                    funcionario.Endereco = reader["Endereco"].ToString();
                    funcionario.Bairro = reader["Bairro"].ToString();
                    funcionario.Cidade = reader["Cidade"].ToString();
                    funcionario.UF = reader["UF"].ToString();
                    funcionario.Telefone = reader["Telefone"].ToString();
                    funcionario.Celular = reader["Celular"].ToString();
                    funcionario.Sexo = reader["Sexo"].ToString();
                    funcionario.Email = reader["Email"].ToString();
                    lstFuncionario.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Funcionario...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstFuncionario;
        }

        public void Insert(Model.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Funcionario values ";
            sql = sql + " (@nome, @cpf, @rg, @endereco, @bairro, @cidade, @uf, @telefone, @celular, @sexo, @email);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
            cmd.Parameters.AddWithValue("@rg", funcionario.RG);
            cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
            cmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
            cmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@uf", funcionario.UF);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("sexo", funcionario.Sexo);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Funcionario...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Funcionario set nome=@nome, cpf=@cpf, rg=@rg, endereco=@endereco, bairro=@bairro, ";
            sql += "cidade=@cidade, uf=@uf, telefone=@telefone, celular=@celular, sexo=@sexo, email=@email ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            cmd.Parameters.AddWithValue("@RG", funcionario.RG);
            cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@UF", funcionario.UF);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@Celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("Sexo", funcionario.Sexo);
            cmd.Parameters.AddWithValue("Email", funcionario.Email);
            cmd.Parameters.AddWithValue("@Id", funcionario.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Funcionarios...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete (Model.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Funcionario where Id=@Id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", funcionario.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção Funcionario");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
