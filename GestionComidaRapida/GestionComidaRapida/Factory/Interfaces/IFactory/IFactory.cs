using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.Enum;

namespace GestionComidaRapida.Factory.Interfaces.IFactory
{
    public interface IFactory
    {
        IProduct CrearProducto(ProductType tipo);
        IProduct CrearProductoGenerico(decimal precioBase);
    }
}
