using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.BLL
{
    public class Funcionario
    {
        public List<Model.Funcionario> Select()
        {
            DAL.Funcionario dalFunc = new DAL.Funcionario();
            return dalFunc.Select();
        }

        public List<Model.Funcionario> SelectById(int id)
        {
            DAL.Funcionario dalFunc = new DAL.Funcionario();
            return dalFunc.SelectById(id);
        }

        public List<Model.Funcionario> SelectByNome(string nome)
        {
            DAL.Funcionario dalFunc = new DAL.Funcionario();
            return dalFunc.SelectByNome(nome);
        }

        public void Insert(Model.Funcionario funcionario)
        {
            DAL.Funcionario dalFunc = new DAL.Funcionario();
            dalFunc.Insert(funcionario);
        }

        public void Update(Model.Funcionario funcionario)
        {
            DAL.Funcionario dalFunc = new DAL.Funcionario();
            dalFunc.Update(funcionario);
        }

        public void Delete(Model.Funcionario funcionario)
        {
            DAL.Funcionario dalFunc = new DAL.Funcionario();
            dalFunc.Delete(funcionario);
        }
    }
}