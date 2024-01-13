using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Categorias")]
public class Categoria
{
    public Categoria()
    {
        //Inicialização da Propriedade Produto.
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    /* Propriedade de navegação que indica ao EF Core o relacionamento entre
     * as entidades Categoria e Produto.
     * Nesse caso indicamos que Categoria pode conter uma coleção de Produtos
    */
    public ICollection<Produto>? Produtos { get; set; }
}
