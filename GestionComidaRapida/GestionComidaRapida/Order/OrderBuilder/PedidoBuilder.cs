using System;
using GestionComidaRapida.Builder.Interfaces.IPedidoBuilder;
using GestionComidaRapida.Builder.PedidoEntity;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Builder.PedidoEntity
{
    public class PedidoBuilder : IOrderBuilder
    {
        private readonly Order _pedido;

        public PedidoBuilder(Order pedido)
        {
            _pedido = pedido;
        }
        public PedidoBuilder AgregarProducto(IProduct producto)
        {
            _pedido.Productos.Add(producto);
            return this;
        }
        public PedidoBuilder AplicarPrecio(IPrecioStrategy tiposPrecio)
        {
            _pedido.tiposPrecio = tiposPrecio;
            return this;
        }
        public Order Build()
        {
            return _pedido;
        }
    }
}
	
