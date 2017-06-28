using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Farmacia.Relatorios
{
    public class realVenda
    {
        public static void impRealVenda()
        {
            List<Camadas.Model.Venda> lstVenda = new List<Camadas.Model.Venda>();
            Camadas.BLL.Venda bllVend = new Camadas.BLL.Venda();
            lstVenda = bllVend.Select();

            string folder = FunRel.diretorioPasta();
            string arquivo = folder + @"\realVenda.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1 align='left'><font color=#8B0000> RELATÓRIO DE VENDA</h1>");
                //definição de tabela
                sw.WriteLine("<table>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='30px' align='left'><font color=#FFFAFA>ID</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA>DATA DA VENDA</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA>DATA VENCIMENTO</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA>DATA PAGAMENTO</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='200px' align='center'><font color=#FFFAFA>CLIENTE</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='200px' align='center'><font color=#FFFAFA>FUNCIONARIO</th></font>");
                sw.WriteLine("</tr>");
                //detalhes itens do relatorios
                foreach (Camadas.Model.Venda venda in lstVenda)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='30px'  align='center'><font color=#FFFAFA>" + venda.Id + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='30px'  align='center'><font color=#FFFAFA>" + venda.DataVenda + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='150px' align='center'><font color=#FFFAFA>" + venda.DataVencimento + "</td></font>>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='150px' align='center'><font color=#FFFAFA>" + venda.DataPagamento + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='200px' align='center'><font color=#FFFAFA>" + venda.Cliente + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='200px' align='center'><font color=#FFFAFA>" + venda.Funcionario + "</td></font>");
                    sw.WriteLine("</tr>");
                }
              
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' width='1500px' border='2px' border color='black'>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    
    }
}
