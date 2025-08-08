using System;
using GestionComidaRapida.Builder.Interfaces.IPedidoService;
using GestionComidaRapida.Builder.PedidoService;
using GestionComidaRapida.Factory.FactortProducto;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Factory.ProductoSinNombre;
using GestionComidaRapida.Factory.Tipos.Enum;
using GestionComidaRapida.Helpers.UniversalHelpers;
using GestionComidaRapida.Strategy.TiposDePrecio.PrecioConDescuento;
using GestionComidaRapida.Strategy.TiposDePrecio.PrecioConImpuestos;
using Microsoft.Extensions.DependencyInjection;
using GestionComidaRapida.Factory.Interfaces.InterfaceProductFactory;
using GestionComidaRapida.Strategy.TiposDePrecio.PrecioNormal;

public class Program
{
    static void Main()
    {
        var serverProvider = new ServiceCollection();

        serverProvider.AddSingleton<List<IProduct>>();

        serverProvider.AddSingleton<IOrderService, OrderService>();
        serverProvider.AddSingleton<FactoryProduct>();

        serverProvider.AddSingleton<NormalPrice>();
        serverProvider.AddSingleton<DiscountPrice>();
        serverProvider.AddSingleton<TaxPrice>();
        serverProvider.AddSingleton<ProductWithoutName>();

        var provider = serverProvider.BuildServiceProvider();

        var OrderService = provider.GetRequiredService<IOrderService>();
        var factory = provider.GetRequiredService<FactoryProduct>();

        var Discount = provider.GetRequiredService<DiscountPrice>();
        var Tax = provider.GetRequiredService<TaxPrice>();
        var original = provider.GetRequiredService<NormalPrice>();

        var productWithOutName = provider.GetRequiredService<ProductWithoutName>();

        int MenuOption;
        do
        {
            var MenuSwitch = UniversalHelpers.MenuHelper(out MenuOption);

            if (!MenuSwitch.esValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(MenuSwitch.mensajeError);
                Console.ResetColor();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            switch (MenuOption)
            {
                case 1:
                    Console.WriteLine("Seleccione productos para agregar:");
                    Console.WriteLine("--HAY DESCUENTO 15% SI LLEVAS DOS PRODUCTOS IGUALES--");
                    Console.WriteLine("1. Hamburguesa");
                    Console.WriteLine("2. Pizza");
                    Console.WriteLine("3. Empanada");
                    Console.WriteLine("0. Finalizar pedido");

                    string foodOptionInput;
                    do
                    {
                        foodOptionInput = Console.ReadLine();
                        if (foodOptionInput == "0") break;

                        if (int.TryParse(foodOptionInput, out int tipoInt) && tipoInt >= 1 && tipoInt <= 3)
                        {
                            var productType = (ProductType)tipoInt;
                            var product = provider.GetRequiredService<FactoryProduct>().Crear(productType);

                            OrderService.AddProduct(product);

                            Console.WriteLine($"{product.Name} agregado.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Error. ");
                            Console.ResetColor();
                            Console.WriteLine("Opcion invalida.");
                            Console.ResetColor();
                        }

                    } while (true);

                    break;
                case 2:

                    var productcase2 = OrderService.ObtenerProductos();

                    if (productcase2.Count == 0)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.Write("Error. ");
                        Console.ResetColor();
                        Console.WriteLine("Agrega productos en case 1");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    OrderService.ShowInfo(original, Discount, Tax);

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    break;
            }
        } while (MenuOption != 3);
    }
}