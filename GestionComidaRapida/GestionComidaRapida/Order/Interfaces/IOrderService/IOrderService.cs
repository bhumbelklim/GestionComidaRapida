using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Builder.PedidoEntity;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Builder.Interfaces.IPedidoService
{
    public interface IOrderService
    {
        void ConfigStrategy(IPrecioStrategy estrategia);
        void AddProduct(IProduct producto);
        List<IProduct> ObtenerProductos();
        void ShowInfo(IPrecioStrategy estrategiaNormal, IPrecioStrategy estrategiaDescuento, IPrecioStrategy estrategiaImpuesto);
    }
}
