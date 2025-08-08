using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionComidaRapida.Builder.PedidoEntity;
using GestionComidaRapida.Builder.Interfaces.IPedidoService;
using GestionComidaRapida.Factory.Interfaces.IterfaceIProduct;
using GestionComidaRapida.Strategy.Interfaces.IPrecioStrategy;
using GestionComidaRapida.Factory.FactortProducto;

namespace GestionComidaRapida.Builder.PedidoService
{
    public class OrderService : IOrderService
    {
        private readonly List<IProduct> _products;
        private IPrecioStrategy _StrategyPrice;

        public OrderService(List<IProduct> productos)
        {
            _products = productos; 
        }

        public void ConfigStrategy(IPrecioStrategy strategy)
        {
            _StrategyPrice = strategy;
        }

        public void AddProduct(IProduct producto)
        {
            _products.Add(producto);
        }

        public List<IProduct> ObtenerProductos()
        {
            return _products;
        }

        public decimal GetTotal()
        {
            return _StrategyPrice?.calculatePrice(_products) ?? 0;
        }

        public void ShowInfo(IPrecioStrategy NormalStrategy, IPrecioStrategy DiscountStrategy, IPrecioStrategy TaxStrategy)
        {
            Console.WriteLine("Resumen del pedido:");
            foreach (var producto in _products)
                Console.WriteLine($"- {producto.Name}: ${producto.PrecioBase}");

            Console.WriteLine("----------------------------------------------");

            // Precio normal
            ConfigStrategy(NormalStrategy);
            decimal precioOriginal = GetTotal();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Subtotal original: ${precioOriginal:F2}");

            // Precio con descuento
            ConfigStrategy(DiscountStrategy);
            decimal precioConDescuento = GetTotal();

            //valida que exista el descuento
            if (precioConDescuento < precioOriginal)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Subtotal con descuento: ${precioConDescuento:F2}");
            }

            // Precio con impuestos
            ConfigStrategy(TaxStrategy);
            decimal precioConImpuestos = GetTotal();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total con impuesto: ${precioConImpuestos:F2}");

            Console.ResetColor();
        }
    }
}
