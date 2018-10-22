using App.Data.DomainEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Entities.Products
{
    public class Product : EntityBase<int>
    {
        public Product()
        {
        }

        public Product(
            string name, 
            string image, 
            decimal price, 
            decimal? promotionPrice, 
            decimal originalPrice, 
            string description, 
            string content, 
            bool? homeFlag,
            bool? hotFlag, 
            int? viewCount, 
            string tags, 
            string unit, 
            string seoPageTitle, 
            string seoAlias, 
            string seoKeywords, 
            string seoDescription)
        {
            Name = name;
            Image = image;
            Price = price;
            PromotionPrice = promotionPrice;
            OriginalPrice = originalPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            ViewCount = viewCount;
            Tags = tags;
            Unit = unit;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescription;
        }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        [Required]
        public decimal OriginalPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        [StringLength(255)]
        public string Unit { get; set; }

        public string SeoPageTitle { set; get; }

        [StringLength(255)]
        public string SeoAlias { set; get; }

        [StringLength(255)]
        public string SeoKeywords { set; get; }

        [StringLength(255)]
        public string SeoDescription { set; get; }

        public virtual ICollection<ProductTag> ProductTags { set; get; }
    }
}