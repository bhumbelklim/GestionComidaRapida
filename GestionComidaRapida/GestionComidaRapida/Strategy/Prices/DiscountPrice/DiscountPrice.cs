using System;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Strategy.TiposDePrecio.PrecioConDescuento
{
    public class DiscountPrice : IPrecioStrategy
    {
        private const decimal discount = 0.15m;

        public decimal calculatePrice(List<IProduct> products)
        {
            var subtotal = products.Sum(p => p.PrecioBase);

            bool hayRepetidos = products
                .GroupBy(p => p.GetType())
                .Any(g => g.Count() >= 2);

            if (hayRepetidos)
            {
                subtotal *= (1 - discount);
            }

            return subtotal;
        }
    }
}

