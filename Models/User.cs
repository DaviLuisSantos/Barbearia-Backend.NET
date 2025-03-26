using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barbearia_Backend.NET.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public string Celular { get; set; }
    public string Senha { get; set; }
}
