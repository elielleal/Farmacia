using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.BLL
{
    public class Fornecedor
    {
        public List<Model.Fornecedor> Select()
        {
            DAL.Fornecedor dalForne = new DAL.Fornecedor();
            return dalForne.Select();
        }

        public List<Model.Fornecedor> SelectById(int id)
        {
            DAL.Fornecedor dalForne = new DAL.Fornecedor();
            return dalForne.SelectById(id);
        }

        public List<Model.Fornecedor> SelectByNome(string nome)
        {
            DAL.Fornecedor dalForne = new DAL.Fornecedor();
            return dalForne.SelectByNome(nome);
        }

        public void Insert(Model.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalForne = new DAL.Fornecedor();
            dalForne.Insert(fornecedor);
        }

        public void Update(Model.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalForne = new DAL.Fornecedor();
            dalForne.Update(fornecedor);
        }

        public void Delete(Model.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalForne = new DAL.Fornecedor();
            dalForne.Delete(fornecedor);
        }
    }
}
