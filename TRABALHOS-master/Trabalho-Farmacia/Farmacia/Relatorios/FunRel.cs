using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Farmacia.Relatorios
{
    public class FunRel
    {
        public static string diretorioPasta()
        {
            string folder = @"C:\RelFarmacia";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            return folder;
        }
    }
}
