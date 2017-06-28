using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public int Fornecedor { get; set; }
        public int Fabricante { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorFinal { get; set; }
    }
}
