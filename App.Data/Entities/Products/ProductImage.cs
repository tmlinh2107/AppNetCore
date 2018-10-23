using App.Data.DomainEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("ProductImages")]
    public class ProductImage : EntityBase<int>
    {
        public int ProductId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}