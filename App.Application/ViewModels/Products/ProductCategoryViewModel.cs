using App.Data.Enums;
using System;
using System.Collections.Generic;

namespace App.Application.ViewModels.Products
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime CreatedDate { set; get; }
        public DateTime ModifiedDate { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public virtual ICollection<ProductViewModel> Products { set; get; }
    }
}