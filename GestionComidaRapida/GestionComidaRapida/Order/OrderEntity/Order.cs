using System;
using GestionComidaRapida.Builder.PedidoEntity;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Builder.PedidoEntity
{
    public class Order
    {
        public List<IProduct> Productos { get; set; } = new();
        public IPrecioStrategy tiposPrecio { get; set; }
        
    }
}

