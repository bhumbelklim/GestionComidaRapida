using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Helpers.UniversalHelpers
{
    public class UniversalHelpers
    {
        public static (bool esValido, string mensajeError) MenuHelper(out int name)
        {
            Console.WriteLine("=== Sistema de Pedidos===");
            Console.WriteLine(" 1.Agregar Productos");
            Console.WriteLine(" 2.Mostrar Pedido");
            Console.WriteLine(" 3.Salir");

            string MenuInput = Console.ReadLine();

            if (!int.TryParse(MenuInput, out name) || name < 1 || name > 3)
            {
                return (false, "Debes ingresar un número entre 1 y 4.");
            }

            return (true, string.Empty);
        }
    }
}
