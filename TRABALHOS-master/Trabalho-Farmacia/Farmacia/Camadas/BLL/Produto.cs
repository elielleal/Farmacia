using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Camadas.Model;

namespace Farmacia.Camadas.BLL
{
    public class Produto
    {
        public List<Model.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public List<Model.Produto> SelectById(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectById(id);

        }

        public Single BuscaValor(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.BuscaValor(id);

        }

        public int qtdeProduto(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.qtdeProduto(id);
        }

        public void Quantidade(int qtde, int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Quantidade(qtde, id);
        }

        public List<Model.Produto> SelectByNome(string nome)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByNome(nome);
        }


        public void Insert(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();

            dalProd.Insert(Produto);
        }

        public void Update(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Update(Produto);
        }

        public void Delete(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Delete(Produto);
        }

    }
    

}
