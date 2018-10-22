using App.Data.DomainEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("Categories")]
    public class Category : EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}