using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Farmacia.Relatorios
{
    public class relProd
    {
        public static void impRelProd()
        {
            List<Camadas.Model.Produto> lstProd = new List<Camadas.Model.Produto>();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            lstProd = bllProd.Select();

            string folder = FunRel.diretorioPasta();
            string arquivo = folder + @"\relProdutos.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1 align='center'><font color=#8B0000> RELATÓRIO DE PRODUTOS</h1>");
                //definição de tabela
                sw.WriteLine("<table>");
                //cabeçalho tabela
                sw.WriteLine("<tr>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='30px' align='left'><font color=#FFFAFA>ID</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA> FORNECEDOR</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA> FABRICANTE</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA> NOME</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='200px' align='center'><font color=#FFFAFA> DATA</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='200px' align='center'><font color=#FFFAFA> DESCRIÇÃO</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='center'><font color=#FFFAFA> QUANTIDADE</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='right'><font color=#FFFAFA> VALOR UNITARIO</th></font>");
                sw.WriteLine("<th bgcolor=#6B8E23 width ='150px' align='right'><font color=#FFFAFA> VALOR FINAL</th></font>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float soma = 0;
                //detalhes itens do relatorios
                foreach(Camadas.Model.Produto produto in lstProd)
                {
                    int quant = produto.Quantidade;
                    float x = quant * produto.ValorFinal;
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='30px'  align='center'><font color=#FFFAFA>" + produto.Id + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='30px'  align='center'><font color=#FFFAFA>" + produto.Fornecedor + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='150px' align='center'><font color=#FFFAFA>" + produto.Fabricante + "</td></font>>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='150px' align='center'><font color=#FFFAFA>" + produto.Nome + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='200px' align='center'><font color=#FFFAFA>" + produto.Data + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='200px' align='center'><font color=#FFFAFA>" + produto.Descricao + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='100px' align='center'><font color=#FFFAFA>" + produto.Quantidade + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='150px' align='right'><font color=#FFFAFA>" + produto.ValorFinal.ToString("0.00") + "</td></font>");
                    sw.WriteLine("<td bgcolor=#8B4513 width ='150px' align='right'><font color=#FFFAFA>" + x.ToString("0.00") + "</td></font>");
                    sw.WriteLine("</tr>");
                    cont++;

                    soma = soma + x;
                }
                sw.WriteLine("</tr>");

                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' width='1500px' border='2px' border color='black'>");
                sw.WriteLine("<table>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th bgcolor=#8B8682>Total de Protudos Impressos:  <font color=#FF0000>>" + cont + "</tr></font>");
                sw.WriteLine("<th  bgcolor=#8B8682>Total de soma do Valor R$  <font color=#FF0000>" + soma.ToString("0.00") + "</tr></font>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</table>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
