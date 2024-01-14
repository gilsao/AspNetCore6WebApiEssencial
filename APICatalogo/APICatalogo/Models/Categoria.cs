using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

[Table("Categorias")]
public class Categoria
{
    //Aqui usamos Data Annotations para Sobrescrever as conveções padrão do EF Core.
    //Também podemos usar esse recurso para:
    //    Definir regras de validação para o modelo
    //    Definir como os dados devem ser exibidos na interface(*)
    //    Especificar o relacionamento entre as entidades do modelo
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
