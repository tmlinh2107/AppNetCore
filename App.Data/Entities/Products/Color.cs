using App.Data.DomainEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("Colour")]
    public class Color : EntityBase<int>
    {
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(350)]
        public string Code { get; set; }
    }
}