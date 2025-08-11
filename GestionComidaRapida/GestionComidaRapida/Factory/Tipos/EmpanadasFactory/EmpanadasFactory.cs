using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.InterfaceProductFactory;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.Enum;
using GestionComidaRapida.Factory.Tipos.ProuctoCreable;

namespace GestionComidaRapida.Factory.Tipos.EmpanadasFactory
{
    public class EmpanadaFactory : IProductFactory
    {
        public IProduct Crear() => new ProductoCreable(ProductType.Empanada, 1500m);
    }
}
