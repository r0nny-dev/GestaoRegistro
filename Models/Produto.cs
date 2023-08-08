using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GestaoRegistro.Models;

public class Produto
{
    [Key]
    [Display(Name = "Código Produto")]
    public int IdProduto { get; set; }

    [Required(ErrorMessage = "Nome é Obrigatório.")]
    [Display(Name = "Descrição")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Valor é Obrigatório.")]
    [Display(Name = "Valor")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "Disponível é Obrigatório.")]
    [Display(Name = "Disponível")]
    public bool Disponivel { get; set; }

    [ForeignKey("Cliente")]
    [Required(ErrorMessage = "Código Cliente é Obrigatório.")]
    [Display(Name = "Código Cliente")]
    public int IdCliente { get; set; }

    [Display(Name = "Cliente")]
    public Cliente? Cliente { get; set; }
}
