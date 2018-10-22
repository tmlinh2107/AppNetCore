using App.Data.DomainEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("ProductCategories")]
    public class ProductCategory : EntityBase<int>
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public ProductCategory(int productId, int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        [ForeignKey("ProductId")]
        public virtual ICollection<Product> Products { set; get; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<Category> Categories { set; get; }
    }
}