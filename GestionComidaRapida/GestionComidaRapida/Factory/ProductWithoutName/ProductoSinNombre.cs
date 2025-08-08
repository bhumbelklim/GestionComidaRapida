using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;

namespace GestionComidaRapida.Factory.ProductoSinNombre
{
    public class ProductWithoutName : IProduct
    {
        public string Name => "Subtotal";
        public decimal PrecioBase { get; set; } 
    }


}
