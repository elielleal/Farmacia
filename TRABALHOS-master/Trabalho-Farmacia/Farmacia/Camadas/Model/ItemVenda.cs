using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Camadas.Model
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int Venda { get; set; }
        public int Produto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
    }
}
