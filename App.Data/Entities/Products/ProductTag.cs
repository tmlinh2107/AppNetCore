using App.Data.DomainEntity;
using App.Data.Entities.Tags;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("ProductTags")]
    public class ProductTag : EntityBase<int>
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string TagId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}