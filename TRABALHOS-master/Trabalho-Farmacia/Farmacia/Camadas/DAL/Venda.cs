using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Farmacia.Camadas.DAL
{
    public class Venda
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Venda> Select()
        {
            List<Model.Venda> lstVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select venda.id, venda.dataVenda, venda.dataVencimento, venda.dataPagamento, venda.cliente, venda.funcionario, cliente.nome from Venda inner join cliente on cliente.id=venda.cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.Id = Convert.ToInt32(reader["id"]);
                    venda.DataVenda = Convert.ToDateTime(reader["dataVenda"].ToString());
                    venda.DataVencimento = Convert.ToDateTime(reader["dataVencimento"].ToString());
                    venda.DataPagamento = Convert.ToDateTime(reader["dataPagamento"].ToString());
                    venda.Cliente = Convert.ToInt32(reader["cliente"]);
                    venda.Funcionario = Convert.ToInt32(reader["funcionario"]);
                    venda.Nome = reader["nome"].ToString();
                    lstVenda.Add(venda);
                }

            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Venda...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public List<Model.Venda> SelectById(int id)
        {
            List<Model.Venda> lstVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Venda where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.Id = Convert.ToInt32(reader["id"]);
                    venda.DataVenda = Convert.ToDateTime(reader["dataVenda"].ToString());
                    venda.DataVencimento = Convert.ToDateTime(reader["dataVencimento"].ToString());
                    venda.DataPagamento = Convert.ToDateTime(reader["dataPagamento"].ToString());
                    venda.Cliente = Convert.ToInt32(reader["cliente"]);
                    venda.Funcionario = Convert.ToInt32(reader["funcionario"]);

                    lstVenda.Add(venda);
                }

            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Venda...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public List<Model.Venda> SelectByCliente(int cliente)
        {
            List<Model.Venda> lstVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Venda where cliente=@cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.Id = Convert.ToInt32(reader["id"]);
                    venda.DataVenda = Convert.ToDateTime(reader["dataVenda"].ToString());
                    venda.DataVencimento = Convert.ToDateTime(reader["dataVencimento"].ToString());
                    venda.DataPagamento = Convert.ToDateTime(reader["dataPagamento"].ToString());
                    venda.Cliente = Convert.ToInt32(reader["cliente"]);
                    venda.Funcionario = Convert.ToInt32(reader["funcionario"]);

                    lstVenda.Add(venda);
                }

            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Venda...;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public void Insert(Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Venda (cliente, funcionario, dataVenda, dataVencimento, dataPagamento) values ";
            sql = sql + " (@cliente, @funcionario, @dataVenda, @dataVencimento, @dataPagamento);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", venda.Cliente);
            cmd.Parameters.AddWithValue("@funcionario", venda.Funcionario);
            cmd.Parameters.AddWithValue("@dataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@dataVencimento", venda.DataVencimento);
            cmd.Parameters.AddWithValue("@dataPagamento", venda.DataPagamento);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Venda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Venda set  dataVenda=@dataVenda, dataVencimento=@dataVencimento, dataPagamento=@dataPagamento, cliente=@cliente, funcionario=@funcionario ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@dataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@dataVencimento", venda.DataVencimento);
            cmd.Parameters.AddWithValue("@dataPagamento", venda.DataPagamento);
            cmd.Parameters.AddWithValue("@cliente", venda.Cliente);
            cmd.Parameters.AddWithValue("@funcionario", venda.Funcionario);
            cmd.Parameters.AddWithValue("@id", venda.Id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro atualização de Venda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Venda where id=@id ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda.Id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção de Venda...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
