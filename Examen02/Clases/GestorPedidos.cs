using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clases
{
    public class GestorPedidos
    {
        private readonly IProveedor _proveedor;
        private Pedido _pedido;

        public GestorPedidos(IProveedor proveedor, Pedido pedido)
        {
            _proveedor = proveedor;
            _pedido = pedido;
        }

        public void EnviarPedidoSegunTipoProducto()
        {
            _proveedor.EnviarPedido(_pedido);
        }
    }
}
