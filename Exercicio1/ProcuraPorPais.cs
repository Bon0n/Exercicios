using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class ProcuraPorPais : IProcuraCliente
    {
        public Cliente ProcurarCliente(string pais)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Pais == pais);
            return resultado;
        }
    }
}
