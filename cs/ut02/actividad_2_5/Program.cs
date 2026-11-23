namespace actividad_2_5;

class Program
{
    static void Main(string[] args)
    {
        Producto producto = new Producto();

        Console.Write("Nombre del producto: ");
        producto.Nombre = Console.ReadLine();

        Console.Write("Precio de coste por unidad: ");
        double precioCoste = double.Parse(Console.ReadLine());

        Console.Write("Cantidad comprada: ");
        int cantidadComprada = int.Parse(Console.ReadLine());

        Console.Write("Margen de venta (%): ");
        double margen = double.Parse(Console.ReadLine());

        Console.Write("Cantidad vendida: ");
        int cantidadVendida = int.Parse(Console.ReadLine());

        producto.Comprar(cantidadComprada, precioCoste);
        producto.EstablecerMargen(margen);
        double importeVenta = producto.Vender(cantidadVendida);

        Console.WriteLine("Importe total de la venta: " + importeVenta + " €");
        Console.WriteLine("Unidades restantes en existencias: " + producto.Existencias);
    }
}