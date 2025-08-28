// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Piscinas
{
    public int Id;
    public string? Nombre;
    public decimal Profundidad;
    public bool Activa;
    public DateTime FechaInaguración;
    public Estados? Estado;
    public List<Articulos>? Articulos;
    public Categorias? Categoria;

}

public class Estados
{
    public int Id;
    public string? Estado;
}

public class Articulos
{
    public int Id;
    public string? Articulo;
}

public class Categorias
{
    public int id;
    public string? Categoria;
}
