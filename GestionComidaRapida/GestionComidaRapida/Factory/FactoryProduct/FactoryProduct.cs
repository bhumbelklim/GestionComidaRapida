using System;
using GestionComidaRapida.Factory.Tipos.Enum;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.ProuctoCreable;
using GestionComidaRapida.Factory.ProductoSinNombre;

namespace GestionComidaRapida.Factory.FactortProducto
{
    public class FactoryProduct
    {
        public const string ErrorMessageType = "Tipo no válido";

        public IProduct Crear(ProductType type)
        {
            return type switch
            {
                ProductType.Hamburguesa => new ProductoCreable(type, 2000m),
                ProductType.Pizza => new ProductoCreable(type, 2500m),
                ProductType.Empanada => new ProductoCreable(type, 1500m),
                _ => throw new ArgumentException(ErrorMessageType)
            };
        }

        public IProduct CrearProductoGenerico(decimal originalPrice)
        {
            return new ProductWithoutName { PrecioBase = originalPrice };
        }


    }
}
	
