using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.Tipos.ProuctoCreable;

namespace GestionComidaRapida.Helpers.ValidationHelpers
{
    public class ValidationHelpers
    {
        public static bool ShowErrorIfEmpty(List<IProduct> productcase2)
        {
            if (productcase2.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error. ");
                Console.ResetColor();
                Console.WriteLine("Agrega productos en case 1");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                return true;
            }

            return false; 
        }


    }
}
