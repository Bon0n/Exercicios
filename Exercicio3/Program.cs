using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculoImposto calculoImpostoBrasil = new Brazil();
            calculoImpostoBrasil.TotalRenda = 1000;
            calculoImpostoBrasil.TotalDeducao = 100;

            CalcularImposto calcularImposto = new CalcularImposto();
            var valor = calcularImposto.Calcular(calculoImpostoBrasil);
            Console.WriteLine(valor);
            
        }
    }
}
