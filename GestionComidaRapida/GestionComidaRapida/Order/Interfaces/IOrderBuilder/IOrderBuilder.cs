using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Builder.PedidoEntity;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Builder.Interfaces.IPedidoBuilder
{
    public interface IOrderBuilder
    {
        PedidoBuilder AgregarProducto(IProduct producto);
        PedidoBuilder AplicarPrecio(IPrecioStrategy estrategia);
        Order Build();
    }
}
