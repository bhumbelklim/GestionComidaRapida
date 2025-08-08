using System;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Strategy.TiposDePrecio.PrecioConImpuestos
{
    public class TaxPrice : IPrecioStrategy
    {
        private const decimal tax = 0.21m; 
        public decimal calculatePrice(List<IProduct> products)
        {
            var subtotal = products.Sum(p => p.PrecioBase);
            return subtotal * (1 + tax);
        }
    }
}

