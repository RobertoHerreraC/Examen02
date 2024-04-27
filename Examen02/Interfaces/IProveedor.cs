using Examen02.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Interfaces
{
    public interface IProveedor
    {
        public void EnviarPedido(Pedido pedido);
    }
}
