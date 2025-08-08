using System;
using GestionComidaRapida.Factory.Tipos.Enum;

namespace GestionComidaRapida.Factory.Interfaces.IterfaceIProduct
{
    public interface IProduct
    {
        string Name { get; }
        decimal PrecioBase { get; }
    }
}
	
