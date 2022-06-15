using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueWeb.Models
{
    [Table("ItemPedido")]
    public class ItemPedidoModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPedido {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDProduto {get; set;}

        public int Quantidade {get; set;}

        public double ValorUnitario {get; set;}

        [ForeignKey("IDPedido")]
        public PedidoModel Pedido {get; set;}

        [ForeignKey("IDProduto")]
        public ProdutoModel Produto {get; set;}

        [NotMapped]
        public double ValorItem{get => this.Quantidade * this.ValorUnitario;}
        

    }
}