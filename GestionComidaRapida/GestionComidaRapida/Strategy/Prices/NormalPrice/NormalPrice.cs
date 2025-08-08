using System;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;

namespace GestionComidaRapida.Strategy.TiposDePrecio.PrecioNormal
{
    public class NormalPrice : IPrecioStrategy
    {
        public decimal calculatePrice(List<IProduct> products)
        {
            return products.Sum(p => p.PrecioBase);
        }
    }
}
   
