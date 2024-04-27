using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clases
{
    public class ProveedorRopa : IProveedor
    {
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine($"Enviando pedido de productos de ropa: {pedido.Producto} {pedido.Costo}");
        }
    }
}
