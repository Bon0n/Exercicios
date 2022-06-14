using ConsoleApp1;
using System.Collections.Generic;

namespace Exercicio1
{
    public interface IExportaCliente
    {
        string Exportar(List<Cliente> dados);
    }
}