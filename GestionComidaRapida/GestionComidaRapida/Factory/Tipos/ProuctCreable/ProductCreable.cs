using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.Enum;

namespace GestionComidaRapida.Factory.Tipos.ProuctoCreable
{
    public class ProductoCreable : IProduct
    {
        public string Name { get;}
        public decimal PrecioBase { get;}

        public ProductoCreable(ProductType type, decimal precio)
        {
            Name = type.ToString();
            PrecioBase = precio;
        }
    }
}
