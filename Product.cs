public class Products
{
    public Guid IdProduct { get; private set; }
    public string Name { get; private set; }
    public decimal price { get; private set; }

    Products(string Name, decimal price)
    {
        IdProduct = Guid.NewGuid();
        Name = Name;
        price = price;
    }

    public Products show()
    {
        Console.WriteLine("1- Agregar nuevo Producto");
        Console.WriteLine("2- Editar Producto");
        Console.WriteLine
    }

    

}