using System;
using GestionComidaRapida.Factory.Tipos.Enum;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.ProuctoCreable;
using GestionComidaRapida.Factory.ProductoSinNombre;
using GestionComidaRapida.Factory.Tipos.EmpanadasFactory;
using GestionComidaRapida.Factory.Tipos.HamburguesaFactory;
using GestionComidaRapida.Factory.Tipos.PizzaFactory;
using GestionComidaRapida.Factory.Interfaces.IFactory;

namespace GestionComidaRapida.Factory.FactortProducto
{
    public class FactoryProduct : IFactory
    {
        public const string ErrorMessageType = "Tipo no válido";

        private readonly PizzaFactory _pizzaFactory;
        private readonly HamburguesaFactory _hamburguesaFactory;
        private readonly EmpanadaFactory _empanadaFactory;

        public FactoryProduct(
            PizzaFactory pizzaFactory,
            HamburguesaFactory hamburguesaFactory,
            EmpanadaFactory empanadaFactory)
        {
            _pizzaFactory = pizzaFactory;
            _hamburguesaFactory = hamburguesaFactory;
            _empanadaFactory = empanadaFactory;
        }

        public IProduct CrearProducto(ProductType tipo)
        {
            return tipo switch
            {
                ProductType.Pizza => _pizzaFactory.Crear(),
                ProductType.Hamburguesa => _hamburguesaFactory.Crear(),
                ProductType.Empanada => _empanadaFactory.Crear(),
                _ => throw new ArgumentException($"{ErrorMessageType}{tipo}")
            };
        }
        public IProduct CrearProductoGenerico(decimal originalPrice)
        {
            return new ProductWithoutName { PrecioBase = originalPrice };
        }
    }
}
	
