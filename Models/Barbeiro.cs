using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barbearia_Backend.NET.Models;

public class Barbeiro
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Imagem { get; set; }
    [ForeignKey("Barbearia")]
    public int BarbeariaId { get; set; }
    public Barbearia Barbearia { get; set; }
}
