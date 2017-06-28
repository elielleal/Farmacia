using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.BLL
{
    public class Fabricante
    {
        public List<Model.Fabricante> Select()
        {
            DAL.Fabricante dalFabri = new DAL.Fabricante();
            return dalFabri.Select();
        }

        public List<Model.Fabricante> SelectById(int id)
        {
            DAL.Fabricante dalFabri = new DAL.Fabricante();
            return dalFabri.SelectById(id);
        }

        public List<Model.Fabricante> SelectByNome(string nome)
        {
            DAL.Fabricante dalFabri = new DAL.Fabricante();
            return dalFabri.SelectByNome(nome);
        }

        public void Insert(Model.Fabricante fabricante)
        {
            DAL.Fabricante dalFabri = new DAL.Fabricante();
            dalFabri.Insert(fabricante);
        }

        public void Update(Model.Fabricante fabricante)
        {
            DAL.Fabricante dalFabri = new DAL.Fabricante();
            dalFabri.Update(fabricante);
        }

        public void Delete(Model.Fabricante fabricante)
        {
            DAL.Fabricante dalFabri = new DAL.Fabricante();
            dalFabri.Delete(fabricante);
        }
    }
}
