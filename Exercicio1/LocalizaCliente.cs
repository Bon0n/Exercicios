using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class LocalizaCliente
    {
        private static IProcuraCliente _procuraCliente;
        public LocalizaCliente(IProcuraCliente procuraCliente)
        {
            _procuraCliente = procuraCliente;
        }
        public static Cliente ProcurarCliente(string dado)
        {
            var cliente = _procuraCliente.ProcurarCliente(dado);
            return cliente;
        }
    }
}
