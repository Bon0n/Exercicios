using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Pedido
    {
        private readonly ILogger _logger;

        public Pedido(ILogger logger)
        {
            _logger = logger;
        }
        public virtual void AdicionarPedido()
        {
            try
            {
                _logger.Registrar($"Pedido incluido em: {DateTime.Now}");
            }
            catch(Exception e)
            {
                _logger.Registrar($"{e} - {DateTime.Now}");
            }
        }
    }
}
