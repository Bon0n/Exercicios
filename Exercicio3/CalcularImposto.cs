﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class CalcularImposto
    {
        public decimal Calcular(ICalculoImposto calculoImposto)
        {
            return calculoImposto.CalcularImposto();
        }
    }
}
