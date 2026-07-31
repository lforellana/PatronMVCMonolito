using System.ComponentModel;

namespace BibliotecaMonolito.Models;

public class Author
{
    public int Id { get;set;}

    public string Nombre {get; set; } = string.Empty;
    public string Nacionalidad {get; set; } = string.Empty;

    public List<Libro> Libros {get; set; } = new();
}

