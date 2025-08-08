using System;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.TiposDePrecio.PrecioConDescuento;
using GestionComidaRapida.Strategy.TiposDePrecio.PrecioConImpuestos;
using GestionComidaRapida.Strategy.TiposDePrecio.PrecioNormal;


namespace GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy
{
    public interface IPrecioStrategy
    {
        decimal calculatePrice(List<IProduct> products);
    }
}




