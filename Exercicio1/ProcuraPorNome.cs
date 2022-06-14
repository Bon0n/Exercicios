using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class ProcuraPorNome : IProcuraCliente
    {
        public Cliente ProcurarCliente(string nome)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Nome == nome);
            return resultado;
        }
    }
}
