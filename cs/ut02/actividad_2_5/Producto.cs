namespace actividad_2_5;

class Producto
{
    public string Nombre;
    public string CodigoBarras;
    public int Existencias;
    public double PrecioCoste;
    public double PrecioVenta;

    public void Comprar(int cantidad, double precio)
    {
        Existencias += cantidad;
        PrecioCoste = precio;
    }

    public double Vender(int cantidad)
    {
        Existencias -= cantidad;
        return cantidad * PrecioVenta;
    }

    public void EstablecerMargen(double porcentaje)
    {
        PrecioVenta = PrecioCoste + PrecioCoste * porcentaje / 100;
    }
}