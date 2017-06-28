using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.BLL
{
    public class ItemVenda
    {
        public List<Model.ItemVenda> Select()
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            return dalItemVenda.Select();
        }

        public List<Model.ItemVenda> SelectById(int id)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            return dalItemVenda.SelectById(id);
        }

        public List<Model.ItemVenda> SelectByVenda(int venda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            return dalItemVenda.SelectByVenda(venda);
        }

        public void Insert(Model.ItemVenda ItemVenda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            dalItemVenda.Insert(ItemVenda);
        }

        public void Update(Model.ItemVenda ItemVenda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            dalItemVenda.Update(ItemVenda);
        }

        public void Delete(Model.ItemVenda ItemVenda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            dalItemVenda.Delete(ItemVenda);
        }
    }
}
