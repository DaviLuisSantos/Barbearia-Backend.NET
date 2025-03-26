using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barbearia_Backend.NET.Models;

public class Barbearia
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public byte[] Imagem { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
}
