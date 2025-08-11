using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.InterfaceProductFactory;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.Enum;
using GestionComidaRapida.Factory.Tipos.ProuctoCreable;

namespace GestionComidaRapida.Factory.Tipos.PizzaFactory
{
    public class PizzaFactory : IProductFactory
    {
        public IProduct Crear() => new ProductoCreable(ProductType.Pizza, 2500m);
    }
}
