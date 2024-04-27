
using Examen02.Clases;

ProveedorElectronica proveedorElectronica = new ProveedorElectronica();
ProveedorRopa proveedorRopa = new ProveedorRopa();

Pedido pedidoElectronica = new Pedido { Producto = "Celular", Costo = 2500 };
Pedido pedidoRopa = new Pedido { Producto = "Camisa", Costo = 60 };

GestorPedidos gestorPedidos1 = new GestorPedidos(proveedorElectronica,pedidoElectronica ); 
GestorPedidos gestorPedidos2 = new GestorPedidos(proveedorRopa, pedidoRopa);

gestorPedidos1.EnviarPedidoSegunTipoProducto();
gestorPedidos2.EnviarPedidoSegunTipoProducto();
