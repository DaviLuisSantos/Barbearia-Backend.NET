using System.ComponentModel.DataAnnotations;

namespace Barbearia_Backend.NET.Models;

public class Plano
{
    [Key]
    public int Id { get; set; }
    public int IdPagSeguro { get; set; }
    public string Nome { get; set; }
    public float Preco { get; set; }
    public int Profissionais { get; set; }
}
