using System.ComponentModel.DataAnnotations;

namespace NunesStorage.Models;

public class Produtos
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public string Codigo { get; set; }

    public string? Descricao { get; set; }

    [Required]
    public Decimal Preco { get; set; }
 
}
