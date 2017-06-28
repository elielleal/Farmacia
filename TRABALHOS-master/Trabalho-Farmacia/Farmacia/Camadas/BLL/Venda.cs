using System.Collections.Generic;

namespace Farmacia.Camadas.BLL
{
    public class Venda
    {
        public List<Model.Venda> Select()
        {
            DAL.Venda dalVenda = new DAL.Venda();
            return dalVenda.Select();
        }

        public List<Model.Venda> SelectById(int id)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            return dalVenda.SelectById(id);
        }

        public List<Model.Venda> SelectByCliente(int cliente)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            return dalVenda.SelectByCliente(cliente);
        }

        public void Insert(Model.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            dalVenda.Insert(venda);
        }

        public void Update(Model.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            dalVenda.Update(venda);
        }

        public void Delete(Model.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            dalVenda.Delete(venda);
        }
    }
}
