﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;

namespace QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Product
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoPageTitle { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string SeoAlias { get; set; }
        [StringLength(255)]
        public string SeoKeywords { get; set; }
        [StringLength(255)]
        public string SeoDescription { get; set; }
        public int SortOrder { get; set; }
        //Đây là mối quan hệ 1 - nhiều (1 danh mục nhiều products)
        public ICollection<ProductViewModel> Products { get; set; }
    }
}
