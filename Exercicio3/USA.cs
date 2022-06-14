using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class USA : ICalculoImposto
    {
        public decimal TotalDeducao { get; set; }
        public decimal TotalRenda { get; set; }

        public decimal CalcularImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 30 / 100;
        }
    }
}
