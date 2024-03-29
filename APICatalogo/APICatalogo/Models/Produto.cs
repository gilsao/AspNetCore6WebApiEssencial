﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models
{
    //Aqui usamos Data Annotations para Sobrescrever as conveções padrão do EF Core.
    //Também podemos usar esse recurso para:
    //    Definir regras de validação para o modelo
    //    Definir como os dados devem ser exibidos na interface(*)
    //    Especificar o relacionamento entre as entidades do modelo

    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string? Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }

        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        /*
         * Propriedade de navegação que indica ao EF Core o relacionamento entre as entidades Categoria e Produto.
         * Nesse caso incluimos uma propriedade CategoriaId que mapeia para a chave estrangeira no banco de dados e uma
         * propriedade de navegação Categoria para indicar que um Produto está relacionado com uma Categoria.
         * */

        public int CategoriaId { get; set; }

        [JsonIgnore]
        public Categoria? Categoria { get; set; }
    }
}
