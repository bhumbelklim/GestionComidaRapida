using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.Enum;

namespace GestionComidaRapida.Factory.Interfaces.InterfaceProductFactory
{
    public interface IProductFactory
    {
        IProduct CrearProductoGenerico(decimal precioBase);
        IProduct Crear(ProductType type);
    }


}
