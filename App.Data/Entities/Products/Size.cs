using App.Data.DomainEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("Sizes")]
    public class Size : EntityBase<int>
    {
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(350)]
        public string Code { get; set; }
    }
}