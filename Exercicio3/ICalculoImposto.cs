using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public interface ICalculoImposto
    {
        decimal TotalDeducao { get; set; }
        decimal TotalRenda { get; set; }
        decimal CalcularImposto();
    }
}
