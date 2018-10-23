﻿using App.Data.DomainEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Products
{
    [Table("ProductQuantities")]
    public class ProductQuantity : EntityBase<int>
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }

        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
    }
}