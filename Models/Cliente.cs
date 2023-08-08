using System.ComponentModel.DataAnnotations;

namespace GestaoRegistro.Models;

public class Cliente
{
    [Key]
    [Display(Name = "Código")]
    public int IdCliente { get; set; }

    [Required(ErrorMessage = "Nome é Obrigatório.")]
    [Display(Name = "Nome")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Sobrenome é Obrigatório.")]
    [Display(Name = "Sobrenome")]
    public string Sobrenome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email é Obrigatório.")]
    [Display(Name = "Email")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Data de Cadastro é Obrigatório.")]
    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; }

    [Required(ErrorMessage = "Ativo é Obrigatório.")]
    [Display(Name = "Ativo")]
    public bool Ativo { get; set; }
}
