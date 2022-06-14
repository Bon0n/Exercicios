using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class ArquivoLogger : ILogger
    {
        public void Registrar(string message)
        {
            File.WriteAllText(@"C:\Users\andrei.oliveira\Desktop\log.txt", message);
        }
    }
}
